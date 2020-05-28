# _Relations Practice_

#### _Epicodus Project May 28, 2020_

#### By _**Jason Macie**_

## Title

_A project to reinforce the use of MVC, EF, and MySQL._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the commands dotnet restore, dotnet build, and dotnet run.

## Known Bugs

There are no known bugs at the time of this update.

## Technologies Used

* C#
* .NET Core
* MSBuild
* ASP.Net Core
* MVC
* MySQL
* Entity Framework Core
* Git and GitHub

### Specs

#### SQL Commands for DB

CREATE SCHEMA `relations_practice` ;
CREATE TABLE `relations_practice`.`non_profit` (
  `NonProfitId` INT NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(255) NULL,
  PRIMARY KEY (`NonProfitId`));
CREATE TABLE `relations_practice`.`board_member` (
  `BoardMemberId` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(255) NULL,
  `NonProfitId` INT NULL DEFAULT 0,
  PRIMARY KEY (`BoardMemberId`));

| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Non Profit DB**|
| **Create a class called NonProfit. This will be used to store a description, and BoardMember objects** |
| **Create a class called BoardMember. This will store Name, NonProfitId** |

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Jason Macie_**