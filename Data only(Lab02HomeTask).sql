USE [Lab02Home]
GO
INSERT [dbo].[Course] ([Course_Id], [Course_Name], [Student_Name], [Teacher_Name], [Semester]) VALUES (N'2', N'stat', N'Muhammad Burhan', N'XYZ', N'4')
GO
INSERT [dbo].[Result] ([Student_Id], [Student_Name], [Course_Name], [Marks], [Grade], [Section], [Semester], [Session]) VALUES (N'12', N'Muhhamd Burhan', N'DM', 111, N'a', N'c', 4, 2021)
GO
INSERT [dbo].[Student] ([RegistrationNumber], [Name], [Department], [Session], [Address]) VALUES (N'1', N'1', N'1', 11, N'1')
GO
