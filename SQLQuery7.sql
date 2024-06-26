USE [northwind]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[stpUpdateData]
		@Name = N'apple',
		@description = N'hello'

SELECT	'Return Value' = @return_value

GO
