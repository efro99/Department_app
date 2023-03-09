This App uses Entity Framework to create DB tables using SQLite. 

To part to verify tables and case you can see any db called DepartmentsContex.db. 

Please run the following steps: 
    - In case, you have EF installed and config skip the step number 3.
    1. Open the project usign VS Code. 
    2. Open the terminal
    3. In terminal run: 
        - dotnet tool install --global dotnet-ef
    4. Set Context Objects: 
        - dotnet ef migrations add InitialCreate --context DepartmentsContext
        - dotnet ef migrations add ModelRevisions --context DepartmentsContext
        - dotnet ef database update --context DepartmentsContext
    5. Behind step will create DepartmentsContex.db 
    6. Open using Sqllite to see all the tables.



Note: In case you want to create directly those tables in SQL Server database you can copy and run the data inside Sql_Script.sql