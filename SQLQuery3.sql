USE [northwind]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[stpGetCategoryWithName]
		@Name = N'Dairy Products'

SELECT	'Return Value' = @return_value

GO
