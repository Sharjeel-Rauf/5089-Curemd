
--Task 1: creating database completed

--Task 2:
-- creating courses table
 create table Courses(
  CourseID int PRIMARY KEY,
  CourseName varchar(50)
  );
-- creating students table
create table Students (
  StudentID int PRIMARY KEY,
  FirstName varchar(50),
  LastName varchar(50),
  Age int,
  CourseID int references Courses(CourseID) 
  );
-- printing the created table
 select * from Students;
 --Task 3:
 -- inserting records in courses table 
 insert into Courses (CourseID,CourseName) values 
		(1, 'Data structures'),
		(2, 'Object oriented programming'),
		(3, 'Microprocessor systems'),
		(4, 'fundamentals of computing'),
		(5, 'introduction to computing');
-- printing the courses table
select * from Courses;
-- inserting records in students table
 insert into Students (StudentID,FirstName,LastName,Age,CourseID) values 
		(1001, 'Ali','Ahmed',18,1),
		(1002, 'Maria','Sultan',19,4),
		(1003, 'Zia','Rahman',21,5),
		(1004, 'Anum','Batool',19,4),
		(1005, 'Shaheen','Nawaz',18,NULL),
		(1006, 'Taha','Nazeer',23,4),
		(1007, 'Maira','Ali',19,4),
		(1008, 'Muhammad','Abuzar',17,NULL),
		(1009, 'Raiqa','Tanveer',22,3),
		(1010, 'Hina','Yasir',18,5);
-- printing the students table
select * from Students;

CREATE PROCEDURE GetAllStudents
AS
BEGIN
    SELECT * FROM Students;
END;
GO
Select *from Students;
--Adding students
CREATE PROCEDURE StudentsAdd
    @StudentID INT,
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
    @Age INT,
    @CourseID INT
AS
BEGIN
    INSERT INTO Students (StudentID, FirstName, LastName, Age, CourseID)
    VALUES (@StudentID, @FirstName, @LastName,@Age,@CourseID);
END;
GO

EXEC StudentsAdd 1011,'Sharjeel','Rauf',21,3

Select *from Students;
--updating student age
CREATE PROCEDURE UpdateStudentAge
    @StudentID INT,
    @NewAge INT
AS
BEGIN
    UPDATE Students
    SET Age = @NewAge
    WHERE StudentID = @StudentID;
END;
GO

EXEC UpdateStudentAge 1011, 26
Select *from Students;

--Deleting student
CREATE PROCEDURE DeleteStudent
    @StudentID INT
AS
BEGIN
    DELETE FROM Students
    WHERE StudentID = @StudentID;
END;
GO

EXEC DeleteStudent 1008
Select *from Students;
--getting student list



CREATE PROCEDURE Notenrolled
AS
BEGIN
 Select*from Students;
 WHERE COURSEID IS NULL;
END;
GO