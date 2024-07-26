from fastapi import Depends, HTTPException, status, Request
from jose import JWTError, jwt
from fastapi.security import OAuth2PasswordBearer
from collections.abc import Generator
from typing import Annotated
from sqlmodel import Session

from app.models import user, tokenData
from app.core.config import settings
from app.crud import getUserByBoth
from app.core.database import engine

oauth2 = OAuth2PasswordBearer(tokenUrl="auth/login")

def getDB() -> Generator[Session, None, None]:
    with Session(engine) as session:
        yield session

sessionDep = Annotated[Session, Depends(getDB)]
tokenDep = Annotated[str, Depends(oauth2)]

async def getCurrentUser(session: sessionDep, token: tokenDep):
    credentialException = HTTPException(status_code=status.HTTP_401_UNAUTHORIZED, 
                                         detail="Could not validate credentials", headers={"WWW-Authenticate":"Bearer"})
    try:
        payload = jwt.decode(token, settings.SECRET_KEY, algorithms=[settings.ALGORITHM])
        username: str = payload.get("sub")
        if username is None:
            raise credentialException
        token_data = tokenData(username=username)
    except JWTError:
        raise credentialException

    user = getUserByBoth(session,usernameEmail=token_data.username)
    if user is None:
        raise credentialException
    
    return user

currentUser = Annotated[user, Depends(getCurrentUser)]