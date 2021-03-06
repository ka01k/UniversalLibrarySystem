USE [AppBD]
GO
/****** Object:  Table [dbo].[ORDERS]    Script Date: 27.12.2020 23:24:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PROVIDER_ID] [int] NULL,
	[BOOK_ID] [int] NULL,
	[ORDER_COUNT] [int] NOT NULL,
	[ORDER_DATA] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD FOREIGN KEY([BOOK_ID])
REFERENCES [dbo].[BOOKS] ([ID])
GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD FOREIGN KEY([PROVIDER_ID])
REFERENCES [dbo].[PROVIDERS] ([ID])
GO
