from fastapi.encoders import jsonable_encoder
from sqlmodel import Session

from app.crud import createUser, authenticateUser
from app.core.security import verifyPassword
from app.models import userCreate,user
from app.tests.utils.utils import randomEmail,testPassword,randomLowerString

def testCreateUser(db: Session) -> None:
    username = randomLowerString()
    email = randomEmail()

    create = userCreate(username=username,email=email, password=testPassword)
    newUser = createUser(session=db, userCreate=create)

    assert newUser.email == email
    assert newUser.username == username
    assert verifyPassword(testPassword, newUser.password)
    assert newUser.id

def testGetUser(db: Session) -> None:
    username = randomLowerString()
    email = randomEmail()

    create = userCreate(username=username,email=email, password=testPassword)
    newUser1 = createUser(session=db, userCreate=create)
    newUser2 = db.get(user, newUser1.id)

    assert newUser2
    assert newUser1.email == newUser2.email
    assert newUser1.username == newUser2.username
    assert jsonable_encoder(newUser1) == jsonable_encoder(newUser2)


def testAuthenticateUser(db: Session) -> None:
    username = randomLowerString()
    email = randomEmail()

    create = userCreate(username=username,email=email, password=testPassword)
    newUser = createUser(session=db, userCreate=create)
    authenticatedUser = authenticateUser(session=db, usernameEmail=email, password=testPassword)

    assert authenticatedUser
    assert newUser.email == authenticatedUser.email

def testNotAuthenticateUser(db: Session) -> None:
    username = randomLowerString()
    email = randomEmail()

    newUser1 = authenticateUser(session=db, usernameEmail=username, password=testPassword)
    newUser2 = authenticateUser(session=db, usernameEmail=email, password=testPassword)
    
    assert newUser1 is None
    assert newUser2 is None