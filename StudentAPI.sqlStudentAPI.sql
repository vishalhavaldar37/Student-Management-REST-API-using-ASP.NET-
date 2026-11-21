CREATE DATABASE StudentAPI;
GO
USE StudentAPI;
GO

CREATE TABLE Students (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Course VARCHAR(100) NOT NULL
);
GO

INSERT INTO Students (Name, Email, Course) VALUES
('Chithrashree', 'chit@gmail.com', 'CSE'),
('Lohitha Anushka', 'anu@gmail.com', 'CSE');
GO

SELECT * FROM Students;
