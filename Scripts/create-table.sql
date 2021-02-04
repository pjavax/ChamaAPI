

create table Students(IdStudent int not null identity primary key, [Name] varchar(100) not null, Email varchar(200) not null, DateOfBirth Date not null)

create table Courses(IdCourse int not null identity primary key, [Description] varchar(100) not null, MaxNumber int not null)

create table StudentCourses(IdStudent int, IdCourse int, DateOfStart Date)


alter table StudentCourses add constraint FK_Students(IdStudent) references Students(IdStudent)
alter table StudentCourses add constraint FK_Courses(IdCourse) references Courses(IdCourse)