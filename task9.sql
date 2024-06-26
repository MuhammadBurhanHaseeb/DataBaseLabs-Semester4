/*  TASK 9 */ 
select ShipRegion ,  ShipCity  , Count(ShipCity) as 'Numbers Of Orders' 
from Orders
where year(ShippedDate) = 1997  
group by ShipCity , ShipRegion