import pytest
from fastapi.testclient import TestClient
from sqlmodel import Session, delete

from app.core.config import settings
from app.core.database import engine, initDB
from app.main import app
from app.models import user


@pytest.fixture(scope="session", autouse=True)
def db():
    with Session(engine) as session:
        initDB()
        yield session
        statement = delete(user)
        session.execute(statement)
        session.commit()


@pytest.fixture(scope="module")
def client():
    with TestClient(app) as c:
        yield c