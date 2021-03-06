USE [CouchingManagememtAppDB]
GO
/****** Object:  Table [dbo].[CourseManagement_T]    Script Date: 06/11/19 8:58:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseManagement_T](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Course_Name] [varchar](50) NULL,
	[Course_Fee] [int] NULL,
	[Duration] [varchar](50) NULL,
 CONSTRAINT [PK_CourseManagement_T] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentManagement_T]    Script Date: 06/11/19 8:58:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentManagement_T](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Student_Name] [varchar](50) NULL,
	[Address] [varchar](150) NULL,
	[Email] [varchar](50) NULL,
	[Date] [varchar](50) NULL,
	[Selected_Course] [varchar](50) NULL,
	[Course_Fee] [int] NULL,
	[Paid_Fee] [int] NULL,
	[Remaining_Fee] [int] NULL,
	[Selected_Teacher] [varchar](50) NULL,
	[Registration_No] [varchar](50) NULL,
 CONSTRAINT [PK_StudentManagement_T] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeacherManagement_T]    Script Date: 06/11/19 8:58:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherManagement_T](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Teacher_Name] [varchar](50) NULL,
	[Subject] [varchar](50) NULL,
	[Qualification] [varchar](50) NULL,
 CONSTRAINT [PK_TeacherManagement_T] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_T]    Script Date: 06/11/19 8:58:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_T](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_User_T] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CourseManagement_T] ON 

INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (5, N'Linux ', 50000, N'72 Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (1006, N'Web Design & Development', 12000, N'72 Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (1007, N'Graphics Design', 11000, N'78 Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (1008, N'Java SE-8', 14000, N'72 Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (1009, N'Bootstrap', 9000, N'60 Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (1010, N'PHP', 11000, N'72 Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (1011, N'Javascript', 12000, N'72 Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (1013, N'Windows Server', 15000, N'72 Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (2013, N'Auto CAD', 7000, N'72 Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (2014, N'C++', 7000, N'72Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (3014, N'F#', 2000, N'72 Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (3015, N'C#', 12000, N'72 Hours')
INSERT [dbo].[CourseManagement_T] ([Id], [Course_Name], [Course_Fee], [Duration]) VALUES (4014, N'CCNA', 1200, N'72 Hours')
SET IDENTITY_INSERT [dbo].[CourseManagement_T] OFF
SET IDENTITY_INSERT [dbo].[StudentManagement_T] ON 

INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (2, N'Rohit', N'India', N'Rohit@gmail.com', N'', N'PHP', NULL, NULL, NULL, N'Asif Mahamud', N'PH1801')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (3, N'Raina', N'India', N'Raina@gmail.com', N'04/27/2018', N'PHP', NULL, NULL, NULL, N'Asif Mahamud', N'PH1801')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (4, N'Vhirat', N'India', N'Vhirat@gmail.com', N'04/27/2018', N'PHP', NULL, NULL, NULL, N'Asif Mahamud', N'PH1801')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (5, N'gg', N'gg', N'gg@gmail.com', N'04/27/2018', N'PHP', NULL, NULL, NULL, N'Asif Mahamud', N'PH1801')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (6, N'lkl', N'klk', N'kjkj@gmail.com', N'04/27/2018', N'PHP', NULL, NULL, NULL, N'Asif Mahamud', N'PH1806')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (7, N'Adrika', N'Comilla', N'Adrika@gmail.com', N'04/27/2018', N'PHP', NULL, NULL, NULL, N'Asif Mahamud', N'PH1807')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (8, N'Raj', N'Chandpur', N'Raj@gmail.com', N'04/27/2018', N'Java SE-8', NULL, NULL, NULL, N'Nahid', N'Ja1801')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (9, N'Sajal', N'Dhaka', N'Sajal@gmail.com', N'04/29/2018', N'Linux', 50000, 50000, 0, N'Anwar Kabir', N'Li1801')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (10, N'Uttam Chandra', N'Chandpur', N'UttamChandra@gmail.com', N'05/01/2018', N'PHP', 9000, 9000, 0, N'Asif Mahamud', N'PH1808')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (11, N'Mamun', N'Dhaka', N'Mamun@gmail.com', N'05/02/2018', N'ASP.net', 1200, 1200, 0, N'Asif Mahamud', N'AS1801')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (12, N'Tanoy Sarker', N'Chandpur', N'Tanoy@gmail.com', N'05/02/2018', N'Auto CAD', 7000, 7000, 0, N'Mahub Alam', N'Au1801')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (13, N'Nahid ', N'Dhaka', N'Nahid@gmail.com', N'05/02/2018', N'Auto CAD', 7000, 3500, 3500, N'Mahub Alam', N'Au1802')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (14, N'Jewel', N'Dhaka', N'Jewel@gmail.com', N'05/02/2018', N'Bootstrap', 10000, NULL, NULL, N'Noman', N'Bo1801')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (15, N'jhdjhjff', N'fdf', N'jdhfj@gmail.com', N'04/27/2018', N'ASP.net', 1200, 1200, 0, N'Asif Mahamud', N'AS1802')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (19, N'Rajib Sarker', N'Dhaka', N'RajibSakre320@gmail.com', N'05/13/2018', N'Web Design & Development', 12000, 12000, 0, N'Asif Mahamud', N'We1801')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (23, N'Raw Code', N'Dhaka', N'Raw@gmail.com', N'05/13/2018', N'Web Design & Development', 12000, 12000, 0, N'Asif Mahamud', N'We1802')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (24, N'Nafiz', N'Dhaka', N'dfdfsnafiz@gmail.com', N'05/13/2018', N'Web Design & Development', 12000, 12000, 0, N'Asif Mahamud', N'We1803')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (25, N'Rajib Sarker', N'Dhaka', N'RajibSarker3202@gmail.com', N'07/03/2018', N'Windows Server', 15000, 15000, 0, N'MD. Mostafizur Rahaman', N'Wi1801')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (1025, N'iiui', N'uiu', N'd@gmail.com', N'12/24/2018', N'Web Design & Development', 12000, NULL, NULL, N'Asif Mahamud', N'We1804')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (1026, N'Rajib Sarker', N'Dhaka', N'R@gmail.com', N'01/17/2019', N'Web Design & Development', 12000, 12000, 0, N'Asif Mahamud', N'We1905')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (1027, N'Yeasin', N'Dhaka', N'Yeasin@gmail.com', N'01/18/2019', N'C#', 12000, 12000, 0, N'Hashan Ali', N'C#1901')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (1028, N'Zafor', N'Dkaka', N'Z@gmal.com', N'01/18/2019', N'C#', 12000, NULL, NULL, N'Hashan Ali', N'C#1902')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (2025, N'Jahid', N'Dhaka', N'jahid@gmail.com', N'04/01/2019', N'CCNA', 1200, 1200, 0, N'Anawar Kabir', N'CC1901')
INSERT [dbo].[StudentManagement_T] ([Id], [Student_Name], [Address], [Email], [Date], [Selected_Course], [Course_Fee], [Paid_Fee], [Remaining_Fee], [Selected_Teacher], [Registration_No]) VALUES (2026, N'Kabir Ahmed', N'Dhaka', N'Kabir@gmail.com', N'04/01/2019', N'CCNA', 1200, 1200, 0, N'Anawar Kabir', N'CC1902')
SET IDENTITY_INSERT [dbo].[StudentManagement_T] OFF
SET IDENTITY_INSERT [dbo].[TeacherManagement_T] ON 

INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (1004, N'Asif Mahamud', N'PHP', N'BSC In CSE')
INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (1009, N'Noman', N'Bootstrap', N'Diploma In CSE')
INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (1010, N'Nahid Rana', N'Java SE-8', N'Diploma In CSE')
INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (1020, N'Asif Mahamud', N'Web Design & Development', N'BSC In CSE')
INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (1021, N'Nahid Rana', N'Graphics Design', N'Diploma In CSE')
INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (1022, N'Jordhan', N'Java SE-8', N'BSC In CSE')
INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (1023, N'Anwar Kabir', N'Linux OS', N'BSC In CSE')
INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (1028, N'Nafew', N'Javascript', N'BSC In CSE')
INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (1029, N'MD. Mostafizur Rahaman', N'Windows Server', N'BSC In CSE')
INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (2029, N'Tanoy Sarker', N'Auto CAD', N'Civil Engineer')
INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (2030, N'Hashan', N'C#', N'BSC In CSE')
INSERT [dbo].[TeacherManagement_T] ([Id], [Teacher_Name], [Subject], [Qualification]) VALUES (3030, N'Anawar Kabir', N'CCNA', N'BSC In CSE')
SET IDENTITY_INSERT [dbo].[TeacherManagement_T] OFF
SET IDENTITY_INSERT [dbo].[User_T] ON 

INSERT [dbo].[User_T] ([Id], [User_Name], [Password]) VALUES (1, N'Rajib', N'password')
INSERT [dbo].[User_T] ([Id], [User_Name], [Password]) VALUES (2, N'Rajib Sarker', N'Rajib')
INSERT [dbo].[User_T] ([Id], [User_Name], [Password]) VALUES (3, N'Admin', N'admin')
INSERT [dbo].[User_T] ([Id], [User_Name], [Password]) VALUES (4, N'', N'')
INSERT [dbo].[User_T] ([Id], [User_Name], [Password]) VALUES (5, N'Rajib', N'Rajib')
INSERT [dbo].[User_T] ([Id], [User_Name], [Password]) VALUES (6, N'Batch#', N'Batch#')
INSERT [dbo].[User_T] ([Id], [User_Name], [Password]) VALUES (1006, N'RajibSarker', N'RajibSarker')
INSERT [dbo].[User_T] ([Id], [User_Name], [Password]) VALUES (2006, N'Yeasin', N'Yeasin')
SET IDENTITY_INSERT [dbo].[User_T] OFF
