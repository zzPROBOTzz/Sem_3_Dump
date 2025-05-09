CREATE DATABASE StudentDB;

USE StudentDB;

CREATE TABLE Students (
    StudentID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50),
    Age INT,
    Grade NVARCHAR(10)
);


INSERT INTO Students (Name, Age, Grade) 
VALUES ('Alice', 12, '6th Grade'),
       ('Bob', 14, '8th Grade');
