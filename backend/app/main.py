from fastapi import FastAPI

from app.core.config import settings
from app.api.main import apiRouter
from app.core.database import initDB

app = FastAPI(
    title=settings.PROJECT_NAME,
    docs_url=settings.DOCS_URL,
    root_path=settings.API_PATH
    )

app.include_router(apiRouter)