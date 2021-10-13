CREATE TABLE [dbo].[Colors] (
    [ColorId]   INT        NOT NULL,
    [ColorName] NCHAR (10) NULL,
    CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED ([ColorId] ASC)
);


GO
CREATE NONCLUSTERED INDEX [ColorName]
    ON [dbo].[Colors]([ColorName] ASC);

