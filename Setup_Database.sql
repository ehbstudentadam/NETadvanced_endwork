﻿-- Disable constraints for all tables in the database:
EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'


DROP TABLE IF EXISTS Drinks;
DROP TABLE IF EXISTS Members;
DROP TABLE IF EXISTS Orders;

CREATE TABLE Drinks (
	Id INT NOT NULL IDENTITY,
	DrinkType NVARCHAR(50) NOT NULL,
	Price DECIMAL(10, 2) NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Members (
	Id INT NOT NULL IDENTITY,
	Firstname NVARCHAR(50) NOT NULL,
	Lastname NVARCHAR(50) NOT NULL,
	Address NVARCHAR(250) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Wallet DECIMAL(10,2) NOT NULL,
	IsOwner NVARCHAR(20) NOT NULL,
	CreatedDate NVARCHAR(100) NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE Orders (
	Id INT NOT NULL IDENTITY,
	CreatedDate NVARCHAR(100) NOT NULL,
	Member NVARCHAR(250) NOT NULL,
	MemberID INT NOT NULL,
	Drinks NVARCHAR(500) NOT NULL,
	PriceTotal DECIMAL(10,2) NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (MemberID) REFERENCES Members(Id)
);

-- Re-enable constraints for all tables in the database:
EXEC sp_msforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL'
---------------------------------------------------------