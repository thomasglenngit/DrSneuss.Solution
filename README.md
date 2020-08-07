# _Factory_

#### _C#/.NET Project for [Epicodus](https://www.epicodus.com/), 2020.08.07_

#### By **Thomas Glenn**

<img src="HairSalon/wwwroot/assets/images/eauclaire.png"          style="float: left; margin-right: 10px;" />

## Description
A code review program for Epicodus school, which tracks the Engineers for Dr. Sneuss, the owner of his Factory. 


## Specifications
| Spec | Input | Output | 
|:--------- |:--------- |:-------- |:---------|
| The program will construct a database of Engineers allowing Dr. Sneuss to make entries | "First Name", "Last Name "ID" | "Tony Stark" "1"| 
| The program will construct a database of Machines allowing Dr. Sneuss to make entries | "Name"  "Function" "Contruction Date" | "Robbie2369*" "Protocol Droid" "08.07.2020"|
| The program will allow Dr. Sneuss to view lists of Engineers | "Tony Stark" -- "Caractacus Potts" |
| The program will allow Dr. Sneuss to view lists of Machines | "Tony Stark" -- "Caractacus Potts" |
| The program will allow Dr. Sneuss to view lists of Machines with the Engineers licensed to repair it| "Tony Stark" -- "Caractacus Potts" |
| The program will allow Dr. Sneuss to view lists of Engineers with the Machines they are licensed to repair| "Tony Stark" -- "Caractacus Potts" |
| The program will allow Dr. Sneuss to edit entries | "Tony Stank" | "Tony Stark"
| The program will allow Dr. Sneuss to delete entries | "Tony Stark Smythe" | " " | 

## Known Bugs
* No known bugs.   

## Setup/Installation Requirements
#### View Online
Visit the GitHub Pages by clicking on the following link or by typing it in your web browser. 
<url:>

https://github.com/thomasglenngit/HairSalon.Solution

#### View locally

*[.NET Core](https://dotnet.microsoft.com/download/dotnet-core/2.2) is needed to run this application*

To clone this repository from your command line you will need [Git](https://git-scm.com/) installed. 

First navigate in the command line to where you want to clone this repository. 

Then from your command line run:

`$ git clone `

Once the repository has been cloned, navigate to the to the application directory and run `$ dotnet restore`.
Once 'restore' is run, enter `$ dotnet build`.

#### MySQL Setup
In order to view and use the functionality of this project you must,
1. Install MySQL on your computer. If you don't have it, you can download the .dmg file here:
https://dev.mysql.com/downloads/file/?id=484914. You'll need to create a password.

2. Install MySQL Workbench on your computer. If you don't have it, you can download it here:
https://dev.mysql.com/downloads/file/?id=484391.

3. Open MySQL Workbench and select the Local instance 3306 server. 

#### Importing this file:
1. Open your MySQL Workbench. In the Navigator > Administration window, select Data Import/Restore.

2. In Import Options select Import from Self-Contained File.

3. Navigate to `thomas_glenn`.

Under Default Schema to be Imported To, select the New button.

Enter the name of your database with _test appended to the end.
In this case thomas_glenn_test.
Click Ok.
Click Start Import.

Reopen the Navigator > Schemas tab. Right click and select Refresh All. Our new test database will appear.

#### Query
The following is the query information for access this database on MySQL Workbench.
```
DROP DATABASE IF EXISTS `thomas_glenn`;
CREATE DATABASE `thomas_glenn`;
USE `thomas_glenn`;
CREATE DATABASE `thomas_glenn` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
CREATE TABLE `clients` (
  `clientId` int(11) NOT NULL AUTO_INCREMENT,
  `stylistId` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `mobile` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`clientId`,`stylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `stylists` (
  `stylistId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`stylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```


### Edit
* To view and edit the code, open the application in your preferred code editor, such as Visual Studio Code.

## Technologies Used
* Visual Studio Code (code editor)
* C#/.NET
* GitHub
* MSTests
* MacOS Catalina

## License
This software is licensed under the MIT license. Copyright (c) 2020 Thomas Glenn.