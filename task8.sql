/* TASK 8 */ 
select OrderID , Sum(Discount)  as 'Total Discount On Each OrderID' , sum(UnitPrice) as 'Total Price'
from  [Order Details]
group by OrderID
having sum(discount) > 0