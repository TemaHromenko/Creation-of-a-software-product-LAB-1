CREATE TABLE [dbo].[INDUSTRY] (
    [Id]        INT         IDENTITY (1, 1) NOT NULL,
    [IND_CODE]  TEXT NOT NULL,
    [IND_NAME]  TEXT        NULL,
    [LONG_NAME] TEXT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

