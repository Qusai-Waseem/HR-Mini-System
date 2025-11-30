CREATE TABLE Department (
    depId INT IDENTITY(1,1) PRIMARY KEY,
    depname NVARCHAR(100) NOT NULL
);
CREATE TABLE Employee (
    empId INT IDENTITY(1,1) PRIMARY KEY,
    empname NVARCHAR(100) NOT NULL,
    empgn NVARCHAR(10) NOT NULL,
    empdep INT NOT NULL,
    empdds DATE NOT NULL,
    empdate DATE NOT NULL,
    empsal INT NOT NULL,
    CONSTRAINT FK_Employee_Department FOREIGN KEY (empdep) REFERENCES Department(depId)
);
CREATE TABLE Salaries (
    scode INT IDENTITY(1,1) PRIMARY KEY,
    employee INT NOT NULL,
    atten INT NOT NULL,
    period NVARCHAR(50) NOT NULL,
    amount INT NOT NULL,
    paydate DATE NOT NULL,
    CONSTRAINT FK_Salaries_Employee FOREIGN KEY (employee) REFERENCES Employee(empId)
);