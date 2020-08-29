CREATE TABLE faculties (

facultyID INT PRIMARY KEY AUTO_INCREMENT,
facultyName VARCHAR(20) NOT NULL,
facultyDesc VARCHAR(20) NOT NULL


);

INSERT INTO faculties (facultyName, facultyDesc)
VALUES
('ExcavatorDriver', 'Who drives excavator'),
('RocketLauncher', 'Who launch rockets');


ALTER TABLE employees
ADD COLUMN facultyID int;

ALTER TABLE employees
ADD CONSTRAINT fk_team_id
FOREIGN KEY (facultyID) REFERENCES faculties(facultyID);

UPDATE employees 
SET facultyID = 1
WHERE employeeId = 1;

UPDATE employees 
SET facultyID = 2
WHERE employeeId = 2;

UPDATE employees 
SET facultyID = 2
WHERE employeeId = 3;


SELECT employees.firstName, employees.lastName, faculties.facultyName
FROM employees, faculties
WHERE faculties.facultyID = employees.facultyID AND employees.facultyID = 2;

SELECT employees.firstName, employees.lastName, faculties.facultyName, faculties.facultyDesc
FROM employees, faculties
WHERE faculties.facultyID = employees.facultyID
