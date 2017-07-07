CREATE TABLE [dbo].[AdmitadProgramsTable]
(
	[ProgramId] INT NOT NULL PRIMARY KEY, 
    [AccountName] [dbo].[AdmitadAccountID] NOT NULL, 
    [ProgramName] VARCHAR(100) NOT NULL, 
    [FeedCSV] TEXT NULL, 
    [FeedXML] TEXT NULL, 
    CONSTRAINT [FK_AdmitadProgramsTable_ToTable] FOREIGN KEY ([AccountName]) REFERENCES [dbo].[AdmitadAccountsTable]([AccountName]) ON DELETE CASCADE ON UPDATE CASCADE
)

GO

CREATE INDEX [IX_AdmitadProgramsTable_AccountName] ON [dbo].[AdmitadProgramsTable] ([AccountName])

GO

CREATE UNIQUE INDEX [IX_AdmitadProgramsTable_ ProgramName] ON [dbo].[AdmitadProgramsTable] ([AccountName], [ProgramName])
