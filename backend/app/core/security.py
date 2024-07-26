from datetime import datetime, timedelta

from jose import jwt
from passlib.context import CryptContext

from app.core.config import settings
pwdContext = CryptContext(schemes=["bcrypt"], deprecated="auto")

def createAccessToken(data:dict, expiresDelta: timedelta or None = None):
    toEncode = data.copy()
    if expiresDelta:
        expire = datetime.utcnow() + expiresDelta
    else:
        expire = datetime.utcnow() + timedelta(minutes=15)
    
    toEncode.update({"exp": expire})
    encodedJWT = jwt.encode(toEncode, settings.SECRET_KEY, algorithm=settings.ALGORITHM)
    return encodedJWT

def verifyPassword(plain_password, hashed_password):
    return pwdContext.verify(plain_password, hashed_password)

def getPasswordHash(password):
    return pwdContext.hash(password)

def isUsernameValid(username: str):
    is_long_enough = len(username) >= 3
    is_short_enough = len(username) <= 40
    has_space = False
    has_special = False

    for char in username:
        if char.isspace():
            has_space = True
        if char in "!@#$%^&*()-_=+[]{}|;:,.<>?/":
            has_special = True

    if has_space:
        return "Username must not contain spaces."
    if not is_long_enough:
        return "Username must be at least 3 characters long."
    if not is_short_enough:
        return "Username must be at most 40 characters long."
    if has_special:
        return "Username contains an invalid character."
    return None

def isPasswordComplex(password: str):
    has_space = False
    is_long_enough = len(password) >= 8
    is_short_enough = len(password) <= 40
    has_alpha = False
    has_digit = False
    has_upper = False
    has_lower = False
    has_special = False

    for char in password:
        if char.isspace():
            has_space = True
        if char.isalpha():
            has_alpha = True
        if char.isdigit():
            has_digit = True
        if char.isupper():
            has_upper = True
        if char.islower():
            has_lower = True
        if char in "!@#$%^&*()-_=+[]{}|;:,.<>?/":
            has_special = True

    if has_space:
        return "Password must not contain spaces."
    if not is_long_enough:
        return "Password must be at least 8 characters long."
    if not is_short_enough:
        return "Password must be at most 40 characters long."
    if not has_alpha:
        return "Password must contain at least one letter."
    if not has_digit:
        return "Password must contain at least one digit."
    if not has_upper:
        return "Password must contain at least one uppercase letter."
    if not has_lower:
        return "Password must contain at least one lowercase letter."
    if not has_special:
        return "Password must contain at least one special character."
    return None