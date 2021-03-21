
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/22/2021 00:07:11
-- Generated from EDMX file: C:\Users\Timothee\source\repos\GestionClient\ClientModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [gestclient];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Code] int IDENTITY(1,1) NOT NULL,
    [Nom] varchar(100)  NULL,
    [Prenom] varchar(100)  NULL,
    [Telephone] varchar(100)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Code] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Code] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------