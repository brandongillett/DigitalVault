from fastapi import APIRouter

from app.api.routes import auth,users

apiRouter = APIRouter()

#auth routes
apiRouter.include_router(auth.router, tags=["auth"])
apiRouter.include_router(users.router, tags=["users"])
