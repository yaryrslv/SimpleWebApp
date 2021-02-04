# SimpleWebApp

EntityFramework and Identity used.

- Add ConnectionString for Identity to AppSettings file.
- Create Database and Table:
```sql
CREATE TABLE %YourTableName (
    TotalId INT,
    UserName NVARCHAR(88),
    Name NVARCHAR(88),
    Cost INT
);
```
- Set your serverName, databaseName and salesTableName in BasketStore class.
- Deploy and run.

