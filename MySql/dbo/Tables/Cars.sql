CREATE TABLE [dbo].[Cars] (
    [Id]          INT          NOT NULL,
    [BrandId]     INT          NOT NULL,
    [ColorId]     INT          NOT NULL,
    [ModelYear]   NCHAR (10)   NULL,
    [DailyPrice]  DECIMAL (18) NULL,
    [Description] NCHAR (10)   NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([Id] ASC)
);

