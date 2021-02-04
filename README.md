# SimpleWebApp

EntityFramework and Identity used.

- Add ConnectionString for Identity to <strong>AppSettings</strong> file.
- Create Database and Table in your MS SQL Server:
```sql
CREATE TABLE %YourTableName% (
    TotalId INT,
    UserName NVARCHAR(88),
    Name NVARCHAR(88),
    Cost INT
);
```
- Set your serverName, databaseName and salesTableName in <strong>BasketStore</strong> class.
- Deploy and run.

