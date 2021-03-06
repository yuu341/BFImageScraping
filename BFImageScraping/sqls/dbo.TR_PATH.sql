﻿CREATE TABLE [dbo].[TR_PATH] (
    [PATH_ID]    INT            IDENTITY (1, 1) NOT NULL,
    [IMG_ID]     INT            NOT NULL,
    [IMG_PATH]   NVARCHAR (200) NOT NULL,
    [PATH_TYPE]  INT            NOT NULL,
    [ENABLE_FLG] BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([PATH_ID] ASC), 
    CONSTRAINT [FK_TR_PATH_ToTR_IMG] FOREIGN KEY ([IMG_ID]) REFERENCES [TR_IMG]([IMG_ID])
);

