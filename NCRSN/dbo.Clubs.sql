CREATE TABLE [dbo].[Clubs] (
    [Club_Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Club_Name]          NVARCHAR (MAX) NOT NULL,
    [Club_Description]   NVARCHAR (MAX) NOT NULL,
    [Club_Moderator]     INT            ,
    [Comment_Comment_Id] INT            ,
    CONSTRAINT [PK_Clubs] PRIMARY KEY CLUSTERED ([Club_Id] ASC),
    CONSTRAINT [FK_CommentsClubs] FOREIGN KEY ([Comment_Comment_Id]) REFERENCES [dbo].[Comments] ([Comment_Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_CommentsClubs]
    ON [dbo].[Clubs]([Comment_Comment_Id] ASC);

