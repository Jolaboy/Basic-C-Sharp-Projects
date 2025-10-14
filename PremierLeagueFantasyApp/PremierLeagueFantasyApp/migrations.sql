IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251013151717_InitialCreate'
)
BEGIN
    CREATE TABLE [Players] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Team] nvarchar(max) NOT NULL,
        [Position] nvarchar(max) NOT NULL,
        [Goals] int NOT NULL,
        [Assists] int NOT NULL,
        [CleanSheets] int NOT NULL,
        [TotalPoints] int NOT NULL,
        [Price] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_Players] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251013151717_InitialCreate'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Assists', N'CleanSheets', N'Goals', N'Name', N'Position', N'Price', N'Team', N'TotalPoints') AND [object_id] = OBJECT_ID(N'[Players]'))
        SET IDENTITY_INSERT [Players] ON;
    EXEC(N'INSERT INTO [Players] ([Id], [Assists], [CleanSheets], [Goals], [Name], [Position], [Price], [Team], [TotalPoints])
    VALUES (1, 5, 0, 27, N''Haaland'', N''Forward'', 14.0, N''MCI'', 250),
    (2, 12, 0, 18, N''Salah'', N''Midfielder'', 13.0, N''LIV'', 230),
    (3, 10, 15, 1, N''Trippier'', N''Defender'', 6.5, N''NEW'', 200),
    (4, 10, 0, 14, N''Saka'', N''Midfielder'', 9.0, N''ARS'', 210)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Assists', N'CleanSheets', N'Goals', N'Name', N'Position', N'Price', N'Team', N'TotalPoints') AND [object_id] = OBJECT_ID(N'[Players]'))
        SET IDENTITY_INSERT [Players] OFF;
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251013151717_InitialCreate'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20251013151717_InitialCreate', N'9.0.9');
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251013153554_FixPricePrecision'
)
BEGIN
    DECLARE @var sysname;
    SELECT @var = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Players]') AND [c].[name] = N'Price');
    IF @var IS NOT NULL EXEC(N'ALTER TABLE [Players] DROP CONSTRAINT [' + @var + '];');
    ALTER TABLE [Players] ALTER COLUMN [Price] decimal(5,2) NOT NULL;
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20251013153554_FixPricePrecision'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20251013153554_FixPricePrecision', N'9.0.9');
END;

COMMIT;
GO

