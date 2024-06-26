/*  tASK 4 */
Select Month(RequiredDate) as 'Month Number' , count(*) as 'Order Delayed'
From Orders
Where RequiredDate < ShippedDate AND (ShippedDate)IS NOT NULL
Group by MONTH(RequiredDate)