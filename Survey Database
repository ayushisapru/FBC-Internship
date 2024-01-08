USE [SurveyDB]
GO
/****** Object:  Table [dbo].[Additional_people]    Script Date: 7/28/2022 12:30:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Additional_people](
	[Additional_id] [int] IDENTITY(1,1) NOT NULL,
	[SDID] [int] NOT NULL,
	[Additional_first_name] [varchar](20) NOT NULL,
	[Additional_last_name] [varchar](20) NOT NULL,
	[Additional_email] [varchar](255) NOT NULL,
	[Additional_phone] [bigint] NOT NULL,
	[User_created] [varchar](50) NOT NULL,
	[User_created_date] [datetime] NOT NULL,
	[User_updated] [varchar](50) NULL,
	[User_updated_date_time] [datetime] NULL,
 CONSTRAINT [PK_Additional_people] PRIMARY KEY CLUSTERED 
(
	[Additional_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gaurdians]    Script Date: 7/28/2022 12:30:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gaurdians](
	[Gaurdian_id] [int] IDENTITY(1,1) NOT NULL,
	[SDID] [int] NOT NULL,
	[Gaurdian_first_name] [varchar](20) NOT NULL,
	[Gaurdian_last_name] [varchar](50) NOT NULL,
	[Gaurdian_email] [varchar](255) NOT NULL,
	[Gaurdian_phone] [bigint] NULL,
	[User_created] [varchar](50) NOT NULL,
	[User_created_date_time] [datetime] NOT NULL,
	[User_updated] [varchar](50) NULL,
	[User_updated_date_time] [datetime] NULL,
 CONSTRAINT [PK_Gaurdians] PRIMARY KEY CLUSTERED 
(
	[Gaurdian_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Interviewers]    Script Date: 7/28/2022 12:30:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Interviewers](
	[Interviewer_id] [int] IDENTITY(1,1) NOT NULL,
	[SDID] [int] NOT NULL,
	[Interviewer_first_name] [varchar](20) NOT NULL,
	[Interviewer_last_name] [varchar](20) NOT NULL,
	[Interviewer_email] [varchar](255) NOT NULL,
	[Interviewer_phone] [bigint] NULL,
	[User_created] [varchar](50) NOT NULL,
	[User_created_date_time] [datetime] NOT NULL,
	[User_updated] [varchar](50) NULL,
	[User_updated_date_time] [datetime] NULL,
 CONSTRAINT [PK_Interviewers] PRIMARY KEY CLUSTERED 
(
	[Interviewer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Q_and_A]    Script Date: 7/28/2022 12:30:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Q_and_A](
	[QA_record] [int] IDENTITY(1,1) NOT NULL,
	[SDID] [int] NOT NULL,
	[Survey_id] [int] NOT NULL,
	[Question_id] [int] NOT NULL,
	[Answer] [varchar](3) NULL,
	[User_created] [varchar](50) NOT NULL,
	[User_created_date_time] [datetime] NOT NULL,
	[User_updated] [varchar](50) NULL,
	[User_updated_date_time] [datetime] NULL,
 CONSTRAINT [PK_Q_and_A] PRIMARY KEY CLUSTERED 
(
	[QA_record] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 7/28/2022 12:30:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[Question_id] [int] IDENTITY(1,1) NOT NULL,
	[Question_desc] [varchar](500) NOT NULL,
	[User_created] [varchar](50) NOT NULL,
	[User_created_date_time] [datetime] NOT NULL,
	[User_updated] [varchar](50) NULL,
	[User_updated_date_time] [datetime] NULL,
 CONSTRAINT [PK_Questions_1] PRIMARY KEY CLUSTERED 
(
	[Question_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Survey_Info]    Script Date: 7/28/2022 12:30:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Survey_Info](
	[SDID] [int] IDENTITY(1,1) NOT NULL,
	[Juvenile_first_name] [varchar](20) NOT NULL,
	[Juvenile_last_name] [varchar](20) NOT NULL,
	[Survey_id] [int] NOT NULL,
	[Survey_answer] [varchar](3) NOT NULL,
	[User_created] [varchar](50) NULL,
	[User_created_date_time] [datetime] NOT NULL,
	[User_updated] [varchar](50) NULL,
	[User_updated_date_time] [datetime] NULL,
 CONSTRAINT [PK_Survey_Info] PRIMARY KEY CLUSTERED 
(
	[SDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Additional_people] ADD  CONSTRAINT [DF_Additional_people_Additional_phone]  DEFAULT ((0.)) FOR [Additional_phone]
GO
ALTER TABLE [dbo].[Additional_people] ADD  CONSTRAINT [DF_Additional_people_User_created_date]  DEFAULT (getdate()) FOR [User_created_date]
GO
ALTER TABLE [dbo].[Gaurdians] ADD  CONSTRAINT [DF_Gaurdians_Gaurdian_phone]  DEFAULT ((0)) FOR [Gaurdian_phone]
GO
ALTER TABLE [dbo].[Gaurdians] ADD  CONSTRAINT [DF_Gaurdians_User_created_date_time]  DEFAULT (getdate()) FOR [User_created_date_time]
GO
ALTER TABLE [dbo].[Interviewers] ADD  CONSTRAINT [DF_Interviewers_Interviewer_phone]  DEFAULT ((0)) FOR [Interviewer_phone]
GO
ALTER TABLE [dbo].[Interviewers] ADD  CONSTRAINT [DF_Interviewers_User_created_date_time]  DEFAULT (getdate()) FOR [User_created_date_time]
GO
ALTER TABLE [dbo].[Q_and_A] ADD  CONSTRAINT [DF_Q_and_A_User_created_date_time]  DEFAULT (getdate()) FOR [User_created_date_time]
GO
ALTER TABLE [dbo].[Questions] ADD  CONSTRAINT [DF_Questions_User_created_date_time]  DEFAULT (getdate()) FOR [User_created_date_time]
GO
ALTER TABLE [dbo].[Questions] ADD  CONSTRAINT [DF_Questions_User_updated_date_time]  DEFAULT (getdate()) FOR [User_updated_date_time]
GO
ALTER TABLE [dbo].[Survey_Info] ADD  CONSTRAINT [DF_Survey_Info_User_created_date_time]  DEFAULT (getdate()) FOR [User_created_date_time]
GO
ALTER TABLE [dbo].[Additional_people]  WITH CHECK ADD  CONSTRAINT [FK_Additional_people_Survey_Info] FOREIGN KEY([SDID])
REFERENCES [dbo].[Survey_Info] ([SDID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Additional_people] CHECK CONSTRAINT [FK_Additional_people_Survey_Info]
GO
ALTER TABLE [dbo].[Gaurdians]  WITH CHECK ADD  CONSTRAINT [FK_Gaurdians_Survey_Info] FOREIGN KEY([SDID])
REFERENCES [dbo].[Survey_Info] ([SDID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Gaurdians] CHECK CONSTRAINT [FK_Gaurdians_Survey_Info]
GO
ALTER TABLE [dbo].[Interviewers]  WITH CHECK ADD  CONSTRAINT [FK_Interviewers_Survey_Info] FOREIGN KEY([SDID])
REFERENCES [dbo].[Survey_Info] ([SDID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Interviewers] CHECK CONSTRAINT [FK_Interviewers_Survey_Info]
GO
ALTER TABLE [dbo].[Q_and_A]  WITH CHECK ADD  CONSTRAINT [FK_Q_and_A_Questions] FOREIGN KEY([Question_id])
REFERENCES [dbo].[Questions] ([Question_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Q_and_A] CHECK CONSTRAINT [FK_Q_and_A_Questions]
GO
ALTER TABLE [dbo].[Q_and_A]  WITH CHECK ADD  CONSTRAINT [FK_Q_and_A_Survey_Info] FOREIGN KEY([SDID])
REFERENCES [dbo].[Survey_Info] ([SDID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Q_and_A] CHECK CONSTRAINT [FK_Q_and_A_Survey_Info]
GO
