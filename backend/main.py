from fastapi import Depends, FastAPI, HTTPException, status
from fastapi.security import OAuth2PasswordRequestForm
from datetime import timedelta
from api.models import Token,User,NewUser
from api.auth import get_current_active_user,authenticate_user,create_access_token,new_user
from api.encryption import new_password,get_passwords,del_password,edit_password,genFernetKey,new_card,edit_card,get_cards,del_card
from api.config import ACCESS_TOKEN_EXPIRE_MINUTES,TITLE,DESCRIPTION,VERSION,DOCS

app = FastAPI(title=TITLE,description=DESCRIPTION,version=VERSION,docs_url=DOCS)

@app.post("/createAccount")
async def addAccount(user: NewUser):
    return new_user(user.username,user.email,user.password)

@app.post("/login")
async def login(form_data: OAuth2PasswordRequestForm = Depends()):
    user = authenticate_user(form_data.username, form_data.password)
    if user:
        access_token_expires = timedelta(minutes=ACCESS_TOKEN_EXPIRE_MINUTES)
        access_token = create_access_token(
        data={"sub":user.username}, expires_delta=access_token_expires)
        return {'status':True,"access_token":access_token,"token_type":"bearer","fernet_key":genFernetKey(form_data.password)}
    else:
        return {'status':False,"message":"Invalid credentials."}

@app.get("/users/me/info", response_model=User)
async def user_credentials(current_user: User = Depends(get_current_active_user)):
    return current_user

@app.post("/users/me/newPassword")
async def user_addPass(fernetKey: str,service: str,username: str,password: str,notes: str,current_user: User = Depends(get_current_active_user)):
    return new_password(current_user,fernetKey,service,username,password,notes)

@app.put("/users/me/editPassword")
async def user_editPassword(fernetKey: str,passId: int,service: str,username: str,password: str,notes: str,current_user: User = Depends(get_current_active_user)):
    return edit_password(current_user,passId,fernetKey,service,username,password,notes)

@app.get("/users/me/getPasswords")
async def user_getPasswords(fernetKey: str,current_user: User = Depends(get_current_active_user)):
    return get_passwords(current_user,fernetKey)

@app.delete("/users/me/delPassword")
async def user_delPassword(passId: int,current_user: User = Depends(get_current_active_user)):
    return del_password(current_user,passId)

@app.post("/users/me/newCard")
async def user_addCard(fernetKey: str,cardType: str,cardNumber: str,expiration: str,cvc: str,current_user: User = Depends(get_current_active_user)):
    return new_card(current_user,fernetKey,cardType,cardNumber,expiration,cvc)

@app.put("/users/me/editCard")
async def user_editCard(fernetKey: str,cardId: int,cardType: str,cardNumber: str,expiration: str,cvc: str,current_user: User = Depends(get_current_active_user)):
    return edit_card(current_user,cardId,fernetKey,cardType,cardNumber,expiration,cvc)

@app.get("/users/me/getCards")
async def user_getCards(fernetKey: str,current_user: User = Depends(get_current_active_user)):
    return get_cards(current_user,fernetKey)

@app.delete("/users/me/delCard")
async def user_delCard(cardId: int,current_user: User = Depends(get_current_active_user)):
    return del_card(current_user,cardId)