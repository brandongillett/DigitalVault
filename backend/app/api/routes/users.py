from fastapi import APIRouter

from app.models import userPublic
from app.api.deps import currentUser


router = APIRouter()

@router.get("/user/me", response_model=userPublic)
async def myDetails(currentUser: currentUser):
    """
    Get the current user details.
    """
    return currentUser