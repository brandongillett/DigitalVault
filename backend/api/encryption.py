from cryptography.fernet import Fernet
from .config import db_config,connectDB
from .auth import verify_password
import hashlib
import base64

dbConnection = connectDB(db_config)

def genFernetKey(password):
    password_bytes = password.encode('utf-8')
    salt = b'DigitalVault'
    salted_password = password_bytes + salt
    key = salted_password
    for _ in range(1000000):
        key = hashlib.sha256(key).digest()
    encoded_key = base64.urlsafe_b64encode(key[:32])
    return encoded_key

def encryptData(key, data):
    fernet = Fernet(key)
    for key,val in data.items():
        data[key] = fernet.encrypt(val.encode())
    return data

def decryptData(key,data):
    fernet = Fernet(key)
    decrypted = []
    for i in data:
        for elem,enc in i.items():
            if elem != 'id':
                i[elem] = fernet.decrypt(enc)
        decrypted.append(i)
    return decrypted

def new_password(user: str,fernetKey: str,service: str,username: str,password: str,notes: str):
    if not service or not username or not password:
        return {"status":False,"message":"Service name required."} if not service else {"status":False,"message":"Username required."} if not username else {"status":False,"message":"Password required."}
    try:
        if not dbConnection: global dbConnection; dbConnection = connectDB(db_config)
        db = dbConnection.get_connection()
        data = encryptData(fernetKey,{'service':service,'username':username,'password':password,'notes':notes})
        cursor = db.cursor()
        cursor.execute('INSERT INTO Passwords (userId,service,username,password,notes) VALUES (%s,%s,%s,%s,%s)',(user.id,data['service'],data['username'],data['password'],data['notes']))
        cursor.close()
        db.commit()
        return {"status":True,"message":f"Password Saved."}
    except:
        return {"status":False,"message":"An error has occured."}

def edit_password(user: str,passId,fernetKey: str,service: str,username: str,password: str,notes: str):
    if not dbConnection: global dbConnection; dbConnection = connectDB(db_config)
    db = dbConnection.get_connection()
    cursor = db.cursor()
    cursor.execute(f'Select userId FROM Passwords WHERE userId="{user.id}" AND id="{passId}"')
    userId=cursor.fetchone()
    if(userId and user.id == userId[0]):
        try:
            data = encryptData(fernetKey,{'service':service,'username':username,'password':password,'notes':notes})
            cursor.execute('UPDATE Passwords SET service="%s", username="%s", password="%s", notes="%s" WHERE userId="%s" AND id="%s"',(data['service'],data['username'],data['password'],data['notes'],user.id,passId))
            cursor.close()
            db.commit()
            return {"status":True,"message":f"Password Saved."}
        except:
            return {"status":False,"message":"An error has occured."}
    else:
        return {"status":False,"message":"Unable to retreive password."}

def get_passwords(user: str,fernetKey: str):
    if not dbConnection: global dbConnection; dbConnection = connectDB(db_config)
    db = dbConnection.get_connection()
    cursor = db.cursor()
    cursor.execute('SELECT * FROM Passwords WHERE userId="{}"'.format(user.id))
    info=cursor.fetchall()
    cursor.close()
    passwords = []
    if info:
        for i in info:
            passwords.append({'id':i[1],'service':i[2],'username':i[3],'password':i[4],'notes':i[5]})
        data = decryptData(fernetKey,passwords)
        return data

def del_password(user: str,passId):
    if not dbConnection: global dbConnection; dbConnection = connectDB(db_config)
    db = dbConnection.get_connection()
    cursor = db.cursor()
    cursor.execute(f'Select userId FROM Passwords WHERE userId="{user.id}" AND id="{passId}"')
    userId=cursor.fetchone()
    if(userId and user.id == userId[0]):
        try:
            cursor.execute(f'Delete FROM Passwords WHERE userId="{user.id}" AND id="{passId}"')
            cursor.close()
            db.commit()
            return {"status":True,"message":f"Password Deleted."}
        except:
            return {"status":False,"message":"An error has occured."}
    else:
        return {"status":False,"message":"Unable to retreive password."}

def new_card(user: str,fernetKey: str,cardType: str,cardNumber: str,expiration: str,cvc: str):
    if not cardNumber:
        return {"status":False,"message":"Card Number required."}

    if not dbConnection: global dbConnection; dbConnection = connectDB(db_config)
    db = dbConnection.get_connection()
    data = encryptData(fernetKey,{'cardType':cardType,'cardNumber':cardNumber,'expiration':expiration,'cvc':cvc})
    cursor = db.cursor()
    cursor.execute('INSERT INTO CreditCards (userId,cardType,cardNumber,expiration,cvc) VALUES (%s,%s,%s,%s,%s)',(user.id,data['cardType'],data['cardNumber'],data['expiration'],data['cvc']))
    cursor.close()
    db.commit()
    return {"status":True,"message":f"Credit Card Saved."}

def edit_card(user: str,cardId,fernetKey: str,cardType: str,cardNumber: str,expiration: str,cvc: str):
    if not dbConnection: global dbConnection; dbConnection = connectDB(db_config)
    db = dbConnection.get_connection()
    cursor = db.cursor()
    cursor.execute(f'Select userId FROM CreditCards WHERE userId="{user.id}" AND id="{cardId}"')
    userId=cursor.fetchone()
    if(userId and user.id == userId[0]):
        try:
            data = encryptData(fernetKey,{'cardType':cardType,'cardNumber':cardNumber,'expiration':expiration,'cvc':cvc})
            cursor.execute('UPDATE CreditCards SET cardType="%s", cardNumber="%s", expiration="%s", cvc="%s" WHERE userId="%s" AND id="%s"',(data['cardType'],data['cardNumber'],data['expiration'],data['cvc'],user.id,cardId))
            cursor.close()
            db.commit()
            return {"status":True,"message":f"Credit Card Saved."}
        except:
            return {"status":False,"message":"An error has occured."}
    else:
        return {"status":False,"message":"Unable to retreive card."}
    
def get_cards(user: str,fernetKey: str):
    if not dbConnection: global dbConnection; dbConnection = connectDB(db_config)
    db = dbConnection.get_connection()
    cursor = db.cursor()
    cursor.execute('SELECT * FROM CreditCards WHERE userId="{}"'.format(user.id))
    info=cursor.fetchall()
    cursor.close()
    cards = []
    if info:
        for i in info:
            cards.append({'id':i[1],'cardType':i[2],'cardNumber':i[3],'expiration':i[4],'cvc':i[5]})
        data = decryptData(fernetKey,cards)
        return data
    
def del_card(user: str,cardId):
    if not dbConnection: global dbConnection; dbConnection = connectDB(db_config)
    db = dbConnection.get_connection()
    cursor = db.cursor()
    cursor.execute(f'Select userId FROM CreditCards WHERE userId="{user.id}" AND id="{cardId}"')
    userId=cursor.fetchone()
    if(userId and user.id == userId[0]):
        try:
            cursor.execute(f'Delete FROM CreditCards WHERE userId="{user.id}" AND id="{cardId}"')
            cursor.close()
            db.commit()
            return {"status":True,"message":f"Credit Card Deleted."}
        except:
            return {"status":False,"message":"An error has occured."}
    else:
        return {"status":False,"message":"Unable to retreive card."}