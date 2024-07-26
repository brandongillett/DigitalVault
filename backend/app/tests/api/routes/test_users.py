from fastapi.testclient import TestClient
from sqlmodel import Session

from app.crud import createUser
from app.models import userCreate
from app.tests.utils.utils import randomEmail, randomLowerString, testPassword


def testMyDetails(db: Session, client: TestClient) -> None:
    username = randomLowerString()
    email = randomEmail()
    userData = userCreate(username=username, email=email, password=testPassword)
    newUser = createUser(session=db, userCreate=userData)

    loginResponse = client.post("/auth/login", data={"username": username, "password": testPassword})
    tokens = loginResponse.json()

    headers = {"Authorization": f"Bearer {tokens['access_token']}"}
    userResponse = client.get("/user/me", headers=headers)
    userDetails = userResponse.json()

    assert userResponse.status_code == 200
    assert userDetails["username"] == username
    assert userDetails["email"] == email
    assert userDetails["id"] == newUser.id


def testMyDetailsIncorrect(db: Session, client: TestClient) -> None:
    username = randomLowerString()
    email = randomEmail()
    userData = userCreate(username=username, email=email, password=testPassword)
    createUser(session=db, userCreate=userData)

    loginResponse = client.post("/auth/login", data={"username": username, "password": testPassword})
    tokens = loginResponse.json()

    headers = {"Authorization": f"Bearer {tokens['access_token']}wrong"}
    userResponse = client.get("/user/me", headers=headers)

    assert userResponse.status_code == 401
    assert userResponse.json() == {"detail": "Could not validate credentials"}


def testMyDetailsNoToken(db: Session, client: TestClient) -> None:
    userResponse = client.get("/user/me")

    assert userResponse.status_code == 401
    assert userResponse.json() == {"detail": "Not authenticated"}
