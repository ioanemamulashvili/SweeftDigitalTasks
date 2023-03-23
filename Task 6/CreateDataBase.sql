Create database Task6

create table Teacher
(
	TeacherID int identity(1,1) primary key not null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(25) not null,
	Gender nvarchar(6) not null,
	[Subject] nvarchar(25) not null,
)

create table Student
(
	StudentID int identity(1,1) primary key not null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(25) not null,
	Gender nvarchar(6) not null,
	Class nvarchar(2) not null,
)

create table TeacherStudent
(
	TeacherID int not null,
	StudentID int not null,

	primary key (TeacherID, StudentID),
	foreign key (TeacherID) references Teacher(TeacherID),
	foreign key (StudentID) references Student(StudentID),
)