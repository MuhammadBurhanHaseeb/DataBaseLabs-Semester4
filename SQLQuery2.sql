USE [northwind]
GO
/****** Object:  StoredProcedure [dbo].[stpGetCategoryWithName]    Script Date: 27/03/2023 10:08:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[stpGetCategoryWithName] 
	-- Add the parameters for the stored procedure here
	@Name nvarchar(15)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select * From Categories
    where  CategoryName like '%'+@Name+'%'
END
EXEC stpGetCategoryWithName @Name = 'r'