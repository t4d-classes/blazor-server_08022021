DROP TABLE IF EXISTS dbo.Color;
GO

CREATE TABLE dbo.Color (
  "Id" INT PRIMARY KEY CLUSTERED IDENTITY,
  "Name" NVARCHAR(MAX) NOT NULL,
  "Hexcode" NVARCHAR(MAX) NOT NULL
);
GO

INSERT INTO dbo.Color ("Name", "Hexcode")
VALUES ('red', 'ff0000');
INSERT INTO dbo.Color ("Name", "Hexcode")
VALUES ('green', '00ff00');
INSERT INTO dbo.Color ("Name", "Hexcode")
VALUES ('blue', '0000ff');
GO

DROP TABLE IF EXISTS dbo.Car;
GO

CREATE TABLE dbo.Car (
  Id INT PRIMARY KEY CLUSTERED IDENTITY,
  Make NVARCHAR(MAX) NOT NULL,
  Model NVARCHAR(MAX) NOT NULL,
  Year INT NOT NULL DEFAULT 1900,
  Color NVARCHAR(MAX) NOT NULL,
  Price MONEY NOT NULL DEFAULT 0
);
GO

INSERT INTO dbo.Car (Make, Model, Year, Color, Price)
VALUES ('Ford', 'Fusion Hybrid', 2020, 'blue', 40000);
INSERT INTO dbo.Car (Make, Model, Year, Color, Price)
VALUES ('Tesla', 'S', 2019, 'red', 120000);
GO
