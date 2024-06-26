USE [Test4]
GO

 /****** Object: Table [dbo].[tblMembers] Script Date: 18-Nov-17,Sat 6:47:55 PM ******/
 SET ANSI_NULLS ON
 GO

 SET QUOTED_IDENTIFIER ON
 GO

 SET ANSI_PADDING ON
 GO

--Page 5 of 20
 CREATE TABLE [dbo].[tblMembers](
 [MemberID] [int] IDENTITY(1,1) NOT NULL,
 [MemberName] [varchar](50) NULL,
 [MemberCity] [varchar](25) NULL,
 [MemberPhone] [varchar](15) NULL
 )

 GO

 SET ANSI_PADDING OFF
 GO




SET ANSI_NULLS ON  
 GO  
SET QUOTED_IDENTIFIER ON  
GO  
-- =============================================  
	-- Author:      Manoj Kalla  
	-- Create date: 18th Nov 2017  
	-- Description: Return all members  
	-- =============================================  
	--Store procedure name is --> stpGetAllMembers  
	CREATE PROCEDURE stpGetAllMembers  
	AS  
	BEGIN  
	    -- SET NOCOUNT ON added to prevent extra result sets from  
	    -- interfering with SELECT statements.  
	    SET NOCOUNT ON;  
	  
	    -- Select statements for procedure here  
	    Select * from tblMembers  
END  
	GO  




 EXEC stpGetAllMembers



SET ANSI_NULLS ON
 GO
 SET QUOTED_IDENTIFIER ON
 GO
 -- =============================================
 -- Author: Manoj Kalla
 -- Create date: 20-Nov-2017
 -- Description: Return specifc city records
 -- =============================================
 CREATE PROCEDURE stpGetMembersByCityName
 -- Add the parameters for the stored procedure here
 @CityName nvarchar(30)

 AS
 BEGIN
 -- SET NOCOUNT ON added to prevent extra result sets from
 -- interfering with SELECT statements.
 SET NOCOUNT ON;

 Select * From tblMembers
 where MemberCity like '%'+@CityName+'%'

 END
 GO


EXEC dbo.stpGetMembersByCityName @CityName = 'mal'