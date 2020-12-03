CREATE TABLE [dbo].[Vets] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [FullName]        NVARCHAR (70)  NOT NULL,
    [Speciality]      NVARCHAR (500) NULL,
    [YearsExperience] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

