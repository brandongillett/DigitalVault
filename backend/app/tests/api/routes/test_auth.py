from fastapi.testclient import TestClient
from sqlmodel import Session

from app.crud import createUser
from app.models import userCreate
from app.tests.utils.utils import randomEmail, randomLowerString, testPassword


def testLogin(db: Session, client: TestClient) -> None:
    username = randomLowerString()
    email = randomEmail()
    userData = userCreate(username=username, email=email, password=testPassword)
    createUser(session=db, userCreate=userData)

    loginDataUsername = {"username": username, "password": testPassword}
    loginDataEmail = {"username": email, "password": testPassword}

    responseUsername = client.post("/auth/login", data=loginDataUsername)
    responseEmail = client.post("/auth/login", data=loginDataEmail)

    tokensUsername = responseUsername.json()
    tokensEmail = responseEmail.json()

    assert responseUsername.status_code == 200
    assert "access_token" in tokensUsername
    assert tokensUsername["access_token"]

    assert responseEmail.status_code == 200
    assert "access_token" in tokensEmail
    assert tokensEmail["access_token"]


def testLoginIncorrect(db: Session, client: TestClient) -> None:
    username = randomLowerString()
    email = randomEmail()
    userData = userCreate(username=username, email=email, password=testPassword)
    createUser(session=db, userCreate=userData)

    loginDataUsername = {"username": username, "password": "wrongpassword"}
    loginDataEmail = {"username": email, "password": "wrongpassword"}

    responseUsername = client.post("/auth/login", data=loginDataUsername)
    responseEmail = client.post("/auth/login", data=loginDataEmail)

    assert responseUsername.status_code == 401
    assert responseEmail.status_code == 401


def testRegister(db: Session, client: TestClient) -> None:
    username = randomLowerString()
    email = randomEmail()
    data = {"username": username, "email": email, "password": testPassword}

    response = client.post("/auth/register", json=data)
    user = response.json()

    assert response.status_code == 200
    assert user["username"] == username
    assert user["email"] == email
    assert user["id"]


def testRegisterUsernameExists(db: Session, client: TestClient) -> None:
    username = randomLowerString()
    email = randomEmail()
    data = {"username": username, "email": email, "password": testPassword}

    response1 = client.post("/auth/register", json=data)
    response2 = client.post("/auth/register", json=data)

    assert response1.status_code == 200
    assert response2.status_code == 409
    assert response2.json() == {"detail": "Username is already taken."}


def testRegisterEmailExists(db: Session, client: TestClient) -> None:
    username = randomLowerString()
    email = randomEmail()
    data1 = {"username": username, "email": email, "password": testPassword}
    data2 = {"username": randomLowerString(), "email": email, "password": testPassword}

    response1 = client.post("/auth/register", json=data1)
    response2 = client.post("/auth/register", json=data2)

    assert response1.status_code == 200
    assert response2.status_code == 409
    assert response2.json() == {"detail": "Email is already taken."}


def testRegisterUsernameInvalid(db: Session, client: TestClient) -> None:
    email = randomEmail()
    data1 = {"username": "a", "email": email, "password": testPassword}
    data2 = {"username": "a" * 31, "email": email, "password": testPassword}
    data3 = {"username": "a a", "email": email, "password": testPassword}

    response1 = client.post("/auth/register", json=data1)
    response2 = client.post("/auth/register", json=data2)
    response3 = client.post("/auth/register", json=data3)

    assert response1.status_code == 422
    assert response2.status_code == 422
    assert response3.status_code == 422


def testRegisterPasswordInvalid(db: Session, client: TestClient) -> None:
    username = randomLowerString()
    email = randomEmail()
    data1 = {"username": username, "email": email, "password": "a"}
    data2 = {"username": username, "email": email, "password": "a" * 7}
    data3 = {"username": username, "email": email, "password": "a" * 129}

    response1 = client.post("/auth/register", json=data1)
    response2 = client.post("/auth/register", json=data2)
    response3 = client.post("/auth/register", json=data3)

    assert response1.status_code == 422
    assert response2.status_code == 422
    assert response3.status_code == 422
