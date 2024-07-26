from fastapi import APIRouter,Depends,HTTPException,status
from fastapi.security import OAuth2PasswordRequestForm
from datetime import timedelta
from typing import Annotated

from app.core.config import settings
from app.models import userCreate,userPublic,token
from app.crud import authenticateUser,getUserByBoth, getUserByEmail,getUserByUsername,createUser
from app.core.security import createAccessToken, isPasswordComplex, isUsernameValid
from app.api.deps import sessionDep

router = APIRouter()

@router.post("/auth/register", response_model=userPublic)
async def register(*, session: sessionDep, user: userCreate):
    """
    Register a new user.
    """
    userUsername = getUserByUsername(session,username=user.username)
    userEmail = getUserByEmail(session,email=user.email)
    usernameValid = isUsernameValid(user.username)
    passwordComplexity = isPasswordComplex(user.password)
    if userUsername:
            raise HTTPException(
                status_code=status.HTTP_409_CONFLICT,
                detail="Username is already taken."
            )
    if userEmail:
        raise HTTPException(
                status_code=status.HTTP_409_CONFLICT,
                detail="Email is already taken."
            )
    if usernameValid is not None:
        raise HTTPException(
                status_code=status.HTTP_422_UNPROCESSABLE_ENTITY,
                detail=usernameValid
            )
    if passwordComplexity is not None:
        raise HTTPException(
                status_code=status.HTTP_422_UNPROCESSABLE_ENTITY,
                detail=passwordComplexity
            )
    return createUser(session,userCreate=user)

@router.post("/auth/login", response_model=token)
def login(session: sessionDep,formData: Annotated[OAuth2PasswordRequestForm, Depends()]):
    """
    Login a user and return an access token.
    """
    user = authenticateUser(session,formData.username, formData.password)
    if user:
        accessTokenExpires = timedelta(minutes=settings.ACCESS_TOKEN_EXPIRE_MINUTES)
        accessToken = createAccessToken(
            data={"sub":user.username}, expiresDelta=accessTokenExpires
        )
        return token(access_token=accessToken,token_type="bearer")
    else:
        raise HTTPException(status_code=status.HTTP_401_UNAUTHORIZED, 
                            detail="Invalid credentials.", headers={"WWW-Authenticate":"Bearer"})