
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/17/2017 18:51:10
-- Generated from EDMX file: S:\2AINFO1\Semester 2\C# & .NET\Project\HealthcareManagementSystem\HealthcareManagementSystem\HealthcareManagementSystemDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HealthcareManagementSystemDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Doctor_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Doctor] DROP CONSTRAINT [FK_Doctor_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Patient_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Patient] DROP CONSTRAINT [FK_Patient_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Appointments] DROP CONSTRAINT [FK_PatientAppointment];
GO
IF OBJECT_ID(N'[dbo].[FK_Secretary_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_Secretary] DROP CONSTRAINT [FK_Secretary_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_SuperUser_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users_SuperUser] DROP CONSTRAINT [FK_SuperUser_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_UserCities];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Appointments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Appointments];
GO
IF OBJECT_ID(N'[dbo].[Cities1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities1];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Users_Doctor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Doctor];
GO
IF OBJECT_ID(N'[dbo].[Users_Patient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Patient];
GO
IF OBJECT_ID(N'[dbo].[Users_Secretary]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_Secretary];
GO
IF OBJECT_ID(N'[dbo].[Users_SuperUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users_SuperUser];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [IdUser] int IDENTITY(1,1) NOT NULL,
    [Fisrtname] nvarchar(max)  NOT NULL,
    [Lastname] nvarchar(max)  NOT NULL,
    [DateOfBirth] datetime  NOT NULL,
    [IsSuperUser] bit  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [Role] nvarchar(max)  NOT NULL,
    [HashedPassword] varchar(max)  NOT NULL,
    [CIN] nvarchar(max)  NOT NULL,
    [City_IdCity] int  NOT NULL
);
GO

-- Creating table 'Appointments'
CREATE TABLE [dbo].[Appointments] (
    [IdAppointment] int IDENTITY(1,1) NOT NULL,
    [DateAndTime] datetime  NOT NULL,
    [Cost] nvarchar(max)  NOT NULL,
    [NatureOfAct] nvarchar(max)  NOT NULL,
    [Patient_IdUser] int  NOT NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [IdCity] int IDENTITY(1,1) NOT NULL,
    [CityName] nvarchar(max)  NOT NULL,
    [PostalCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users_Patient'
CREATE TABLE [dbo].[Users_Patient] (
    [Profession] nvarchar(max)  NULL,
    [LastVisit] nvarchar(max)  NOT NULL,
    [IdUser] int  NOT NULL
);
GO

-- Creating table 'Users_SuperUser'
CREATE TABLE [dbo].[Users_SuperUser] (
    [SuperHashedPassword] varchar(max)  NOT NULL,
    [IdUser] int  NOT NULL
);
GO

-- Creating table 'Users_Doctor'
CREATE TABLE [dbo].[Users_Doctor] (
    [Speciality] nvarchar(max)  NOT NULL,
    [IdUser] int  NOT NULL
);
GO

-- Creating table 'Users_Secretary'
CREATE TABLE [dbo].[Users_Secretary] (
    [ExperienceYears] int  NOT NULL,
    [IdUser] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdUser] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdAppointment] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [PK_Appointments]
    PRIMARY KEY CLUSTERED ([IdAppointment] ASC);
GO

-- Creating primary key on [IdCity] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([IdCity] ASC);
GO

-- Creating primary key on [IdUser] in table 'Users_Patient'
ALTER TABLE [dbo].[Users_Patient]
ADD CONSTRAINT [PK_Users_Patient]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdUser] in table 'Users_SuperUser'
ALTER TABLE [dbo].[Users_SuperUser]
ADD CONSTRAINT [PK_Users_SuperUser]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdUser] in table 'Users_Doctor'
ALTER TABLE [dbo].[Users_Doctor]
ADD CONSTRAINT [PK_Users_Doctor]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdUser] in table 'Users_Secretary'
ALTER TABLE [dbo].[Users_Secretary]
ADD CONSTRAINT [PK_Users_Secretary]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Patient_IdUser] in table 'Appointments'
ALTER TABLE [dbo].[Appointments]
ADD CONSTRAINT [FK_PatientAppointment]
    FOREIGN KEY ([Patient_IdUser])
    REFERENCES [dbo].[Users_Patient]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientAppointment'
CREATE INDEX [IX_FK_PatientAppointment]
ON [dbo].[Appointments]
    ([Patient_IdUser]);
GO

-- Creating foreign key on [City_IdCity] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_UserCities]
    FOREIGN KEY ([City_IdCity])
    REFERENCES [dbo].[Cities]
        ([IdCity])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCities'
CREATE INDEX [IX_FK_UserCities]
ON [dbo].[Users]
    ([City_IdCity]);
GO

-- Creating foreign key on [IdUser] in table 'Users_Patient'
ALTER TABLE [dbo].[Users_Patient]
ADD CONSTRAINT [FK_Patient_inherits_User]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[Users]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdUser] in table 'Users_SuperUser'
ALTER TABLE [dbo].[Users_SuperUser]
ADD CONSTRAINT [FK_SuperUser_inherits_User]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[Users]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdUser] in table 'Users_Doctor'
ALTER TABLE [dbo].[Users_Doctor]
ADD CONSTRAINT [FK_Doctor_inherits_User]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[Users]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdUser] in table 'Users_Secretary'
ALTER TABLE [dbo].[Users_Secretary]
ADD CONSTRAINT [FK_Secretary_inherits_User]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[Users]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------