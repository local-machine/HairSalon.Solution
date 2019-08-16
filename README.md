# Project

### By Jessica Munoz

#### _A web application to record hair stylists and their respective clients. - August 9nd, 2019_

---

## Description

Simple web application used to record the hair stylists and respective clients of Eau Claire's Salon.

## Technologies Used

- C#
- .NET
- MSTesting
- EntityFrameworkCore
- MySQL
- MySQLWorkBench

## Installation

- Install .NET locally if it isn't already installed
- MySQL Setup
  - Open MySQLWorkBench and select the Local instance 3306 server. You will need to enter the password you set. (I used "epicodus".)
    - Create a new schema/database with the naming convention first_last. (I used "jessica_munoz".)
    - Right click Tables and select create table within the database you created.
      - Name: clients
      - 1st Column | Column Name: ClientId, Datatype: INT, select PK, NN, AI
      - 2nd Column | Column Name: Description, Datatype: VARCHAR(255)
      - 3rd Column | Column Name: StylistId, Datatype: INT
      - Apply all changes.
    - Right click Tables and select create table within the database you created.
      - Name: stylists
      - 1st Column | Column Name: StylistId, Datatype: INT, select PK, NN, AI
      - 2nd Column | Column Name: Name, Datatype: VARCHAR(255)
      - Apply all changes.
  - Execute the following via the terminal: mysql -uroot -pepicodus
    - Note: If you have a different password for MySQLWorkBench, append the command -p.
  - If successful, you'll see the following returned: mysql>
- Open the terminal, clone down this repository.
- Via the terminal, navigate to the project folder HairSalon.Solution
- Via a text editor, open the project file HairSalon.Solution/HairSalon/appsettings.json
  - Edit the DefaultConnection with your schema/database name. (Ex. "database=first_last")
- Via the terminal, navigate to the project folder HairSalon.Solution/HairSalon
  - Enter the command: dotnet restore
  - Enter the command: dotnet build
  - Enter the command: dotnet run
  - Browse to http://localhost:5000/

## Specs

| Behaviors                              |                                                   Input                                                    |                Output                 |
| -------------------------------------- | :--------------------------------------------------------------------------------------------------------: | :-----------------------------------: |
| User can add new stylists.              |                      User clicks "Add a new stylist", fills out form and clicks "Add".                      |        New stylist is created.         |
| User can add new clients to the stylist. | User clicks on previously created stylist, clicks "Add a new client", fills out form and clicks "Add client". | New client for that stylist is created. |
| User can view all stylists.             |                                         User clicks "View stylists"                                         |  List of previously created stylists.  |

## Known Bugs

- No known bugs at this time.

## Support and contact details

_Please contact Jessica Munoz with questions and comments._

### License

_GNU GPLv3_

Copyright (c) 2019 **_Jessica Munoz_**
