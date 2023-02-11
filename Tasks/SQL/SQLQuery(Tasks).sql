USE Adventureworks
GO

--Display firstname,lastname from person.person whose title is not null.
SELECT firstname,lastname 
FROM person.person 
WHERE Title is not null


--Display Firstname,lastname from person.person whose firstname and lastname should have atleast one 'a'.
 SELECT Firstname,lastname
FROM person.person 
where FirstName like '%a%' and LastName like '%a%'


--Display currencycode,name from Sales.Currency and Sales.CountryRegionCurrency without using joins
select c.CurrencyCode , c.Name , rc.CurrencyCode
FROM Sales.Currency c , Sales.CountryRegionCurrency rc


--Copy humanresources.department table to the new table named as 'HR.Dept'

 SELECT  * into  HumanResources.Dept
FROM HumanResources.Department

 SELECT * FROM HumanResources.Dept


--Create a table with column named 'SNo' and make that column as identity.
--insert 20 rows using insert into statement(table should contain 5 columns)

create table t1
(
Sno int identity(1,1),
f_name varchar(50),
l_name varchar(50),
age int,
gender char(1) CHECK (gender in('M' , 'F'))
)

 SELECT * FROM t1

--Perform inner join operation to display businessentityid,addresstypeid from humanresources.department
-- and Person.BusinessEntityAddress

 SELECT businessentityid,AddressID ,addresstypeid
FROM humanresources.department
join Person.BusinessEntityAddress
on BusinessEntityID = DepartmentID

--Display distinct values of column named 'Group name' from
--humanresources.department

 SELECT distinct GroupName
FROM HumanResources.Department

--Display StandardCost,sum of ListPrice & StandardCost from 
--Production.ProductCostHistory and Production.Product
  
   SELECT pc.StandardCost,p.StandardCost,sum(p.ListPrice) 
  FROM Production.ProductCostHistory pc
  join Production.Product p
  on pc.ProductID=p.ProductID
  Group by p.StandardCost,pc.StandardCost,p.ListPrice

   SELECT * FROM Production.ProductCostHistory
   SELECT * FROM Production.Product

 -- Use Datediff() fumction to find 'Years on role' using Startdate 
 -- and enddate from HumanResources.EmployeeDepartmentHistory

 SELECT datediff(year,StartDate,EndDate)
 FROM HumanResources.EmployeeDepartmentHistory


 --find the maximum taxrate as Max_taxrate from sales.salestaxrate
 SELECT max(TaxRate) as Max_taxrate
 from Sales.SalesTaxRate

 SELECT * from Sales.SalesTaxRate

--Perform Join Operation and display DepartmentID,BusinessentityId,ShiftId,
--BirthDate.Find Age and display.(use getdate() function).
--Note: Use HumanResources.Employee,HumanResources.Department,
--HumanResources.EmployeeDepartmentHistory.


SELECT ed.DepartmentID,e.BusinessentityId,ed.ShiftId,e.BirthDate, DATEDIFF(YY,e.BirthDate,getdate()) as age
FROM HumanResources.Employee e
join HumanResources.EmployeeDepartmentHistory ed
on e.BusinessEntityID=ed.BusinessEntityID
join HumanResources.Department d
on ed.DepartmentID = d.DepartmentID




--Create view named 'Name_age' for Task-12

create view Name_Age
as
 SELECT ed.DepartmentID,e.BusinessentityId,ed.ShiftId,e.BirthDate, DATEDIFF(YY,e.BirthDate,getdate()) as age
FROM HumanResources.Employee e, HumanResources.EmployeeDepartmentHistory ed ,HumanResources.Department d


 SELECT * FROM  Name_Age


 SELECT * FROM HumanResources.Employee



--Find the total number of rows in the tables starting with schema name 'humanresources'.
--Display result as No_of_rows_hr


 SELECT count(*) FROM HumanResources.Department -- to count no of rows in a table

 SELECT * from HumanResources.Department 


 SELECT count(*) FROM HumanResources.Department 
union 
 SELECT count(*) FROM HumanResources.Employee


 SELECT HumanResources.Department,HumanResources.Employee,HumanResources.EmployeeDepartmentHistory



SELECT SUM(st.row_count) as No_of_rows_hr
FROM sys.tables t
INNER JOIN sys.dm_db_partition_stats st
ON t.[object_id] = st.[object_id]
WHERE t.schema_id = SCHEMA_ID('humanresources')


--Display maximum rate for each department



SELECT DepartmentID, MAX(Rate) AS MaxRate
FROM HumanResources.EmployeePayHistory ep
JOIN HumanResources.EmployeeDepartmentHistory ed
ON ed.BusinessEntityID = ep.BusinessEntityID
GROUP BY DepartmentID  -- to get max rate of diff dept


--perform Left join between person.person and person.BusinessEntityAddress 
--and display FirstName,MiddleName,Title,AddressTypeID,businessentityID.
--Don't display the names whose title is null


SELECT p.FirstName, p.MiddleName, p.Title, bea.AddressTypeID, bea.BusinessEntityID
FROM Person.Person p
LEFT JOIN Person.BusinessEntityAddress bea
ON p.BusinessEntityID = bea.BusinessEntityID
WHERE p.Title IS NOT NULL


--Display ProductID,LocationID,Shelf from Production.ProductInventory whose
--ProductID should be between 300-350,LocationID should be 50 or Shelf = 'E'


SELECT ProductID,LocationID,Shelf
FROM Production.ProductInventory
WHERE (ProductID BETWEEN 300 AND 350) AND (LocationID = 50 OR Shelf = 'E')


--Display LocationID,Shelf,Name by joining Production.ProductInventory 
--and Production.Location

SELECT pi.LocationID, pi.Shelf, l.Name
FROM Production.ProductInventory pi
JOIN Production.Location l
ON pi.LocationID = l.LocationID


--Display AddressID,AddressLine1,AddressLine2,StateProvinceID,StateProvinceCode
--,CountryRegionCode from Person.StateProvince and Person.Address

SELECT a.AddressID, a.AddressLine1, a.AddressLine2, sp.StateProvinceID, sp.StateProvinceCode, sp.CountryRegionCode
FROM Person.Address a
LEFT JOIN Person.StateProvince sp
ON a.StateProvinceID = sp.StateProvinceID

--Display currency code,sum of subtotal and TaxAmt as total
--using Sales.SalesOrderHeader,Sales.SalesTerritory and Sales.CountryRegionCurrency

SELECT 
  crc.CurrencyCode, 
  SUM(soh.SubTotal) + SUM(soh.TaxAmt) AS Total, 
  st.Name
FROM 
  Sales.SalesOrderHeader soh
  INNER JOIN Sales.SalesTerritory st
  ON soh.TerritoryID = st.TerritoryID
  INNER JOIN Sales.CountryRegionCurrency crc
  ON st.CountryRegionCode = crc.CountryRegionCode
GROUP BY 
  crc.CurrencyCode, 
  st.Name





