

3) Parādīt informāciju par pārdotajiem dzīvniekiem ar select/join- dzīvnieka vārdu, kas tas ir par dzīvnieku, saimnieku un pārdēveju.
4) Parādīt informāciju par dzīvniekiem, kas vēl ir veikalā. 


SELECT * FROM dzivnieki INNER JOIN klienti
ON dzivnieki.animalID = klienti.ClientID







INSERT INTO Klienti (clientName, clientSurename, clientPhone)
VALUES
('Janis', 'Berzins', '555-3423'),
('Iveta', 'Kalnina', '555-5577'),
('Agnese', 'Putnina', '555-1133'),
('Mihails', 'Zverevs', '555-8888');

INSERT INTO Darbinieki (empName, empSurename, empPhone)
VALUES
('Viktorija', 'Morozova', '777-3423'),
('Juris', 'Bunkurs', '777-5577'),
('Inga', 'Ivleva', '777-1133'),
('Ivans', 'Ivanovs', '777-8888');

INSERT INTO DzivniekaTips (typeName, typeDesc)
VALUES
('Cat', 'Little puffy demon'),
('Dog', 'Big kind animal'),
('Crocodile', 'Big teeth long tail'),
('Dino', 'Dead many years ago');


INSERT INTO Dzivnieki (typeID, animalName, isSold, animalMasterID, animalSellerID )
VALUES
(5, 'Flutterhy',0,null,null),
(6, 'Applejack',1,2,2),
(7, 'RainbowDash',0,null,null),
(8, 'Spike',0,null,null);



CREATE TABLE Klienti (
ClientID INT PRIMARY KEY AUTO_INCREMENT,
clientName VARCHAR(20) NOT NULL,
clientSurename VARCHAR(20) NOT NULL,
clientPhone VARCHAR(20) NOT NULL
);

CREATE TABLE Darbinieki (
empID INT PRIMARY KEY AUTO_INCREMENT,
empName VARCHAR(20) NOT NULL,
empSurename VARCHAR(20) NOT NULL,
empPhone VARCHAR(20) NOT NULL
);

CREATE TABLE DzivniekaTips (
typeID INT PRIMARY KEY AUTO_INCREMENT,
typeName VARCHAR(20) NOT NULL,
typeDesc VARCHAR(20) NOT NULL
);

CREATE TABLE Dzivnieki (
animalID INT PRIMARY KEY AUTO_INCREMENT,
typeID INT,
animalName VARCHAR(20) NOT NULL,
animalMasterID INT,
animalSellerID INT,
isSold INT
);
ALTER TABLE Dzivnieki
ADD CONSTRAINT fk_typeID
FOREIGN KEY (typeID) REFERENCES DzivniekaTips(typeID);

ALTER TABLE Dzivnieki
ADD CONSTRAINT fk_animalMaster
FOREIGN KEY (animalMasterID) REFERENCES Klienti(ClientID);

ALTER TABLE Dzivnieki
ADD CONSTRAINT fk_animalSellerID
FOREIGN KEY (animalSellerID) REFERENCES Darbinieki(empID);
