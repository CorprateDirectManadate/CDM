USE [WorkflowEngine]
GO
/****** Object:  Table [dbo].[spl_applications]    Script Date: 06/17/2013 11:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[spl_applications](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Code] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_spl_applications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_spl_applications] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[spl_Workflows]    Script Date: 06/17/2013 11:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[spl_Workflows](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[ApplicationId] [int] NOT NULL,
	[OnRejection] [int] NOT NULL,
	[MaxLevel] [int] NOT NULL,
 CONSTRAINT [PK_spl_Workflows] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[spl_Actors]    Script Date: 06/17/2013 11:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[spl_Actors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ActorRefId] [nvarchar](600) NOT NULL,
	[Description] [nvarchar](600) NOT NULL,
	[ApplicationId] [int] NOT NULL,
 CONSTRAINT [PK_spl_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[spl_Processes]    Script Date: 06/17/2013 11:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[spl_Processes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](100) NULL,
	[ProcessRefId] [nvarchar](200) NOT NULL,
	[WorkflowId] [int] NOT NULL,
	[CurrentLevelId] [int] NOT NULL,
	[Closed] [bit] NOT NULL,
 CONSTRAINT [PK_spl_Processes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_spl_Processes] UNIQUE NONCLUSTERED 
(
	[Id] ASC,
	[ProcessRefId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[spl_WorkflowLevels]    Script Date: 06/17/2013 11:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[spl_WorkflowLevels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[WorkflowId] [int] NOT NULL,
	[LevelOrder] [int] NOT NULL,
 CONSTRAINT [PK_spl_WorkflowLevels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_spl_WorkflowLevels] UNIQUE NONCLUSTERED 
(
	[WorkflowId] ASC,
	[LevelOrder] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_spl_WorkflowLevels_UniueName] UNIQUE NONCLUSTERED 
(
	[WorkflowId] ASC,
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[spl_WorkflowHistories]    Script Date: 06/17/2013 11:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[spl_WorkflowHistories](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProcessId] [int] NOT NULL,
	[ActorId] [int] NOT NULL,
	[LevelId] [int] NOT NULL,
	[Approved] [bit] NOT NULL,
	[ActionDate] [datetime] NOT NULL,
	[Comment] [nvarchar](500) NULL,
 CONSTRAINT [PK_spl_WorkflowHistories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[spl_LevelExpressions]    Script Date: 06/17/2013 11:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[spl_LevelExpressions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Expression] [nvarchar](1000) NOT NULL,
	[Parameters] [nvarchar](1000) NOT NULL,
	[WorkflowLevelId] [int] NOT NULL,
	[MaximumApprovalRequired] [int] NOT NULL,
 CONSTRAINT [PK_spl_LevelExpressions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[spl_ActorsInLevels]    Script Date: 06/17/2013 11:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[spl_ActorsInLevels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ActorId] [int] NOT NULL,
	[WorkflowLevelId] [int] NOT NULL,
	[ActorMustApprove] [bit] NOT NULL,
 CONSTRAINT [PK_spl_ActorsInLevels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_spl_ActorsInLevels_ActorMustApprove]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_ActorsInLevels] ADD  CONSTRAINT [DF_spl_ActorsInLevels_ActorMustApprove]  DEFAULT ((0)) FOR [ActorMustApprove]
GO
/****** Object:  Default [DF_spl_LevelExpressions_MaximumApprovalRequired]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_LevelExpressions] ADD  CONSTRAINT [DF_spl_LevelExpressions_MaximumApprovalRequired]  DEFAULT ((1)) FOR [MaximumApprovalRequired]
GO
/****** Object:  Default [DF_spl_Processes_Closed]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_Processes] ADD  CONSTRAINT [DF_spl_Processes_Closed]  DEFAULT ((0)) FOR [Closed]
GO
/****** Object:  Default [DF_spl_WorkflowHistories_Approved]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_WorkflowHistories] ADD  CONSTRAINT [DF_spl_WorkflowHistories_Approved]  DEFAULT ((0)) FOR [Approved]
GO
/****** Object:  Default [DF_spl_Workflows_OnRejection]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_Workflows] ADD  CONSTRAINT [DF_spl_Workflows_OnRejection]  DEFAULT ((0)) FOR [OnRejection]
GO
/****** Object:  Default [DF_spl_Workflows_MaxLevel]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_Workflows] ADD  CONSTRAINT [DF_spl_Workflows_MaxLevel]  DEFAULT ((1)) FOR [MaxLevel]
GO
/****** Object:  ForeignKey [FK_spl_Actors_spl_applications]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_Actors]  WITH CHECK ADD  CONSTRAINT [FK_spl_Actors_spl_applications] FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[spl_applications] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[spl_Actors] CHECK CONSTRAINT [FK_spl_Actors_spl_applications]
GO
/****** Object:  ForeignKey [FK_spl_ActorsInLevels_spl_Actors]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_ActorsInLevels]  WITH CHECK ADD  CONSTRAINT [FK_spl_ActorsInLevels_spl_Actors] FOREIGN KEY([ActorId])
REFERENCES [dbo].[spl_Actors] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[spl_ActorsInLevels] CHECK CONSTRAINT [FK_spl_ActorsInLevels_spl_Actors]
GO
/****** Object:  ForeignKey [FK_spl_ActorsInLevels_spl_WorkflowLevels]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_ActorsInLevels]  WITH CHECK ADD  CONSTRAINT [FK_spl_ActorsInLevels_spl_WorkflowLevels] FOREIGN KEY([WorkflowLevelId])
REFERENCES [dbo].[spl_WorkflowLevels] ([Id])
GO
ALTER TABLE [dbo].[spl_ActorsInLevels] CHECK CONSTRAINT [FK_spl_ActorsInLevels_spl_WorkflowLevels]
GO
/****** Object:  ForeignKey [FK_spl_LevelExpressions_spl_WorkflowLevels]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_LevelExpressions]  WITH CHECK ADD  CONSTRAINT [FK_spl_LevelExpressions_spl_WorkflowLevels] FOREIGN KEY([WorkflowLevelId])
REFERENCES [dbo].[spl_WorkflowLevels] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[spl_LevelExpressions] CHECK CONSTRAINT [FK_spl_LevelExpressions_spl_WorkflowLevels]
GO
/****** Object:  ForeignKey [FK_spl_Processes_spl_Workflows]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_Processes]  WITH CHECK ADD  CONSTRAINT [FK_spl_Processes_spl_Workflows] FOREIGN KEY([WorkflowId])
REFERENCES [dbo].[spl_Workflows] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[spl_Processes] CHECK CONSTRAINT [FK_spl_Processes_spl_Workflows]
GO
/****** Object:  ForeignKey [FK_spl_WorkflowHistories_spl_Actors]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_WorkflowHistories]  WITH CHECK ADD  CONSTRAINT [FK_spl_WorkflowHistories_spl_Actors] FOREIGN KEY([ActorId])
REFERENCES [dbo].[spl_Actors] ([Id])
GO
ALTER TABLE [dbo].[spl_WorkflowHistories] CHECK CONSTRAINT [FK_spl_WorkflowHistories_spl_Actors]
GO
/****** Object:  ForeignKey [FK_spl_WorkflowHistories_spl_Processes]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_WorkflowHistories]  WITH CHECK ADD  CONSTRAINT [FK_spl_WorkflowHistories_spl_Processes] FOREIGN KEY([ProcessId])
REFERENCES [dbo].[spl_Processes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[spl_WorkflowHistories] CHECK CONSTRAINT [FK_spl_WorkflowHistories_spl_Processes]
GO
/****** Object:  ForeignKey [FK_spl_WorkflowHistories_spl_WorkflowLevels]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_WorkflowHistories]  WITH CHECK ADD  CONSTRAINT [FK_spl_WorkflowHistories_spl_WorkflowLevels] FOREIGN KEY([LevelId])
REFERENCES [dbo].[spl_WorkflowLevels] ([Id])
GO
ALTER TABLE [dbo].[spl_WorkflowHistories] CHECK CONSTRAINT [FK_spl_WorkflowHistories_spl_WorkflowLevels]
GO
/****** Object:  ForeignKey [FK_spl_WorkflowLevels_spl_Workflows]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_WorkflowLevels]  WITH CHECK ADD  CONSTRAINT [FK_spl_WorkflowLevels_spl_Workflows] FOREIGN KEY([WorkflowId])
REFERENCES [dbo].[spl_Workflows] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[spl_WorkflowLevels] CHECK CONSTRAINT [FK_spl_WorkflowLevels_spl_Workflows]
GO
/****** Object:  ForeignKey [FK_spl_Workflows_spl_applications]    Script Date: 06/17/2013 11:01:25 ******/
ALTER TABLE [dbo].[spl_Workflows]  WITH CHECK ADD  CONSTRAINT [FK_spl_Workflows_spl_applications] FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[spl_applications] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[spl_Workflows] CHECK CONSTRAINT [FK_spl_Workflows_spl_applications]
GO
