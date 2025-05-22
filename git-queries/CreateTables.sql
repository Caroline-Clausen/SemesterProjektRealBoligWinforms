CREATE TABLE administrator (
	administratorID INT PRIMARY KEY IDENTITY(1,1),
	brugernavn NVARCHAR(50),
	password NVARCHAR(50),
	navn NVARCHAR(50),
	mail NVARCHAR(50),
	telefonnummer INT
);

CREATE TABLE ejendomsmæglere (
	ejendomsmæglerID INT PRIMARY KEY IDENTITY(1,1),
	navn NVARCHAR(50),
	telefonnummer INT,
	mail NVARCHAR(50),
	brugernavn NVARCHAR(50),
	password NVARCHAR(50)
);

CREATE TABLE købere (
	køberID INT PRIMARY KEY IDENTITY(1,1),
	navn NVARCHAR(50),
	telefonnummer INT,
	mail NVARCHAR(50)
);

CREATE TABLE sælgere (
	sælgerID INT PRIMARY KEY IDENTITY(1,1),
	navn NVARCHAR(50),
	telefonnummer INT,
	mail NVARCHAR(50)
);

CREATE TABLE boliger (
	boligID INT PRIMARY KEY IDENTITY(1,1),
	adresse NVARCHAR(50),
	kvadratmeter INT,
	type NVARCHAR(50),
	pris INT,
	afstandTilIndkøb INT,
	status VARCHAR(50),
	sælgerID INT FOREIGN KEY REFERENCES sælgere(sælgerID),
	område NVARCHAR(50)
);

CREATE TABLE salg (
	salgsID INT PRIMARY KEY IDENTITY(1,1),
	boligID INT FOREIGN KEY REFERENCES boliger(boligID),
	pris INT,
	køberID INT FOREIGN KEY REFERENCES købere(køberID),
	salgstidspunkt DATETIME,
	ejendomsmæglerID INT FOREIGN KEY REFERENCES ejendomsmæglere(ejendomsmæglerID),
	sælgerID INT FOREIGN KEY REFERENCES sælgere(sælgerID)
);

INSERT INTO sælgere (navn, telefonnummer, mail)
VALUES
    ('Mathias Kiær', 12345678, 'mathias.kiaer@example.com'),
    ('Lars Jensen', 23456789, 'lars.jensen@example.com'),
    ('Camilla Hansen', 34567890, 'camilla.hansen@example.com'),
    ('Peter Nielsen', 45678901, 'peter.nielsen@example.com'),
    ('Sofie Pedersen', 56789012, 'sofie.pedersen@example.com');

INSERT INTO boliger (adresse, kvadratmeter, type, pris, afstandTilIndkøb, status, sælgerID, område)
VALUES
    ('123 Hovedgade', 150, 'Hus', 2500000, 500, 'til salg', 1, 'København'),
    ('456 Søndergade', 200, 'Lejlighed', 3000000, 300, 'til salg', 1, 'Aarhus'),
    ('789 Nordvej', 180, 'Villa', 4000000, 700, 'til salg', 1, 'Odense'),
    ('321 Østergade', 120, 'Ejerlejlighed', 2000000, 200, 'til salg', 1, 'Aalborg'),
    ('654 Vestervej', 220, 'Rækkehus', 3500000, 400, 'til salg', 1, 'Esbjerg');

INSERT INTO købere (navn, telefonnummer, mail)
VALUES
    ('Mathias Kiær', 12345678, 'mathias.kiaer@example.com'),
    ('Lars Jensen', 23456789, 'lars.jensen@example.com'),
    ('Camilla Hansen', 34567890, 'camilla.hansen@example.com'),
    ('Peter Nielsen', 45678901, 'peter.nielsen@example.com'),
    ('Sofie Pedersen', 56789012, 'sofie.pedersen@example.com');

INSERT INTO administrator (brugernavn, password, navn, mail, telefonnummer)
VALUES
	('admin', 'admin1', 'Henrik', 'henri@test.dk', 12345678),
	('da', 'da1', 'Nicoline', 'nico@test.dk', 87654321);

INSERT INTO ejendomsmæglere (navn, telefonnummer, mail, brugernavn, password)
VALUES
	('Jens', 12345678, 'jens@test.dk', 'jens', 1234),
	('Birgitte', 87654321, 'birg@test.dk', 'birgitte', 5678);
