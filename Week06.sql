/** Q1 ***/

/*****   Return customers and their orders, including customers who placed no orders (CustomerID, OrderID,
OrderDate)  ***/
Select CustomerID,OrderID,OrderDate
From northwind.dbo.Orders 



/*** Q2   ***/

/*****   Report only those customer IDs who never placed any order. (CustomerID, OrderID, OrderDate)
 ***/
 Select CustomerID
from northwind.dbo.Customers
where CustomerID NOT IN (Select CustomerID From northwind.dbo.Orders )

/*** Q3   ***/

/*****   Report those customers who placed orders on July,1997. (CustomerID, OrderID, OrderDate)
 ***/
 Select CustomerID,OrderID,OrderDate
 From northwind.dbo.Orders
 where  YEAR(OrderDate) = '1997'	AND MONTH(OrderDate) = '07'
 /*** Q4  ***/

/*****   Report the total orders of each customer. (customerID, totalorders)
 ***/
 Select CustomerID,COUNT(OrderID) AS 'Total order'
 From northwind.dbo.Orders
 Group by CustomerID
 
 /*** Q5  ***/
 /*****   Write a query to generate a five copies of each employee. (EmployeeID, FirstName, LastName) ****/
 Select EmployeeID,FirstName,LastName,(Select EmployeeID  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID) AS 'Employee ID',(Select FirstName  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID) AS 'First Name',(Select LastName  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID) AS 'Last Name',(Select EmployeeID  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID)AS 'Employee ID',(Select FirstName  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID) AS 'First Name',(Select LastName  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID) AS 'Last Name',(Select EmployeeID  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID) AS 'Employee ID',(Select FirstName  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID) AS 'First Name',(Select LastName  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID) AS 'Last Name',(Select EmployeeID  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID) AS 'Employee ID',(Select FirstName  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID) AS 'First Name',(Select LastName  From northwind.dbo.Employees where EmployeeID = employee.EmployeeID) AS 'Last Name'
 From northwind.dbo.Employees employee

 /*** Q6  ***/
 /*****  List all the products whose price is more than average price. ***/
 Select * 
 From northwind.dbo.Products
 where UnitPrice >(Select AVG(UnitPrice) From northwind.dbo.Products )

  /*** Q7  ***/
 /*****  Find the second highest price of product.  ***/
 Select MAX(UnitPrice) AS 'Second Highest Price'
 From northwind.dbo.Products
 where UnitPrice <(Select MAX(UnitPrice) from northwind.dbo.Products)


   /*** Q8  ***/
 /*****  Write a query that returns a row for each employee and day in the range 04-07-1996 through 04-08-1997. (EmployeeID, Date)  ***/
	Select EmployeeID,HireDate
	From northwind.dbo.Employees
	Where HireDate IN (Select HireDate From northwind.dbo.Employees where HireDate Between  '1996-07-04' AND '1997-08-04')

     /*** Q9  ***/
 /*****  Return US customers, and for each customer return the total number of orders and total quantities.(CustomerID, Totalorders, totalquantity)  ***/
 Select Orders.CustomerID,COUNT(Orders.OrderID) AS 'Total Orders'
 From northwind.dbo.[Orders]  Orders 
 where CustomerID 	IN (Select CustomerID from northwind.dbo.Customers where Country = 'USA')
 Group by Orders.CustomerID
 
     /*** Q10  ***/
 /***** Write a query that returns all customers in the output, but matches them with their respective orders only if they were placed on July 04,1997. (CustomerID, CompanyName, OrderID, Orderdate)***/
 Select CustomerID,OrderID,OrderDate,(Select CompanyName   From northwind.dbo.Customers where CustomerID = Orders.CustomerID) AS 'Company Name'
 from northwind.dbo.Orders
 Where OrderDate = '1997-07-04'

      /*** Q11  ***/
 /***** Are there any employees who are older than their managers?***/
 Select  *
 From northwind.dbo.Employees
 where BirthDate < (Select BirthDate from northwind.dbo.Employees where Title = 'Sales Manager') AND Title != 'Sales Manager'


       /*** Q12  ***/
 /***** List that names of those employees and their ages. (EmployeeName, Age, Manager Age)  ***/
	 Select CONCAT(FirstName,' ',LastName) AS 'Employee Name',DATEDIFF(YEAR, BirthDate,GETDATE())/1 AS age,(Select DATEDIFF(YEAR, BirthDate,GETDATE())/1 AS 'Manager Age' From northwind.dbo.Employees where Title = 'Sales Manager') AS 'Manager Age'
	 from northwind.dbo.Employees
	 Where BirthDate < (Select BirthDate from northwind.dbo.Employees where Title = 'Sales Manager') AND Title != 'Sales Manager'
      
	  
	  /*** Q13  ***/
 /***** List the names of products which were ordered on 8th August 1997. (ProductName, OrderDate) ***/


  Select * , (Select ProductName  from northwind.dbo.Products where ProductID = Orderdetail.ProductID ) AS 'Product Name '
 from northwind.dbo.[Order Details] Orderdetail
 where OrderID = (select OrderID From northwind.dbo.Orders Orders where OrderDate = '1997-08-08') 


	  /*** Q14  ***/
 /***** List the addresses, cities, countries of all orders which were serviced by Anne and were shipped late.(Address, City, Country) ***/
 Select ShipAddress,ShipCity,ShipCountry
 from northwind.dbo.Orders 
 Where EmployeeID  IN (Select EmployeeID from northwind.dbo.Employees Where FirstName = 'Anne') AND ShippedDate > RequiredDate


	  /*** Q15  ***/
 /***** List all countries to which beverages have been shipped. (Country) ***/ 
 Select ShipCountry
 From northwind.dbo.Orders
Where OrderID IN(Select OrderID from northwind.dbo.[Order Details] where ProductID IN (Select ProductID from northwind.dbo.Products where CategoryID IN (Select CategoryID From northwind.dbo.Categories where CategoryName = 'beverages')))
