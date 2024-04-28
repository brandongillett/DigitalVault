import mysql.connector
#FastAPI Config
TITLE = "DigitalVault"
DESCRIPTION = "DigitalVault API"
VERSION = "0.0.1"
DOCS = "/api" # or "/api" or None
#JWT Config
SECRET_KEY = "DigitalVault123"
ALGORITHM = "HS256"
ACCESS_TOKEN_EXPIRE_MINUTES = 30
#Database Config - host is mariadb - Password is DigitalVault123
db_config = {
        'user': 'root',
        'password': 'DigitalVault123',
        'host': 'mariadb',
        'port': '3306',
        'database': 'DigitalVault'
    }

db = mysql.connector.connect(**db_config)

# def createTables():
#      cursor = db.cursor()
#      cursor.execute('CREATE TABLE if not exists Users (id INT PRIMARY KEY AUTO_INCREMENT,username VARCHAR(100) UNIQUE,email VARCHAR(150) UNIQUE,disabled TINYINT(1),password VARCHAR(150));')
#      cursor.execute('CREATE TABLE if not exists Passwords (userId INT,FOREIGN KEY(userId) REFERENCES Users(id),id INT PRIMARY KEY AUTO_INCREMENT,service VARCHAR(1000),username VARCHAR(150),password VARCHAR(150),notes VARCHAR(3000));')
#      cursor.execute('CREATE TABLE if not exists CreditCards (userId INT,FOREIGN KEY(userId) REFERENCES Users(id),id INT PRIMARY KEY AUTO_INCREMENT,cardType VARCHAR(150),cardNumber VARCHAR(150),expiration VARCHAR(150),cvc VARCHAR(150));')
#      cursor.close()