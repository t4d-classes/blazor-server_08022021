--USE master;

--DROP DATABASE IF EXISTS "ToolsApp";
--GO

--CREATE DATABASE "ToolsApp";
--GO

USE "DemoApp";
GO

DROP TABLE IF EXISTS dbo.Color;
GO

CREATE TABLE dbo.Color (
  "Id" BIGINT PRIMARY KEY CLUSTERED IDENTITY,
  "UserId" NVARCHAR(450),
  "Name" NVARCHAR(MAX) NOT NULL,
  "Hexcode" NVARCHAR(MAX) NOT NULL,
  CONSTRAINT FK_Color_AspNetUsers FOREIGN KEY (UserId) REFERENCES AspNetUsers(Id),
);
GO

INSERT INTO dbo.Color ("UserId", "Name", "Hexcode")
VALUES ('fcb5e95d-496a-46fd-97a9-70677be15df6', 'red', 'ff0000');
INSERT INTO dbo.Color ("UserId", "Name", "Hexcode")
VALUES ('fcb5e95d-496a-46fd-97a9-70677be15df6', 'green', '00ff00');
INSERT INTO dbo.Color ("UserId", "Name", "Hexcode")
VALUES ('fcb5e95d-496a-46fd-97a9-70677be15df6', 'blue', '0000ff');
INSERT INTO dbo.Color ("UserId", "Name", "Hexcode")
VALUES ('31d64f1d-23c2-4031-a919-5ff498fac9b1', 'purple', 'ff00ff');
GO

DROP TABLE IF EXISTS dbo.Car;
GO

CREATE TABLE dbo.Car (
  Id BIGINT PRIMARY KEY CLUSTERED IDENTITY,
  "UserId" NVARCHAR(450),
  Make NVARCHAR(MAX) NOT NULL,
  Model NVARCHAR(MAX) NOT NULL,
  Year SMALLINT NOT NULL DEFAULT 1900,
  Color NVARCHAR(MAX) NOT NULL,
  Price MONEY NOT NULL DEFAULT 0,
  CONSTRAINT FK_Car_AspNetUsers FOREIGN KEY (UserId) REFERENCES AspNetUsers(Id),
);
GO

INSERT INTO dbo.Car (UserId, Make, Model, Year, Color, Price)
VALUES ('fcb5e95d-496a-46fd-97a9-70677be15df6', 'Ford', 'Fusion Hybrid', 2020, 'blue', 40000);
INSERT INTO dbo.Car (UserId, Make, Model, Year, Color, Price)
VALUES ('fcb5e95d-496a-46fd-97a9-70677be15df6', 'Tesla', 'S', 2019, 'red', 120000);
GO
