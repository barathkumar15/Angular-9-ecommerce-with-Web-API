//Step 1: create database ecommerce

//Step 2: USE [ecommerce]

//Step 3: create table 
 
GO
/****** Object:  Table [dbo].[PRODUCT_LIST]    Script Date: 6/27/2020 10:15:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PRODUCT_LIST](
	[PRODUCT_ID] [int] IDENTITY(1,1) NOT NULL,
	[PRODUCT_NAME] [nvarchar](100) NULL,
	[PRODUCT_DESCRIPTION] [nvarchar](max) NULL,
	[QUANTITY] [int] NULL,
	[AMOUNT] [int] NULL,
	[IMAGEURL] [nvarchar](max) NULL,
	[CATEGORY_ID] [int] NULL,
 CONSTRAINT [PK_PRODUCT_LIST] PRIMARY KEY CLUSTERED 
(
	[PRODUCT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

//Step 4: use this insert query for product list 


INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('ZARA','Leaf Printed Shirt With patch Pocket',5,999,'https://assets.ajio.com/medias/sys_master/root/h29/h58/16716157091870/rosso_fem_grey_classic_leaf_print_shirt_with_patch_pocket.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('DERBY','Crew-Neck T-shirt with Contrast Stripes',12,2999,'https://assets.ajio.com/medias/sys_master/root/h79/h09/15737956597790/-1117Wx1400H-461085130-blue-MODEL.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('ZARA','Shirt with Curved Hem',23,1999,'https://assets.ajio.com/medias/sys_master/root/ha2/hf2/15652237672478/zavlin_blue_classic_shirt_with_curved_hem.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('JANASYA','Floral A-line Kurta Set',2,990,'https://assets.ajio.com/medias/sys_master/root/hb9/h94/15741667147806/-1117Wx1400H-461117381-blue-MODEL.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('HUBBERHOLME','Flat-Front Mid-Rise Slim Trousers',5,499,'https://assets.ajio.com/medias/sys_master/root/hfe/h12/11307771428894/-1117Wx1400H-460204771-khaki-MODEL5.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('AVAASA MIX N MATCH','Printed Straight Kurta',12,599,'https://assets.ajio.com/medias/sys_master/root/h37/h49/15624273395742/-1117Wx1400H-441057625-lime-MODEL3.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('AJIO','Acid-Wash Denim Jacket with Flap Pockets',23,1299,'https://assets.ajio.com/medias/sys_master/root/h1e/h76/15772746154014/-1117Wx1400H-460532193-indigo-MODEL.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('KG FRENDZ','Cold-Shoulder Top with Sequinned Panel',2,890,'https://assets.ajio.com/medias/sys_master/root/h42/hf5/15130696548382/-1117Wx1400H-441039391-lilac-MODEL2.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('KG FRENDZ','Printed Crew-Neck T-shirt with Embellishments',2,670,'https://assets.ajio.com/medias/sys_master/root/h5a/hb4/13613221478430/-1117Wx1400H-440995944-greymelange-MODEL.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('JANASYA','Printed Shirt with Patch Pocket',2,590,'https://assets.ajio.com/medias/sys_master/root/h19/hd5/13694968922142/-473Wx593H-441007279-blue-MODEL.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('NETPLAY','Printed Shirt with Patch Pocket',5,489,'https://assets.ajio.com/medias/sys_master/root/h9c/h4e/13694952439838/-1117Wx1400H-441007278-pink-MODEL.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('FUSION','Floral Print Straight Kurti with Band Colla',12,799,'https://assets.ajio.com/medias/sys_master/root/hbd/h0e/14719780323358/-1117Wx1400H-441033914-black-MODEL.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('LEVIS TEAMSPIRIT','Reflective Print Joggers with Drawstring',22,899,'https://assets.ajio.com/medias/sys_master/root/h47/h57/15129537151006/-1117Wx1400H-441034838-black-MODEL2.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('PUMA BRAVE SOUL','Washed Panelled Jacket with Flap Pockets',2,1490,'https://assets.ajio.com/medias/sys_master/root/h2c/h09/15071290916894/-1117Wx1400H-460438128-blue-MODEL.jpg',1)
GO
INSERT [dbo].[PRODUCT_LIST] ([PRODUCT_NAME], [PRODUCT_DESCRIPTION],[QUANTITY],[AMOUNT],[IMAGEURL],[CATEGORY_ID]) VALUES ('PUMA','Propel 3D MU IDP Running Sports Shoes',2,1870,'https://assets.ajio.com/medias/sys_master/root/hb6/hd1/15759726182430/-1117Wx1400H-460484289-maroon-MODEL.jpg',1)
GO


