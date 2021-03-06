USE [AppBD]
GO
/****** Object:  Table [dbo].[CITIES]    Script Date: 27.12.2020 23:24:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CITIES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CITYNAME] [nvarchar](30) NOT NULL,
	[COUNTRYID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CITIES]  WITH CHECK ADD FOREIGN KEY([COUNTRYID])
REFERENCES [dbo].[COUNTRIES] ([ID])
GO
