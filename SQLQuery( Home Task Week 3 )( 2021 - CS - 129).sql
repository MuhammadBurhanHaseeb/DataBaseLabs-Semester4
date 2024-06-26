
/* Q1 */
SELECT *
FROM Orders
WHERE RequiredDate > ShippedDate;


/* Q2 */
SELECT Country, COUNT(Country) as CountryName
FROM Employees
GROUP BY Country;

/* Q3 */
SELECT [EmployeeID]
      ,[LastName]
      ,[FirstName]
      ,[Title]
      ,[TitleOfCourtesy]
      ,[BirthDate]
      ,[HireDate]
      ,[Address]
      ,[City]
      ,[Region]
      ,[PostalCode]
      ,[Country]
      ,[HomePhone]
      ,[Extension]
      ,[Photo]
      ,[Notes]
      ,[ReportsTo]
      ,[PhotoPath]
  FROM [Northwind].[dbo].[Employees]
  Where ReportsTo is Null;

/* Q4 */

SELECT productName
FROM products
WHERE discontinued = 'TRUE';


/* Q5 */
SELECT DISTINCT OrderID
FROM [Order Details]
WHERE Discount <= 0;

/* Q6 */
SELECT ContactName
FROM Customers
WHERE Region IS NULL;

/* Q7 */

SELECT ContactName, Phone
FROM Customers
WHERE Country = 'US' or Country = 'UK';

/* Q8 */
SELECT CompanyName
From Suppliers
WHERE HomePage IS NOT NULL;


/* Q9 */
SELECT DISTINCT(ShipCountry)
FROM Orders
WHERE YEAR(ShippedDate) = 1997;


/* Q10 */
SELECT DISTINCT CustomerID
FROM Orders
WHERE ShippedDate IS NULL;

/* Q11 */
SELECT SupplierID, CompanyName, City
FROM Suppliers;

/* Q12 */
SELECT *
FROM Employees
WHERE Country = 'UK' AND City = 'London';

/* Q13 */
SELECT productName
FROM products
WHERE discontinued = 'False';

/* Q14 */
SELECT DISTINCT OrderID
FROM [Order Details]
WHERE Discount <= 0.1;

/* Q15 */
SELECT EmployeeID, FirstName + ' ' + LastName AS EmployeeName, HomePhone + ' Ext: ' + Extension  AS ContactNumber
FROM Employees
WHERE Region IS NULL;
