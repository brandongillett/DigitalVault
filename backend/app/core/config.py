from pydantic_settings import BaseSettings
from typing import Literal
import secrets

class settings(BaseSettings):
    PROJECT_NAME: str
    ENVIRONMENT: Literal["local", "production"] = "local"
    SECRET_KEY: str = secrets.token_urlsafe(32)
    DATABASE_URL: str
    API_PATH: str = "/api"
    ALGORITHM: str = "HS256"
    # 60 minutes * 24 hours * 7 days = 7 days
    ACCESS_TOKEN_EXPIRE_MINUTES: int = 60 * 24 * 7\

    def getDocsUrl(self):
        if self.ENVIRONMENT == "local":
            return f"/docs"
        else:
            return None
    #docs url if environment is local
    DOCS_URL = property(getDocsUrl)

settings = settings()