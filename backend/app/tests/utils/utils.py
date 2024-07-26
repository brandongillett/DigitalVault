import random
import string

from fastapi.testclient import TestClient

from app.core.config import settings

testPassword = "Password@2"

def randomLowerString() -> str:
    return "".join(random.choices(string.ascii_lowercase, k=30))

def randomEmail() -> str:
    return f"{randomLowerString()}@{randomLowerString()}.com"