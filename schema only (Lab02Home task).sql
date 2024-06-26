USE [Lab02Home]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 28/01/2023 2:47:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Course_Id] [varchar](50) NULL,
	[Course_Name] [varchar](50) NULL,
	[Student_Name] [varchar](50) NULL,
	[Teacher_Name] [varchar](50) NULL,
	[Semester] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Result]    Script Date: 28/01/2023 2:47:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[Student_Id] [varchar](50) NULL,
	[Student_Name] [varchar](50) NULL,
	[Course_Name] [varchar](50) NULL,
	[Marks] [smallint] NULL,
	[Grade] [varchar](50) NULL,
	[Section] [varchar](50) NULL,
	[Semester] [tinyint] NULL,
	[Session] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 28/01/2023 2:47:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[RegistrationNumber] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Department] [varchar](50) NULL,
	[Session] [smallint] NULL,
	[Address] [varchar](50) NULL
) ON [PRIMARY]
GO
