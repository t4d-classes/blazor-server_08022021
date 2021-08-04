# Welcome to the Blazor Server with .NET 5 Class

![Accelebrate Logo](images/accelebrate-logo.png "Accelebrate Logo")

Most of Accelebrate's courses are taught privately online or in-person for teams of 3 or more, and can be customized to your group’s goals. To receive a customized proposal and price quote, please visit [https://www.accelebrate.com/contact/](https://www.accelebrate.com/contact/) or email [sales@accelebrate.com](sales@accelebrate.com). In addition, we offer live, online open enrollment training for individuals.

## Class Information Page

[https://www.t4d.io/accelebrate-blazor-server-with-net-5-training-08022021](https://www.t4d.io/accelebrate-blazor-server-with-net-5-training-08022021)

## Database SQL

The following SQL will be used to initialize the database for the database portion of the class.

```sql
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
```

## Other Resources

The instructor will distribute additional private links during class for accessing other resources...

All code in this repository is distributed under the [MIT license](license.txt).

<br><br>
All course content and teaching is provided by: [T4D.IO](https://www.t4d.io)