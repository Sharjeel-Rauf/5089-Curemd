
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

--Task 4
-- udpdating or changing data in the table
update Students
set Age=15
where StudentID = 1001;

-- printing the table
select * from Students;

--Deleting data from the table
delete from Students where StudentID=1001;
--printing the table
select * from Students;
--Task 5
-- query to list the students whose age is greater than 20
select FirstName,LastName from Students where Age > 20;
-- query to list all students enrolled in a specific course, along with the course name.
select FirstName,LastName from Students where CourseID IN
		(select CourseID from Courses where CourseName='introduction to computing');

-- Task 6
-- Using the COUNT function to find the total number of students.
select COUNT(StudentID) from Students;

-- Using the AVG function to find the average age of students.
select AVG(Age) from Students;

--Task 7

--part 1
select FirstName,LastName from Students where CourseID is NULL;

--part 2

SELECT TOP 1 Courses.CourseName, COUNT(*) AS EnrolledStudents
FROM Courses
JOIN Students ON Courses.CourseID = Students.CourseID
GROUP BY Courses.CourseName
ORDER BY EnrolledStudents DESC;

--part 3
SELECT FirstName,LastName FROM Students WHERE Age > (SELECT AVG(Age) FROM Students);

--part 4
SELECT Courses.CourseName, COUNT(*) AS TotalStudents, AVG(Age) AS AverageAge
FROM Courses
LEFT JOIN Students ON Courses.CourseID = Students.CourseID
GROUP BY Courses.CourseName;

--part 5
SELECT *
FROM Courses
WHERE CourseID IS NULL OR CourseID NOT IN (SELECT DISTINCT CourseID FROM Students);

--part 6
SELECT s1.FirstName, s1.LastName, s2.FirstName AS SharedFirstName, s2.LastName AS SharedLastName
FROM Students s1
JOIN Students s2 ON s1.CourseID = s2.CourseID AND s1.StudentID <> s2.StudentID
WHERE s1.StudentID = 1;
--part 7
SELECT CourseName, MIN(Age) AS YoungestAge, MAX(Age) AS OldestAge
FROM Courses
JOIN Students ON Courses.CourseID = Students.CourseID
GROUP BY CourseName;