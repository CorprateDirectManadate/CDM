CREATE TABLE [dbo].[AuditSections]
(
[Id] [int] NOT NULL IDENTITY(1, 1),
[Name] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuditSections] ADD CONSTRAINT [PK_AuditSection] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuditSections] ADD CONSTRAINT [IX_AuditSection_Name] UNIQUE NONCLUSTERED  ([Name]) ON [PRIMARY]
GO

CREATE TABLE [dbo].[AuditActions]
(
[Id] [int] NOT NULL IDENTITY(1, 1),
[Name] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[AuditSectionId] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuditActions] ADD CONSTRAINT [PK_AuditAction] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuditActions] ADD CONSTRAINT [IX_AuditAction_Name] UNIQUE NONCLUSTERED  ([Name]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuditActions] ADD CONSTRAINT [FK_AuditAction_AuditSection] FOREIGN KEY ([AuditSectionId]) REFERENCES [dbo].[AuditSections] ([Id]) ON DELETE CASCADE
GO
CREATE TABLE [dbo].[AuditTrails]
(
[Id] [int] NOT NULL IDENTITY(1, 1),
[UserId] [uniqueidentifier] NOT NULL,
[AuditActionId] [int] NOT NULL,
[Details] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[TimeStamp] [datetime] NOT NULL,
[LastEditDate] [datetime] NOT NULL CONSTRAINT [DF_AuditTrail_LastEditDate] DEFAULT (getdate()),
[UserIp] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[OtherRefId] [varchar] (500) NULL,
[Medium] [varchar] (500) NULL

) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuditTrails] ADD CONSTRAINT [PK_AuditTrail] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AuditTrails] ADD CONSTRAINT [FK_AuditTrail_aspnet_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
ALTER TABLE [dbo].[AuditTrails] ADD CONSTRAINT [FK_AuditTrail_AuditAction] FOREIGN KEY ([AuditActionId]) REFERENCES [dbo].[AuditActions] ([Id])
GO
ALTER TABLE dbo.AuditTrails ADD BrowserName NVARCHAR(100)

go
ALTER TABLE dbo.AuditTrails ADD IsMobile BIT DEFAULT 0
GO
ALTER TABLE dbo.AuditTrails DROP COLUMN Medium
GO
ALTER TABLE dbo.AuditTrails ADD Source NVARCHAR(100)
GO
