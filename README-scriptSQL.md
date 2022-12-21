--First of all launch a script which will create database with table so the project can work.

USE [master]
GO
CREATE DATABASE CampaignDb
GO
USE [CampaignDb]
GO
/****** Object:  Table [dbo].[Campaigns]    Script Date: 21.12.2022 22:24:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campaigns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CampaignName] [nvarchar](max) NOT NULL,
	[Keywords] [nvarchar](max) NOT NULL,
	[BidAmount] [decimal](18, 2) NOT NULL,
	[CampaignFund] [decimal](18, 2) NOT NULL,
	[Status] [bit] NOT NULL,
	[Town] [nvarchar](max) NOT NULL,
	[Radius] [int] NOT NULL,
 CONSTRAINT [PK_Campaigns] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Campaigns] ON 

INSERT [dbo].[Campaigns] ([Id], [CampaignName], [Keywords], [BidAmount], [CampaignFund], [Status], [Town], [Radius]) VALUES (1, N'Jump in', N'xbox', CAST(1500.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)), 1, N'Gdańsk', 150)
INSERT [dbo].[Campaigns] ([Id], [CampaignName], [Keywords], [BidAmount], [CampaignFund], [Status], [Town], [Radius]) VALUES (2, N'just do it', N'nike', CAST(5000.00 AS Decimal(18, 2)), CAST(25000.00 AS Decimal(18, 2)), 0, N'Cracow', 25)
INSERT [dbo].[Campaigns] ([Id], [CampaignName], [Keywords], [BidAmount], [CampaignFund], [Status], [Town], [Radius]) VALUES (3, N'The Company for Women', N'avon', CAST(1000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), 1, N'Rzeszów', 50)
INSERT [dbo].[Campaigns] ([Id], [CampaignName], [Keywords], [BidAmount], [CampaignFund], [Status], [Town], [Radius]) VALUES (4, N'Impossible Is Nothing', N'adidas', CAST(2137.00 AS Decimal(18, 2)), CAST(42000.00 AS Decimal(18, 2)), 1, N'Cracow', 125)
INSERT [dbo].[Campaigns] ([Id], [CampaignName], [Keywords], [BidAmount], [CampaignFund], [Status], [Town], [Radius]) VALUES (5, N'Sheer Driving Pleasure', N'bmw', CAST(1111.00 AS Decimal(18, 2)), CAST(11000.00 AS Decimal(18, 2)), 0, N'Poznań', 300)
INSERT [dbo].[Campaigns] ([Id], [CampaignName], [Keywords], [BidAmount], [CampaignFund], [Status], [Town], [Radius]) VALUES (6, N'Think Different', N'apple', CAST(4444.00 AS Decimal(18, 2)), CAST(40440.00 AS Decimal(18, 2)), 1, N'Cracow', 250)
INSERT [dbo].[Campaigns] ([Id], [CampaignName], [Keywords], [BidAmount], [CampaignFund], [Status], [Town], [Radius]) VALUES (7, N'Buy it. Sell it. Love it', N'eBay', CAST(1420.50 AS Decimal(18, 2)), CAST(9340.24 AS Decimal(18, 2)), 1, N'Gdańsk', 35)
SET IDENTITY_INSERT [dbo].[Campaigns] OFF
GO
