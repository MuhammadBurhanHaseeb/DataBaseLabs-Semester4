

/* Q1 */
SELECT CustomerID , ContactName
FROM Customers
Where CustomerID In (Select CustomerID From Orders Where RequiredDate > ShippedDate)


/* Q2 */

SELECT Products.ProductName , ( SELECT Suppliers.ContactName FROM Suppliers Where Products.SupplierID = Suppliers.SupplierID) as SupplierName
FROM Products


/* Q3 */
SELECT ProductName
FROM Products
WHERE ProductID = ANY(SELECT ProductID From [Order Details] Where ProductID =Any(Select ProductID From Orders Where Year(ShippedDate) = '1998'));

 /* Q4 */
Select Concat(e.FirstName, ' ', e.LastName) as [Employee Name],
		(Select Concat(em.FirstName, ' ', em.LastName)
		  From Employees as em
		  Where e.ReportsTo = em.EmployeeID) as [Manager Name]
From Employees as e;

/* Q6 */
SELECT ProductName
From Products
Where UnitPrice > (SELECT AVG(UnitPrice) From Products)

/* Q7 */
SELECT MAX(UnitPrice) as SecondHighest
FROM Products
Where UnitPrice < ( SELECT MAX(UnitPrice) FROM Products)



 /* Q8 */
Select FirstName as EmployeeName, (Select FirstName From Employees as f Where e.ReportsTo = f.EmployeeID) as ManagerName, (Select DateDiff(Year, BirthDate, GETDATE()) From Employees as f Where e.EmployeeID = f.EmployeeID) as EmployeeAge, (Select DateDiff(Year, BirthDate, GETDATE()) From Employees as f Where e.ReportsTo = f.EmployeeID) as ManagerAge
From Employees as e
Where DateDiff(Year, BirthDate, GETDATE()) > (Select DateDiff(Year, BirthDate, GETDATE()) From Employees as f Where e.ReportsTo = f.EmployeeID);

/* Q9 */
SELECT ProductName
FROM Products
Where ProductID  IN ( SELECT ProductID FROM [Order Details] WHERE OrderID IN ( Select OrderID From Orders Where Year(OrderDate) = 1997 AND MONTH(OrderDate) = 08 AND DAY(OrderDate) = 08));

/* Q10 */
SELECT ContactName
FROM Suppliers
Where SupplierID  IN ( SELECT SupplierID From Products Where ProductID IN ( SELECT ProductID FROM [Order Details] WHERE OrderID IN ( Select OrderID From Orders Where Year(OrderDate) = 1997)));

/* Q11 */
SELECT Count(FirstName) as TotalEmploye
From Employees
Where EmployeeID IN ( SELECT EmployeeID FROM EmployeeTerritories WHERE TerritoryID IN ( SELECT TerritoryID FROM Territories WHERE RegionID IN ( SELECT RegionID FROM Region WHERE RegionDescription = 'Eastern')))



/* Q12 */
SELECT ProductName
FROM Products
Where ProductID  IN ( SELECT ProductID FROM [Order Details] WHERE OrderID IN ( Select OrderID From Orders Where Year(OrderDate) != 1996));
