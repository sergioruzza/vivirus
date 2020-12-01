
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Assignature
DROP TABLE IF EXISTS Assignature;

CREATE TABLE Assignature (
    IDAssignature INTEGER PRIMARY KEY AUTOINCREMENT,
    IDTeacher     INTEGER REFERENCES Teacher (IDTeacher),
    IDSubject     INTEGER REFERENCES Subject (IDSubject),
    IDGroup       INTEGER REFERENCES GroupAtSchool (IDGroup) 
);


-- Table: Group
DROP TABLE IF EXISTS GroupAtSchool;

CREATE TABLE GroupAtSchool (
    IDGroup      INTEGER       PRIMARY KEY AUTOINCREMENT,
    IDPeriodType INTEGER REFERENCES PeriodType (IDPeriodType),
    Name         VARCHAR (10),
    StartDate    DATE,
    CloseDate    DATE
);


-- Table: PeriodType
DROP TABLE IF EXISTS PeriodType;

CREATE TABLE PeriodType (
    IDPeriodType INTEGER       PRIMARY KEY AUTOINCREMENT,
    Name         VARCHAR (100),
    Months       INT
);


-- Table: Subject
DROP TABLE IF EXISTS Subject;

CREATE TABLE Subject (
    IDSubject        INTEGER       PRIMARY KEY AUTOINCREMENT,
    Name             VARCHAR (100),
    TheoreticalHours INT (10),
    PracticalHours   INT (10) 
);


-- Table: Teacher
DROP TABLE IF EXISTS Teacher;

CREATE TABLE Teacher (
    IDTeacher     INTEGER       PRIMARY KEY AUTOINCREMENT,
    IDTeacherType INTEGER           REFERENCES TeacherType (IDTeacherType),
    FirstName     VARCHAR (100),
    MiddleName    VARCHAR (100),
    FathersLastName  VARCHAR (100),
    MothersLastName VARCHAR (100),
    DateOfBirth   DATE,
    RFC           VARCHAR (100),
    CURP          VARCHAR (100),
    PayCheckNumber INT (50),
    Password      VARCHAR (100) 
);


-- Table: TeacherType
DROP TABLE IF EXISTS TeacherType;

CREATE TABLE TeacherType (
    IDTeacherType INTEGER       PRIMARY KEY AUTOINCREMENT,
    Name          VARCHAR (100),
    MinWorkingHours      INT,
    MaxWorkingHours      INT
);


-- Table: TeacherSubject
DROP TABLE IF EXISTS TeacherSubject;

CREATE TABLE TeacherSubject (
    IDTeacherSubject INTEGER PRIMARY KEY AUTOINCREMENT,
    IDTeacher        INTEGER REFERENCES Teacher (IDTeacher),
    IDSubject        INTEGER REFERENCES Subject (IDSubject) 
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;  