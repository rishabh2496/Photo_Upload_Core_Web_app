SET IDENTITY_INSERT [dbo].[Viewer] ON
INSERT INTO [dbo].[Viewer] ([Id], [Name], [Email]) VALUES (1, N'Jack Davis', N'jkdavis@photos.com')
INSERT INTO [dbo].[Viewer] ([Id], [Name], [Email]) VALUES (2, N'Helen Smith', N'helen@photos.com')
SET IDENTITY_INSERT [dbo].[Viewer] OFF
SET IDENTITY_INSERT [dbo].[Uploader] ON
INSERT INTO [dbo].[Uploader] ([Id], [Name], [Email]) VALUES (1, N'Harry Simpson', N'harry@photos.com')
INSERT INTO [dbo].[Uploader] ([Id], [Name], [Email]) VALUES (2, N'David Fisher', N'fisher.d@photos.com')
SET IDENTITY_INSERT [dbo].[Uploader] OFF
SET IDENTITY_INSERT [dbo].[Photo] ON
INSERT INTO [dbo].[Photo] ([Id], [Caption], [ImageURL], [UploaderId]) VALUES (1, N'Winter Mountains', N'mountains.jpg', 1)
INSERT INTO [dbo].[Photo] ([Id], [Caption], [ImageURL], [UploaderId]) VALUES (2, N'Waterfalls in the Tropics', N'Waterfall.jpg', 2)
INSERT INTO [dbo].[Photo] ([Id], [Caption], [ImageURL], [UploaderId]) VALUES (3, N'Summer flowers', N'flowers.jpg', 1)
INSERT INTO [dbo].[Photo] ([Id], [Caption], [ImageURL], [UploaderId]) VALUES (4, N'Green Valley', N'Valley.jpg', 2)
SET IDENTITY_INSERT [dbo].[Photo] OFF
SET IDENTITY_INSERT [dbo].[Comment] ON
INSERT INTO [dbo].[Comment] ([Id], [Content], [PhotoId], [ViewerId]) VALUES (1, N'So Amazing the one of the  best  snaps', 1, 2)
INSERT INTO [dbo].[Comment] ([Id], [Content], [PhotoId], [ViewerId]) VALUES (2, N'Best professional shots ever came across!', 3, 1)
SET IDENTITY_INSERT [dbo].[Comment] OFF
