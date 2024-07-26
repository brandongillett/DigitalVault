from pydantic import EmailStr
from typing import Optional
from sqlmodel import Field, Relationship, SQLModel

# Base models
class userBase(SQLModel):
    username: str = Field(unique=True, index=True, max_length=30)
    email: EmailStr = Field(unique=True, index=True, max_length=255)
    
# Database models
class user(userBase,table=True):
    id: int | None = Field(default=None, primary_key=True)
    password: str
    
# API models
class token(SQLModel):
    access_token: str
    token_type: str

class tokenData(SQLModel):
    username: str | None = None

class userCreate(userBase):
    password: str = Field(min_length=8, max_length=40)

class userPublic(userBase):
    id: int
