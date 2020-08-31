CREATE TABLE auto (

autoID INT PRIMARY KEY AUTO_INCREMENT,
autoBrand VARCHAR(20) NOT NULL,
autoModel VARCHAR(20) NOT NULL,
autoColor VARCHAR(20) NOT NULL,
autoShifterType VARCHAR(20) NOT NULL,
isAutoSold BIT,
autoSellDate DATE,
sellerID INT
);
ALTER TABLE auto
ADD CONSTRAINT fk_sellerID
FOREIGN KEY (sellerID) REFERENCES employees(empID);


CREATE TABLE employees (

empID INT PRIMARY KEY AUTO_INCREMENT,
empName VARCHAR(20) NOT NULL,
empSurename VARCHAR(20) NOT NULL,
jobID INT
);
ALTER TABLE employees
ADD CONSTRAINT fk_jobID
FOREIGN KEY (jobID) REFERENCES jobs(jobID);



CREATE TABLE jobs (

jobID INT PRIMARY KEY AUTO_INCREMENT,
jobName VARCHAR(20) NOT NULL,
jobDesc VARCHAR(20) NOT NULL

);


INSERT INTO auto (autoBrand, autoModel,autoColor,isAutoSold,sellerID)
VALUES
('bmw', 'x5','black',0,1),
('bmw', 'x5','red',1,1),
('bmw', 'x5','white',0,2);

INSERT INTO employees (empName, empSurename,jobID)
VALUES
('Janis', 'Berzins',1),
('Sandra', 'Kalnina',2);



INSERT INTO jobs (jobName, jobDesc)
VALUES
('Junior', 'Junior Pardevejs'),
('Senior', 'Senior Pardevejs');
