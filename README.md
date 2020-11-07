# Optical Clinic Patients Record System
This project was done, when I was a college student. This project, helped me, to practice my programming skills in C# and familiarization on Visual Studio. To those beginners like me, I hope this project will help you to gain great basic knowledge in C# and Visual Studio, just as it has helped me.

## Features
It's all about optical clinic patients record: 
- Add Patient 
- Insert Patient Rx 
- Edit or Update Patient Information 
- Search Patient History
- Backup Database 
- Restore Database
- Admin and Staff account

## Technologies 
- C# IDE: Microsoft Visual Studio 2015 
- Database: SQL (SQL Server 2012) 
- Framework: Entity Framework Database First

## How to use
- Download the project
- Import OpticalClinicPatientsRecordSystemDB.bacpac to your Microsoft SQL Server Management Studio
- Open the project
- Add new item "ADO.NET Entity Data Model"
  -- Select "EF Designer from database"
  -- Configure your connection
- Change this line of code **MarikinaOpticalEntities dbContext = new MarikinaOpticalEntities();** to **<i>Your Entity Model Name</i> dbcontext = new <i> Your Entity Model Name</i>**

## Note
Make sure your Database version is (SQL Server 2012) and (Microsoft SQL Server Management Studio	11.0.2100.60)

