/*  TASK 6 */ 
select ShipCity as 'Cities Of USA ' , Count(ShipCity) as 'Numbers Of Orders' 
from Orders
where year(ShippedDate) = 1997 AND ShipCountry = 'USA' 
group by ShipCity