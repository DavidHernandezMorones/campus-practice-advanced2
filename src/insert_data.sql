INSERT INTO Students (Name, Birthday, Height, Weight)
VALUES ('pedro', '1999/10/13', 170.3, 70.5),
       ('carlos', '1998/05/28', 178.88, 78)
GO

INSERT
INTO Courses (Name)
VALUES ('Math'),
       ('Data Structures'),
       ('Protocols and networking')
GO

INSERT INTO CourseStudent (CoursesId, StudentsId)
VALUES (1, 1),
       (1, 2),
       (2, 2),
       (3, 2),
       (3, 1)
GO
