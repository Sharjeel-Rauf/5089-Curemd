
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
	Select*from Students
	where CourseID IS NULL;
END;
GO
--part 1 	List the names of students who are not enrolled in any course.
CREATE PROCEDURE Notenrolled
AS
BEGIN
	Select*from Students
	where CourseID IS NULL;
END;
GO
--part 2	Find the most popular course (the course with the most students enrolled).
CREATE PROCEDURE Most_popular
AS
BEGIN
	SELECT TOP 1 Courses.CourseName, COUNT(*) AS EnrolledStudents
FROM Courses
JOIN Students ON Courses.CourseID = Students.CourseID
GROUP BY Courses.CourseName
ORDER BY EnrolledStudents DESC;

END;
GO
--	3. List the students who are older than the average age of students.
CREATE PROCEDURE Older_than_average
AS
BEGIN

SELECT FirstName,LastName FROM Students WHERE Age > (SELECT AVG(Age) FROM Students);

END;
GO
--4. 	Find the total number of students and average age for each course.
CREATE PROCEDURE total_average
AS
BEGIN

SELECT Courses.CourseName, COUNT(*) AS TotalStudents, AVG(Age) AS AverageAge
FROM Courses
LEFT JOIN Students ON Courses.CourseID = Students.CourseID
GROUP BY Courses.CourseName;

END;
GO

--5. 	List the courses that have no students enrolled in them

CREATE PROCEDURE no_student_course
AS
BEGIN

select TOP 1 Courses.CourseName
from Courses LEFT JOIN Students ON Courses.CourseID = Students.CourseID
GROUP BY CourseName
ORDER BY CourseName DESC

END;
GO
--6.	List students who share courses with a specific student (choose one from your records
CREATE PROCEDURE share_course
AS
BEGIN

select * from Students
where CourseID=(SELECT CourseID FROM Students where StudentID=1006)

END;
GO

--7. 	For each course, list the youngest and oldest student.
CREATE PROCEDURE young_old_student
AS
BEGIN

SELECT CourseName, MIN(Age) AS YoungestAge, MAX(Age) AS OldestAge
FROM Courses
JOIN Students ON Courses.CourseID = Students.CourseID
GROUP BY CourseName;

END;
GO
