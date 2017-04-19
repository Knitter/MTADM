
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/19/2017 13:59:23
-- Generated from EDMX file: C:\Projectos\DA\MTADM\MTADM\DiagramaEntidades.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DiagramaEntidadesContainer];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ObjetoArea]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Objeto] DROP CONSTRAINT [FK_ObjetoArea];
GO
IF OBJECT_ID(N'[dbo].[FK_AreaMonstro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entidade_Monstro] DROP CONSTRAINT [FK_AreaMonstro];
GO
IF OBJECT_ID(N'[dbo].[FK_AreaPersonagem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entidade_Personagem] DROP CONSTRAINT [FK_AreaPersonagem];
GO
IF OBJECT_ID(N'[dbo].[FK_ModeloMonstroMonstro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entidade_Monstro] DROP CONSTRAINT [FK_ModeloMonstroMonstro];
GO
IF OBJECT_ID(N'[dbo].[FK_MonstroArma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entidade_Monstro] DROP CONSTRAINT [FK_MonstroArma];
GO
IF OBJECT_ID(N'[dbo].[FK_RacaEntidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entidade] DROP CONSTRAINT [FK_RacaEntidade];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonagemArmaPrincipal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entidade_Personagem] DROP CONSTRAINT [FK_PersonagemArmaPrincipal];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonagemArma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entidade_Personagem] DROP CONSTRAINT [FK_PersonagemArma];
GO
IF OBJECT_ID(N'[dbo].[FK_Monstro_inherits_Entidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entidade_Monstro] DROP CONSTRAINT [FK_Monstro_inherits_Entidade];
GO
IF OBJECT_ID(N'[dbo].[FK_Personagem_inherits_Entidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entidade_Personagem] DROP CONSTRAINT [FK_Personagem_inherits_Entidade];
GO
IF OBJECT_ID(N'[dbo].[FK_ModeloMonstro_inherits_Entidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entidade_ModeloMonstro] DROP CONSTRAINT [FK_ModeloMonstro_inherits_Entidade];
GO
IF OBJECT_ID(N'[dbo].[FK_Arma_inherits_Objeto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Objeto_Arma] DROP CONSTRAINT [FK_Arma_inherits_Objeto];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Objeto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Objeto];
GO
IF OBJECT_ID(N'[dbo].[Entidade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Entidade];
GO
IF OBJECT_ID(N'[dbo].[Raca]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Raca];
GO
IF OBJECT_ID(N'[dbo].[Area]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Area];
GO
IF OBJECT_ID(N'[dbo].[Entidade_Monstro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Entidade_Monstro];
GO
IF OBJECT_ID(N'[dbo].[Entidade_Personagem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Entidade_Personagem];
GO
IF OBJECT_ID(N'[dbo].[Entidade_ModeloMonstro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Entidade_ModeloMonstro];
GO
IF OBJECT_ID(N'[dbo].[Objeto_Arma]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Objeto_Arma];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Objetos'
CREATE TABLE [dbo].[Objetos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [AreaId] int  NOT NULL,
    [ModeloObjetoId] int  NOT NULL
);
GO

-- Creating table 'Entidades'
CREATE TABLE [dbo].[Entidades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Vida] int  NOT NULL,
    [Mana] int  NOT NULL,
    [Estamina] int  NOT NULL,
    [Moral] int  NOT NULL,
    [Forca] int  NOT NULL,
    [Inteligencia] int  NOT NULL,
    [Destreza] int  NOT NULL,
    [Genero] nvarchar(max)  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Imagem] nvarchar(max)  NOT NULL,
    [RacaId] int  NOT NULL
);
GO

-- Creating table 'Racas'
CREATE TABLE [dbo].[Racas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Mana] int  NOT NULL,
    [Estamina] int  NOT NULL,
    [Forca] int  NOT NULL,
    [Inteligencia] int  NOT NULL,
    [Destreza] int  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Areas'
CREATE TABLE [dbo].[Areas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [ModeloAreaId] int  NOT NULL
);
GO

-- Creating table 'ModelosObjeto'
CREATE TABLE [dbo].[ModelosObjeto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ModeloAreaSet'
CREATE TABLE [dbo].[ModeloAreaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Entidades_Monstro'
CREATE TABLE [dbo].[Entidades_Monstro] (
    [Maldade] int  NOT NULL,
    [AreaId] int  NOT NULL,
    [ModeloMonstroId] int  NOT NULL,
    [ArmaId] int  NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Entidades_Personagem'
CREATE TABLE [dbo].[Entidades_Personagem] (
    [Biografia] nvarchar(max)  NOT NULL,
    [AreaId] int  NOT NULL,
    [ArmaPrincipalId] int  NULL,
    [ArmaId] int  NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Entidades_ModeloMonstro'
CREATE TABLE [dbo].[Entidades_ModeloMonstro] (
    [Maldade] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Objetos_Arma'
CREATE TABLE [dbo].[Objetos_Arma] (
    [Ataque] int  NOT NULL,
    [Defesa] int  NOT NULL,
    [ModeloArmaId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'ModelosObjeto_ModeloArma'
CREATE TABLE [dbo].[ModelosObjeto_ModeloArma] (
    [Defesa] int  NOT NULL,
    [Ataque] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Objetos'
ALTER TABLE [dbo].[Objetos]
ADD CONSTRAINT [PK_Objetos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Entidades'
ALTER TABLE [dbo].[Entidades]
ADD CONSTRAINT [PK_Entidades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Racas'
ALTER TABLE [dbo].[Racas]
ADD CONSTRAINT [PK_Racas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Areas'
ALTER TABLE [dbo].[Areas]
ADD CONSTRAINT [PK_Areas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModelosObjeto'
ALTER TABLE [dbo].[ModelosObjeto]
ADD CONSTRAINT [PK_ModelosObjeto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModeloAreaSet'
ALTER TABLE [dbo].[ModeloAreaSet]
ADD CONSTRAINT [PK_ModeloAreaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Entidades_Monstro'
ALTER TABLE [dbo].[Entidades_Monstro]
ADD CONSTRAINT [PK_Entidades_Monstro]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Entidades_Personagem'
ALTER TABLE [dbo].[Entidades_Personagem]
ADD CONSTRAINT [PK_Entidades_Personagem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Entidades_ModeloMonstro'
ALTER TABLE [dbo].[Entidades_ModeloMonstro]
ADD CONSTRAINT [PK_Entidades_ModeloMonstro]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Objetos_Arma'
ALTER TABLE [dbo].[Objetos_Arma]
ADD CONSTRAINT [PK_Objetos_Arma]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ModelosObjeto_ModeloArma'
ALTER TABLE [dbo].[ModelosObjeto_ModeloArma]
ADD CONSTRAINT [PK_ModelosObjeto_ModeloArma]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AreaId] in table 'Objetos'
ALTER TABLE [dbo].[Objetos]
ADD CONSTRAINT [FK_ObjetoArea]
    FOREIGN KEY ([AreaId])
    REFERENCES [dbo].[Areas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ObjetoArea'
CREATE INDEX [IX_FK_ObjetoArea]
ON [dbo].[Objetos]
    ([AreaId]);
GO

-- Creating foreign key on [AreaId] in table 'Entidades_Monstro'
ALTER TABLE [dbo].[Entidades_Monstro]
ADD CONSTRAINT [FK_AreaMonstro]
    FOREIGN KEY ([AreaId])
    REFERENCES [dbo].[Areas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AreaMonstro'
CREATE INDEX [IX_FK_AreaMonstro]
ON [dbo].[Entidades_Monstro]
    ([AreaId]);
GO

-- Creating foreign key on [AreaId] in table 'Entidades_Personagem'
ALTER TABLE [dbo].[Entidades_Personagem]
ADD CONSTRAINT [FK_AreaPersonagem]
    FOREIGN KEY ([AreaId])
    REFERENCES [dbo].[Areas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AreaPersonagem'
CREATE INDEX [IX_FK_AreaPersonagem]
ON [dbo].[Entidades_Personagem]
    ([AreaId]);
GO

-- Creating foreign key on [ModeloMonstroId] in table 'Entidades_Monstro'
ALTER TABLE [dbo].[Entidades_Monstro]
ADD CONSTRAINT [FK_ModeloMonstroMonstro]
    FOREIGN KEY ([ModeloMonstroId])
    REFERENCES [dbo].[Entidades_ModeloMonstro]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModeloMonstroMonstro'
CREATE INDEX [IX_FK_ModeloMonstroMonstro]
ON [dbo].[Entidades_Monstro]
    ([ModeloMonstroId]);
GO

-- Creating foreign key on [ArmaId] in table 'Entidades_Monstro'
ALTER TABLE [dbo].[Entidades_Monstro]
ADD CONSTRAINT [FK_MonstroArma]
    FOREIGN KEY ([ArmaId])
    REFERENCES [dbo].[Objetos_Arma]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MonstroArma'
CREATE INDEX [IX_FK_MonstroArma]
ON [dbo].[Entidades_Monstro]
    ([ArmaId]);
GO

-- Creating foreign key on [RacaId] in table 'Entidades'
ALTER TABLE [dbo].[Entidades]
ADD CONSTRAINT [FK_RacaEntidade]
    FOREIGN KEY ([RacaId])
    REFERENCES [dbo].[Racas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RacaEntidade'
CREATE INDEX [IX_FK_RacaEntidade]
ON [dbo].[Entidades]
    ([RacaId]);
GO

-- Creating foreign key on [ArmaPrincipalId] in table 'Entidades_Personagem'
ALTER TABLE [dbo].[Entidades_Personagem]
ADD CONSTRAINT [FK_PersonagemArmaPrincipal]
    FOREIGN KEY ([ArmaPrincipalId])
    REFERENCES [dbo].[Objetos_Arma]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonagemArmaPrincipal'
CREATE INDEX [IX_FK_PersonagemArmaPrincipal]
ON [dbo].[Entidades_Personagem]
    ([ArmaPrincipalId]);
GO

-- Creating foreign key on [ArmaId] in table 'Entidades_Personagem'
ALTER TABLE [dbo].[Entidades_Personagem]
ADD CONSTRAINT [FK_PersonagemArma]
    FOREIGN KEY ([ArmaId])
    REFERENCES [dbo].[Objetos_Arma]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonagemArma'
CREATE INDEX [IX_FK_PersonagemArma]
ON [dbo].[Entidades_Personagem]
    ([ArmaId]);
GO

-- Creating foreign key on [ModeloObjetoId] in table 'Objetos'
ALTER TABLE [dbo].[Objetos]
ADD CONSTRAINT [FK_ModeloObjetoObjeto]
    FOREIGN KEY ([ModeloObjetoId])
    REFERENCES [dbo].[ModelosObjeto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModeloObjetoObjeto'
CREATE INDEX [IX_FK_ModeloObjetoObjeto]
ON [dbo].[Objetos]
    ([ModeloObjetoId]);
GO

-- Creating foreign key on [ModeloArmaId] in table 'Objetos_Arma'
ALTER TABLE [dbo].[Objetos_Arma]
ADD CONSTRAINT [FK_ModeloArmaArma]
    FOREIGN KEY ([ModeloArmaId])
    REFERENCES [dbo].[ModelosObjeto_ModeloArma]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModeloArmaArma'
CREATE INDEX [IX_FK_ModeloArmaArma]
ON [dbo].[Objetos_Arma]
    ([ModeloArmaId]);
GO

-- Creating foreign key on [ModeloAreaId] in table 'Areas'
ALTER TABLE [dbo].[Areas]
ADD CONSTRAINT [FK_ModeloAreaArea]
    FOREIGN KEY ([ModeloAreaId])
    REFERENCES [dbo].[ModeloAreaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModeloAreaArea'
CREATE INDEX [IX_FK_ModeloAreaArea]
ON [dbo].[Areas]
    ([ModeloAreaId]);
GO

-- Creating foreign key on [Id] in table 'Entidades_Monstro'
ALTER TABLE [dbo].[Entidades_Monstro]
ADD CONSTRAINT [FK_Monstro_inherits_Entidade]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Entidades]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Entidades_Personagem'
ALTER TABLE [dbo].[Entidades_Personagem]
ADD CONSTRAINT [FK_Personagem_inherits_Entidade]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Entidades]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Entidades_ModeloMonstro'
ALTER TABLE [dbo].[Entidades_ModeloMonstro]
ADD CONSTRAINT [FK_ModeloMonstro_inherits_Entidade]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Entidades]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Objetos_Arma'
ALTER TABLE [dbo].[Objetos_Arma]
ADD CONSTRAINT [FK_Arma_inherits_Objeto]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Objetos]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'ModelosObjeto_ModeloArma'
ALTER TABLE [dbo].[ModelosObjeto_ModeloArma]
ADD CONSTRAINT [FK_ModeloArma_inherits_ModeloObjeto]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[ModelosObjeto]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------