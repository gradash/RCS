
2) Datubāzei jāglabā sekojoša informācija- Mašīnas, kas ir uz vietas (brands, modelis, krāsa, pārnesumkārba), jābūt informācijai, par to vai mašīna ir pārdota, ja jā-datumam, kad pārdeva. 
3) Darbinieku saraksts un, pie katras mašīnas jābūt informācijai par to, kurš darbinieks mašīnu pārdeva. (vārds, uzvārds, amats), par amatu ir jābūt aprakstam.
amati var būt- junior pārdevējs, speciālists un senior pārdevējs .








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
