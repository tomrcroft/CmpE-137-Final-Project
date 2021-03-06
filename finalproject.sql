USE [FinalProject]
GO
/****** Object:  Table [dbo].[FavoritePlaces]    Script Date: 12/4/2013 6:34:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FavoritePlaces](
	[UserID] [nvarchar](50) NOT NULL,
	[PoiID] [bigint] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[POIs]    Script Date: 11/22/2013 3:03:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POIs](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [ntext] NULL,
 CONSTRAINT [PK_POIs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 11/22/2013 3:03:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [nvarchar](50) NULL,
	[PoiIDs] [bigint] NULL,
	[comment] [ntext] NULL,
	[rating] [int] NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/22/2013 3:03:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Birthdate] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/*bootstrap db*/
INSERT INTO POIs(Name,Description) VALUES ('Student Union', 'Food Court. Bowling. Student Store. Transportation Services');
INSERT INTO POIs(Name,Description) VALUES ('Engineering Building', 'Learn some Engineering');
INSERT INTO Users VALUES('Username1','password','Name','Email','Gender','Birthdate');
INSERT INTO Users VALUES('Username2','password','Alex','alex@alex.com','male','8/31/1986');
INSERT INTO Reviews(UserID,PoiIDs,comment,rating) VALUES('Username1',1,'Cool place',5);
INSERT INTO Reviews(UserID,PoiIDs,comment,rating) VALUES('Username2',1,'Terrible place',1);