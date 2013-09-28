
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/28/2013 17:38:43
-- Generated from EDMX file: C:\Projects\NCRSN\NCRSN\NCRSNModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [NCRSNTest];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clubs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clubs];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[Comments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comments];
GO
IF OBJECT_ID(N'[dbo].[EventLikeDislikes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventLikeDislikes];
GO
IF OBJECT_ID(N'[dbo].[ClubSubscribes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubSubscribes];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clubs'
CREATE TABLE [dbo].[Clubs] (
    [Club_Id] int IDENTITY(1,1) NOT NULL,
    [Club_Name] nvarchar(max)  NOT NULL,
    [Club_Description] nvarchar(max)  NOT NULL,
    [Club_Moderator] int  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Event_Id] int IDENTITY(1,1) NOT NULL,
    [Event_Title] nvarchar(max)  NOT NULL,
    [Event_Description] nvarchar(max)  NOT NULL,
    [Event_Moderator] int  NOT NULL,
    [Event_Club_Id] int  NOT NULL,
    [Event_Likes] decimal(18,0)  NOT NULL,
    [Event_Dislikes] decimal(18,0)  NOT NULL,
    [Event_Venue] nvarchar(max)  NOT NULL,
    [Event_Date] datetime  NOT NULL,
    [Clubs_Club_Id] int  NOT NULL
);
GO

-- Creating table 'Comments'
CREATE TABLE [dbo].[Comments] (
    [Comment_Id] int IDENTITY(1,1) NOT NULL,
    [Comment_Type] bit  NOT NULL,
    [Comment_Parent_Id] nvarchar(max)  NOT NULL,
    [Comment_User_Id] nvarchar(max)  NOT NULL,
    [Comment_Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EventLikeDislikes'
CREATE TABLE [dbo].[EventLikeDislikes] (
    [EventLikeDislike_Id] int IDENTITY(1,1) NOT NULL,
    [EventLikeDislike_Event_Id] int  NOT NULL,
    [EventLikeDislike_User_Id] int  NOT NULL,
    [EventLikeDislike_Like] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'ClubSubscribes'
CREATE TABLE [dbo].[ClubSubscribes] (
    [ClubSubscribe_Id] int IDENTITY(1,1) NOT NULL,
    [ClubSubscribe_Club_Id] int  NOT NULL,
    [ClubSubscribe_User_Id] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [User_Id] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Club_Id] in table 'Clubs'
ALTER TABLE [dbo].[Clubs]
ADD CONSTRAINT [PK_Clubs]
    PRIMARY KEY CLUSTERED ([Club_Id] ASC);
GO

-- Creating primary key on [Event_Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Event_Id] ASC);
GO

-- Creating primary key on [Comment_Id] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [PK_Comments]
    PRIMARY KEY CLUSTERED ([Comment_Id] ASC);
GO

-- Creating primary key on [EventLikeDislike_Id] in table 'EventLikeDislikes'
ALTER TABLE [dbo].[EventLikeDislikes]
ADD CONSTRAINT [PK_EventLikeDislikes]
    PRIMARY KEY CLUSTERED ([EventLikeDislike_Id] ASC);
GO

-- Creating primary key on [ClubSubscribe_Id] in table 'ClubSubscribes'
ALTER TABLE [dbo].[ClubSubscribes]
ADD CONSTRAINT [PK_ClubSubscribes]
    PRIMARY KEY CLUSTERED ([ClubSubscribe_Id] ASC);
GO

-- Creating primary key on [User_Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([User_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Clubs_Club_Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_EventClubs]
    FOREIGN KEY ([Clubs_Club_Id])
    REFERENCES [dbo].[Clubs]
        ([Club_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EventClubs'
CREATE INDEX [IX_FK_EventClubs]
ON [dbo].[Events]
    ([Clubs_Club_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------