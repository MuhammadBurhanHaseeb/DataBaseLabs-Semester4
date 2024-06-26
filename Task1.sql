/*  TASK 1 */ 
/*This is not  done with the Single Query 


aleternate method with the subQuery*/

/* TASK 1  */
select productName 
from Products p  
where p.UnitPrice >(select avg(UnitPrice) from Products )
