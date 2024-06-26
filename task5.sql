/*  TASK 5 */ 
select OrderID , Sum(Discount) as 'Total Discount On Each OrderID'
from  [Order Details]
group by OrderID
having sum(discount) > 0