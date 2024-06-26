USE [northwind]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[stpDeleteData]
		@name = N'apple'

SELECT	'Return Value' = @return_value

GO
