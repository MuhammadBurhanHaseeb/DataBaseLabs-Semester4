USE [northwind]
GO
/****** Object:  StoredProcedure [dbo].[stpUpdateData]    Script Date: 28/03/2023 9:21:35 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[stpUpdateData]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(15),
	@description ntext
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update Categories
	set Description = @description
	where CategoryName = @Name
END
