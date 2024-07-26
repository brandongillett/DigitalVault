from sqlmodel import Session, select

from app.models import user,userCreate
from app.core.security import verifyPassword, getPasswordHash

def createUser(session: Session,userCreate: userCreate):
    dbObj = user.model_validate(
        userCreate, update={"password": getPasswordHash(userCreate.password)}
    )
    session.add(dbObj)
    session.commit()
    session.refresh(dbObj)
    return dbObj

def getUserByBoth(session:Session, usernameEmail: str):
    sessionUser = session.exec(select(user).where((user.email == usernameEmail) | (user.username == usernameEmail))).first()
    return sessionUser

def getUserByUsername(session: Session, username: str):
    sessionUser = session.exec(select(user).where(user.username == username)).first()
    return sessionUser

def getUserByEmail(session: Session, email: str):
    sessionUser = session.exec(select(user).where(user.email == email)).first()
    return sessionUser
    
def authenticateUser(session: Session,usernameEmail: str, password: str):
    user = getUserByBoth(session,usernameEmail)
    if user and verifyPassword(password, user.password):
        return user
    return None