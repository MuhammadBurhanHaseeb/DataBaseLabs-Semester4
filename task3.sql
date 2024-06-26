/*  TASK 3 */
select Country,count(Country) as 'Greater than 2 or equal'
from Suppliers 
group by country 
having count(Country) >= 2  
