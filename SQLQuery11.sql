USE [northwind]
GO
/****** Object:  StoredProcedure [dbo].[stptest]    Script Date: 28/03/2023 9:52:29 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[stptest]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select UnitPrice , Quantity
	from Orders join [Order Details] on  Orders.OrderID = [Order Details].OrderID


    -- Insert statements for procedure here
END
