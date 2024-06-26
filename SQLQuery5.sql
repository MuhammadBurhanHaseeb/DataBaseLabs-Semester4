
USE [northwind]
 GO
 DECLARE @return_value int
 EXEC @return_value = [dbo].[stpinsertData]
 @CategoryName = N'mango'
 
 SELECT 'Return Value' = @return_value
 GO