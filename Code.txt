
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
		(1002, 'Maria','Sultan',19,2),
		(1003, 'Zia','Rahman',17,3),
		(1004, 'Anum','Batool',19,4),
		(1005, 'Shaheen','Nawaz',18,5),
		(1006, 'Taha','Nazeer',18,4),
		(1007, 'Maira','Ali',19,1),
		(1008, 'Muhammad','Abuzar',17,5),
		(1009, 'Raiqa','Tanveer',19,3),
		(1010, 'Hina','Yasir',18,2);
-- printing the students table
select * from Students;

--Task 4
-- udpdating or changing data in the table
update Students
set Age=15
where StudentID = 1001;

update Students
set Age=21
where StudentID = 1008;

update Students
set Age=22
where StudentID = 1010;

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
