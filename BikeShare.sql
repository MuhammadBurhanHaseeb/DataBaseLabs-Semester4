/* Q1 */

SELECT Location 
From Stations
Where Station_ID IN ( Select Station_ID FROM Bike_Rentals Where Customer_ID IN( SELECT Customer_ID FROM Payments WHERE yEAR(Date_stamp) =2004))

/* Q2*/

SELECT 
    bs.Bike_ID, 
    (
        SELECT SUM(r.Price) 
        FROM Repairs r
        WHERE r.B_Status_ID = bs.B_Status_ID
    ) AS Repairing_Cost
FROM 
    Bike_Status bs


/* Q3*/

Select Location
From Stations
WHERE Station_ID IN ( SELECT Station_ID FROM Bikes Where Bike_ID IN ( SELECT Bike_ID FROM Bike_Status WHERE B_Status_ID IN (  
SELECT B_STATUS_ID
FROM Repairs
Where  Price = ( SELECT MAX(Price) From Repairs ))))


/* Q4*/
SELECT Location , ( SELECT Count( Bikes.Station_ID) FROM Bikes Where Stations.Station_ID = Bikes.Station_ID GROUP BY Bikes.Station_ID) as total
FROM Stations


/* Q5 */


SELECT FName, LName
FROM Customer_Details
WHERE Customer_ID NOT IN (
    SELECT Customer_ID
    FROM Bike_Rentals
)


/* Q6 */
SELECT Bike_ID
FROM Bikes
WHERE Bike_ID IN ( SELECT Bike_ID FROM Bike_Rentals WHERE Customer_ID IN ( SELECT Customer_ID FROM Payments WHERE YEAR(Date_stamp) > 2016))

/* Q7 */
SELECT FName , Lname
From Customer_Details
Where Customer_ID IN ( SELECT Customer_ID From Payments WHERE Method_ID IN ( SELECT Method_ID FROM Payment_Method Where Method = 'mastercard'))


/* Q8*/
SELECT Location 
FROM Stations
WHERE Station_ID IN ( SELECT Station_ID FROM Bikes WHERE Bike_ID IN ( SELECT Bike_ID FROM Bike_Status WHERE Stations.Station_ID In ( SELECT Station_ID From Vans where YEAR(Date_stamp) = 2015)))



/* Q9*/
Select Avg(r.Price) as [AVG Price], (Select bs.B_Status_ID From Bike_Status as bs Where r.B_Status_ID = bs.B_Status_ID) as [Bike ID]
From Repairs as r
Group BY r.B_Status_ID

/*Q10*/
Select Distinct Bike_ID
From Bike_Status as bs
Where 3 <= (Select Count(Distinct Year(re.Delivered)) as total From Repairs re Where bs.B_status_ID = re.B_Status_ID Group BY B_Status_ID)
Order By Bike_ID;





