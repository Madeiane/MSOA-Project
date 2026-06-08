USE [master]
IF DB_ID(N'BankDB') IS NOT NULL
DROP DATABASE [BankDB]
GO
CREATE DATABASE [BankDB]
GO
USE [BankDB]
GO
IF OBJECT_ID(N'dbo.Transactions', N'U') IS NOT NULL
DROP TABLE dbo.Transactions
IF OBJECT_ID(N'dbo.Accounts', N'U') IS NOT NULL
DROP TABLE dbo.Accounts
IF OBJECT_ID(N'dbo.Requests', N'U') IS NOT NULL
DROP TABLE dbo.Requests
IF OBJECT_ID(N'dbo.Users', N'U') IS NOT NULL
DROP TABLE dbo.Users
GO
CREATE TABLE dbo.Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) NOT NULL,
    CONSTRAINT UQ_Users_Username UNIQUE (Username),
    CONSTRAINT CK_Users_Role CHECK (Role IN ('Admin','Employee','Customer'))
)
GO
CREATE TABLE dbo.Accounts (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    AccountNumber NVARCHAR(34) NOT NULL,
    Balance DECIMAL(18,2) NOT NULL DEFAULT(0.00),
    AccountType NVARCHAR(50) NOT NULL,
    CONSTRAINT UQ_Accounts_AccountNumber UNIQUE (AccountNumber),
    CONSTRAINT CK_Accounts_AccountType CHECK (AccountType IN ('Savings','Current')),
    CONSTRAINT FK_Accounts_Users FOREIGN KEY (UserId) REFERENCES dbo.Users(Id) ON DELETE CASCADE ON UPDATE NO ACTION
)
GO
CREATE TABLE dbo.Transactions (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    SourceAccountId INT NOT NULL,
    DestinationAccountNumber NVARCHAR(34) NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    Description NVARCHAR(500) NULL,
    Date DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Status NVARCHAR(50) NOT NULL,
    CONSTRAINT CK_Transactions_Status CHECK (Status IN ('Completed','Pending','Declined')),
    CONSTRAINT FK_Transactions_Accounts FOREIGN KEY (SourceAccountId) REFERENCES dbo.Accounts(Id) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO
CREATE TABLE dbo.Requests (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(200) NOT NULL,
    RequestType NVARCHAR(100) NOT NULL,
    Details NVARCHAR(MAX) NULL,
    Status NVARCHAR(50) NOT NULL,
    CONSTRAINT CK_Requests_RequestType CHECK (RequestType IN ('Credit Loan','New Credit Card','Account Opening')),
    CONSTRAINT CK_Requests_Status CHECK (Status IN ('Pending','Approved','Rejected'))
)
GO
INSERT INTO dbo.Users (Username, Password, Role) VALUES
('diana','123','Customer'),
('staff','123','Employee'),
('admin','123','Admin')
GO
INSERT INTO dbo.Accounts (UserId, AccountNumber, Balance, AccountType) VALUES
(1,'RO49AAAA1B31007593840001',1000.00,'Savings'),
(1,'RO49AAAA1B31007593840002',2500.50,'Current'),
(2,'RO49AAAA1B31007593840003',5000.00,'Current')
GO
INSERT INTO dbo.Transactions (SourceAccountId, DestinationAccountNumber, Amount, Description, Date, Status) VALUES
(1,'RO49AAAA1B31007593840002',150.00,'Transfer to own account',SYSUTCDATETIME(),'Completed'),
(2,'RO49BBBB1B31007593840004',200.00,'Payment to merchant',SYSUTCDATETIME(),'Pending'),
(3,'RO49CCCC1B31007593840005',300.00,'Salary transfer',SYSUTCDATETIME(),'Completed')
GO
INSERT INTO dbo.Requests (CustomerName, RequestType, Details, Status) VALUES
('diana','Account Opening','Request to open a new savings account','Pending'),
('diana','Credit Loan','Apply for personal loan of 5000','Pending'),
('staff','New Credit Card','Request a new credit card for business expenses','Approved')
GO
USE [master]
GO
IF DB_ID(N'BankDB') IS NOT NULL
DROP DATABASE [BankDB]
GO
CREATE DATABASE [BankDB]
GO
USE [BankDB]
GO
IF OBJECT_ID(N'dbo.Transactions', N'U') IS NOT NULL
DROP TABLE dbo.Transactions
IF OBJECT_ID(N'dbo.Accounts', N'U') IS NOT NULL
DROP TABLE dbo.Accounts
IF OBJECT_ID(N'dbo.Requests', N'U') IS NOT NULL
DROP TABLE dbo.Requests
IF OBJECT_ID(N'dbo.Users', N'U') IS NOT NULL
DROP TABLE dbo.Users
GO
CREATE TABLE dbo.Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) NOT NULL,
    CONSTRAINT UQ_Users_Username UNIQUE (Username),
    CONSTRAINT CK_Users_Role CHECK (Role IN ('Admin','Employee','Customer'))
)
GO
CREATE TABLE dbo.Accounts (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    AccountNumber NVARCHAR(34) NOT NULL,
    Balance DECIMAL(18,2) NOT NULL DEFAULT(0.00),
    AccountType NVARCHAR(50) NOT NULL,
    CONSTRAINT UQ_Accounts_AccountNumber UNIQUE (AccountNumber),
    CONSTRAINT CK_Accounts_AccountType CHECK (AccountType IN ('Savings','Current')),
    CONSTRAINT FK_Accounts_Users FOREIGN KEY (UserId) REFERENCES dbo.Users(Id) ON DELETE CASCADE ON UPDATE NO ACTION
)
GO
CREATE TABLE dbo.Transactions (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    SourceAccountId INT NOT NULL,
    DestinationAccountNumber NVARCHAR(34) NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    Description NVARCHAR(500) NULL,
    Date DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Status NVARCHAR(50) NOT NULL,
    CONSTRAINT CK_Transactions_Status CHECK (Status IN ('Completed','Pending','Declined')),
    CONSTRAINT FK_Transactions_Accounts FOREIGN KEY (SourceAccountId) REFERENCES dbo.Accounts(Id) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO
CREATE TABLE dbo.Requests (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(200) NOT NULL,
    RequestType NVARCHAR(100) NOT NULL,
    Details NVARCHAR(MAX) NULL,
    Status NVARCHAR(50) NOT NULL,
    CONSTRAINT CK_Requests_RequestType CHECK (RequestType IN ('Credit Loan','New Credit Card','Account Opening')),
    CONSTRAINT CK_Requests_Status CHECK (Status IN ('Pending','Approved','Rejected'))
)
GO
INSERT INTO dbo.Users (Username, Password, Role) VALUES
('diana','123','Customer'),
('staff','123','Employee'),
('admin','123','Admin')
GO
INSERT INTO dbo.Accounts (UserId, AccountNumber, Balance, AccountType) VALUES
(1,'RO49AAAA1B31007593840001',1000.00,'Savings'),
(1,'RO49AAAA1B31007593840002',2500.50,'Current'),
(2,'RO49AAAA1B31007593840003',5000.00,'Current')
GO
INSERT INTO dbo.Transactions (SourceAccountId, DestinationAccountNumber, Amount, Description, Date, Status) VALUES
(1,'RO49AAAA1B31007593840002',150.00,'Transfer to own account',SYSUTCDATETIME(),'Completed'),
(2,'RO49BBBB1B31007593840004',200.00,'Payment to merchant',SYSUTCDATETIME(),'Pending'),
(3,'RO49CCCC1B31007593840005',300.00,'Salary transfer',SYSUTCDATETIME(),'Completed')
GO
INSERT INTO dbo.Requests (CustomerName, RequestType, Details, Status) VALUES
('diana','Account Opening','Request to open a new savings account','Pending'),
('diana','Credit Loan','Apply for personal loan of 5000','Pending'),
('staff','New Credit Card','Request a new credit card for business expenses','Approved')
GO