
/****** Object:  Table [dbo].[t_EmailAccounts]    Script Date: 11/15/2014 00:03:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[t_EmailAccounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[UniqueRef] [nvarchar](500) NOT NULL,
	[DisplayName] [nvarchar](500) NOT NULL,
	[Host] [nvarchar](100) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Port] [int] NOT NULL,
	[EnableSsl] [bit] NOT NULL,
	[UseDefaultCredentials] [bit] NOT NULL,
 CONSTRAINT [PK_t_EmailAccounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[t_EmailAccounts] ADD  CONSTRAINT [DF_t_EmailAccounts_EnableSsl]  DEFAULT ((0)) FOR [EnableSsl]
GO

ALTER TABLE [dbo].[t_EmailAccounts] ADD  CONSTRAINT [DF_t_EmailAccounts_UseDefaultCredentials]  DEFAULT ((0)) FOR [UseDefaultCredentials]
GO

