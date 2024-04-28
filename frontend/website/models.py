from flask_login import UserMixin
from .config import API_ADDRESS
import requests

class User(UserMixin):
    def __init__(self, tokenandfernetkey,token=None,fernetKey=None,username=None,email=None,userid=None):
        self.id = tokenandfernetkey
        self.tokenType = 'bearer'
        self.token = token
        self.fernetKey = fernetKey
        self.username = username
        self.get_email = email
        self.userid = userid

    def getPasswords(self):
        url = f'{API_ADDRESS}/users/me/getPasswords'
        info = f'?fernetKey={self.fernetKey}'
        headers = {'accept': 'application/json','Authorization': f'{self.tokenType} {self.token}'}
        req = requests.get(url+info, headers=headers)
        passwords = req.json()
        return passwords

    def newPassword(self, service, username, password, notes=""):
        url = f'{API_ADDRESS}/users/me/newPassword'
        info = f'?fernetKey={self.fernetKey}&service={service}&username={username}&password={password}&notes={notes}'
        headers = {'accept': 'application/json','Authorization': f'{self.tokenType} {self.token}'}
        req = requests.post(url+info, headers=headers)
        response = req.json()
        return response
    
    def editPassword(self, passId ,service, username, password, notes=""):
        url = f'{API_ADDRESS}/users/me/editPassword'
        info = f'?fernetKey={self.fernetKey}&passId={passId}&service={service}&username={username}&password={password}&notes={notes}'
        headers = {'accept': 'application/json','Authorization': f'{self.tokenType} {self.token}'}
        req = requests.put(url+info, headers=headers)
        response = req.json()
        return response
    
    def delPassword(self, passId):
        url = f'{API_ADDRESS}/users/me/delPassword'
        info = f'?passId={passId}'
        headers = {'accept': 'application/json','Authorization': f'{self.tokenType} {self.token}'}
        req = requests.delete(url+info, headers=headers)
        response = req.json()
        return response

    def getCards(self):
        url = f'{API_ADDRESS}/users/me/getCards'
        info = f'?fernetKey={self.fernetKey}'
        headers = {'accept': 'application/json','Authorization': f'{self.tokenType} {self.token}'}
        req = requests.get(url+info, headers=headers)
        cards = req.json()
        return cards

    def newCard(self, cardType, cardNumber, expiration, cvc):
        url = f'{API_ADDRESS}/users/me/newCard'
        info = f'?fernetKey={self.fernetKey}&cardType={cardType}&cardNumber={cardNumber}&expiration={expiration}&cvc={cvc}'
        headers = {'accept': 'application/json','Authorization': f'{self.tokenType} {self.token}'}
        req = requests.post(url+info, headers=headers)
        response = req.json()
        return response

    def editCard(self, cardId, cardType, cardNumber, expiration, cvc):
        url = f'{API_ADDRESS}/users/me/editCard'
        info = f'?fernetKey={self.fernetKey}&cardId={cardId}&cardType={cardType}&cardNumber={cardNumber}&expiration={expiration}&cvc={cvc}'
        headers = {'accept': 'application/json','Authorization': f'{self.tokenType} {self.token}'}
        req = requests.put(url+info, headers=headers)
        response = req.json()
        return response
    
    def delCard(self, cardId):
        url = f'{API_ADDRESS}/users/me/delCard'
        info = f'?cardId={cardId}'
        headers = {'accept': 'application/json','Authorization': f'{self.tokenType} {self.token}'}
        req = requests.delete(url+info, headers=headers)
        response = req.json()
        return response