/* TASK 7 */ 
select ShipCountry , Count(OrderID) as 'Delayed Orders'
from Orders
where ShippedDate > RequiredDate
group by ShipCountry