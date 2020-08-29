CREATE TABLE students (

studentID INT PRIMARY KEY AUTO_INCREMENT,
firstName VARCHAR(20) NOT NULL,
lastName VARCHAR(20) NOT NULL,
course INT NOT NULL

);



INSERT INTO students (firstName, lastName, course)
VALUES
('Doctor', 'Who', 1),
('Seventh', 'ofNine', 1),
('Til`k', 'Goa`uld', 2),
('Jack', 'O`Neil', 2),
('Samantha', 'Carter', 3),
('Daniel', 'Jackson', 3);
