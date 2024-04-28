create database DigitalVault;
use DigitalVault;

CREATE TABLE if not exists Users (id INT PRIMARY KEY AUTO_INCREMENT,username VARCHAR(100) UNIQUE,email VARCHAR(150) UNIQUE,disabled TINYINT(1),password VARCHAR(150));
CREATE TABLE if not exists Passwords (userId INT,FOREIGN KEY(userId) REFERENCES Users(id),id INT PRIMARY KEY AUTO_INCREMENT,service VARCHAR(1000),username VARCHAR(150),password VARCHAR(150),notes VARCHAR(3000));
CREATE TABLE if not exists CreditCards (userId INT,FOREIGN KEY(userId) REFERENCES Users(id),id INT PRIMARY KEY AUTO_INCREMENT,cardType VARCHAR(150),cardNumber VARCHAR(150),expiration VARCHAR(150),cvc VARCHAR(150));
