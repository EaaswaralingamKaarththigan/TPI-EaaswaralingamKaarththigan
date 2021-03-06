USE [master]
GO
/****** Object:  Database [TPI]    Script Date: 30.05.2022 14:33:50 ******/
CREATE DATABASE [TPI]
 CONTAINMENT = NONE
GO
ALTER DATABASE [TPI] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TPI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TPI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TPI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TPI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TPI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TPI] SET ARITHABORT OFF 
GO
ALTER DATABASE [TPI] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TPI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TPI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TPI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TPI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TPI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TPI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TPI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TPI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TPI] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TPI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TPI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TPI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TPI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TPI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TPI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TPI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TPI] SET RECOVERY FULL 
GO
ALTER DATABASE [TPI] SET  MULTI_USER 
GO
ALTER DATABASE [TPI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TPI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TPI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TPI] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TPI] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TPI] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TPI', N'ON'
GO
ALTER DATABASE [TPI] SET QUERY_STORE = OFF
GO
USE [TPI]
GO
/****** Object:  Table [dbo].[tblcanalchatprive]    Script Date: 30.05.2022 14:33:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcanalchatprive](
	[Id_CanalChatPrive] [int] IDENTITY(1,1) NOT NULL,
	[Createur] [int] NULL,
	[Personne2] [int] NULL,
	[Personne3] [int] NULL,
 CONSTRAINT [PK_tblcanalchatprive] PRIMARY KEY CLUSTERED 
(
	[Id_CanalChatPrive] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblcanalchatpublic]    Script Date: 30.05.2022 14:33:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcanalchatpublic](
	[Id_CanalChatPublic] [int] NULL,
	[Créateur] [int] NULL,
	[Personne2] [int] NULL,
	[Personne3] [int] NULL,
	[Personne4] [int] NULL,
	[Personne5] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblcompteemploye]    Script Date: 30.05.2022 14:33:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcompteemploye](
	[Id_Compte] [int] IDENTITY(1,1) NOT NULL,
	[Id_Employe] [int] NULL,
	[Id_TypeCompte] [int] NULL,
	[Pseudonyme] [nvarchar](max) NULL,
	[MotDePasse] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblcompteemploye] PRIMARY KEY CLUSTERED 
(
	[Id_Compte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblemploye]    Script Date: 30.05.2022 14:33:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblemploye](
	[Id_Employe] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](max) NULL,
	[Prenom] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblemploye] PRIMARY KEY CLUSTERED 
(
	[Id_Employe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblmessagechatprive]    Script Date: 30.05.2022 14:33:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblmessagechatprive](
	[Id_MessageChatPrive] [int] IDENTITY(1,1) NOT NULL,
	[Id_CanalChatPrive] [int] NULL,
	[Id_Employe] [int] NULL,
	[DateEnvoi] [nvarchar](max) NULL,
	[ContenuMessage] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblmessagechatprive] PRIMARY KEY CLUSTERED 
(
	[Id_MessageChatPrive] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblmessagechatpublic]    Script Date: 30.05.2022 14:33:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblmessagechatpublic](
	[Id_MessageChatPublic] [int] IDENTITY(1,1) NOT NULL,
	[Id_Employe] [int] NULL,
	[DateEnvoi] [nvarchar](max) NULL,
	[ContenuMessage] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblmessagechatpublic] PRIMARY KEY CLUSTERED 
(
	[Id_MessageChatPublic] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbltypecompte]    Script Date: 30.05.2022 14:33:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbltypecompte](
	[Id_TypeCompte] [int] NOT NULL,
	[TypeCompte] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbltypecompte] PRIMARY KEY CLUSTERED 
(
	[Id_TypeCompte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblcanalchatprive] ON 

INSERT [dbo].[tblcanalchatprive] ([Id_CanalChatPrive], [Createur], [Personne2], [Personne3]) VALUES (1, 1, 2, 3)
INSERT [dbo].[tblcanalchatprive] ([Id_CanalChatPrive], [Createur], [Personne2], [Personne3]) VALUES (2, 1, 1, 2)
INSERT [dbo].[tblcanalchatprive] ([Id_CanalChatPrive], [Createur], [Personne2], [Personne3]) VALUES (3, 1, 3, 2)
SET IDENTITY_INSERT [dbo].[tblcanalchatprive] OFF
GO
SET IDENTITY_INSERT [dbo].[tblcompteemploye] ON 

INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (1, 1, 2, N'FBN', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (2, 2, 1, N'EPU', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (3, 3, 3, N'EAE', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (4, 4, 3, N'ALN', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (5, 5, 1, N'SBE', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (6, 6, 1, N'MVX', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (7, 7, 1, N'CFD', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (8, 8, 1, N'VCT', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (9, 9, 2, N'FBS', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (10, 10, 1, N'ABR', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (11, 11, 1, N'MGN', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (12, 12, 1, N'CPR', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (13, 13, 1, N'BPN', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (14, 14, 1, N'GDR', N'Passw0rd')
INSERT [dbo].[tblcompteemploye] ([Id_Compte], [Id_Employe], [Id_TypeCompte], [Pseudonyme], [MotDePasse]) VALUES (15, 15, 1, N'NLE', N'Passw0rd')
SET IDENTITY_INSERT [dbo].[tblcompteemploye] OFF
GO
SET IDENTITY_INSERT [dbo].[tblemploye] ON 

INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (1, N'Faustin', N'Bergeron')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (2, N'Eliot', N'Primeau')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (3, N'Eugène', N'Alexandre')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (4, N'Auriville', N'Lebrun')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (5, N'Senapus', N'Brunelle')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (6, N'Mercer', N'Veilleux')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (7, N'Charles', N'Ferland')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (8, N'Victorine', N'Chabot')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (9, N'Fabrice', N'Blais')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (10, N'Arianne', N'Bizier')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (11, N'Marine', N'Gauvin')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (12, N'Caroline', N'Parmentier')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (13, N'Brunella', N'Poisson')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (14, N'Gauthier', N'Desnoyer')
INSERT [dbo].[tblemploye] ([Id_Employe], [Nom], [Prenom]) VALUES (15, N'Noelle', N'Laboissonière')
SET IDENTITY_INSERT [dbo].[tblemploye] OFF
GO
SET IDENTITY_INSERT [dbo].[tblmessagechatprive] ON 

INSERT [dbo].[tblmessagechatprive] ([Id_MessageChatPrive], [Id_CanalChatPrive], [Id_Employe], [DateEnvoi], [ContenuMessage]) VALUES (1, 1, 1, N'May 29 2022  8:40PM', N'df')
INSERT [dbo].[tblmessagechatprive] ([Id_MessageChatPrive], [Id_CanalChatPrive], [Id_Employe], [DateEnvoi], [ContenuMessage]) VALUES (4, 1, 1, N'May 29 2022  8:47PM', N'asdf')
INSERT [dbo].[tblmessagechatprive] ([Id_MessageChatPrive], [Id_CanalChatPrive], [Id_Employe], [DateEnvoi], [ContenuMessage]) VALUES (5, 1, 1, N'May 29 2022  8:47PM', N'hello')
INSERT [dbo].[tblmessagechatprive] ([Id_MessageChatPrive], [Id_CanalChatPrive], [Id_Employe], [DateEnvoi], [ContenuMessage]) VALUES (6, 1, 1, N'May 29 2022  8:47PM', N'hi')
INSERT [dbo].[tblmessagechatprive] ([Id_MessageChatPrive], [Id_CanalChatPrive], [Id_Employe], [DateEnvoi], [ContenuMessage]) VALUES (7, 2, 1, N'May 30 2022  3:18AM', N'Hello')
INSERT [dbo].[tblmessagechatprive] ([Id_MessageChatPrive], [Id_CanalChatPrive], [Id_Employe], [DateEnvoi], [ContenuMessage]) VALUES (8, 2, 1, N'May 30 2022  3:18AM', N'Comment ça va')
INSERT [dbo].[tblmessagechatprive] ([Id_MessageChatPrive], [Id_CanalChatPrive], [Id_Employe], [DateEnvoi], [ContenuMessage]) VALUES (9, 3, 1, N'May 30 2022  3:18AM', N'Hi')
INSERT [dbo].[tblmessagechatprive] ([Id_MessageChatPrive], [Id_CanalChatPrive], [Id_Employe], [DateEnvoi], [ContenuMessage]) VALUES (10, 3, 1, N'May 30 2022  3:18AM', N'How are you')
SET IDENTITY_INSERT [dbo].[tblmessagechatprive] OFF
GO
SET IDENTITY_INSERT [dbo].[tblmessagechatpublic] ON 

INSERT [dbo].[tblmessagechatpublic] ([Id_MessageChatPublic], [Id_Employe], [DateEnvoi], [ContenuMessage]) VALUES (7, 1, N'May 26 2022  5:53PM', N'adsf')
SET IDENTITY_INSERT [dbo].[tblmessagechatpublic] OFF
GO
INSERT [dbo].[tbltypecompte] ([Id_TypeCompte], [TypeCompte]) VALUES (1, N'Standard')
INSERT [dbo].[tbltypecompte] ([Id_TypeCompte], [TypeCompte]) VALUES (2, N'Modérateur')
INSERT [dbo].[tbltypecompte] ([Id_TypeCompte], [TypeCompte]) VALUES (3, N'Administrateur')
GO
ALTER TABLE [dbo].[tblcanalchatpublic]  WITH CHECK ADD  CONSTRAINT [FK_tblcanalchatpublic_tblemploye] FOREIGN KEY([Créateur])
REFERENCES [dbo].[tblemploye] ([Id_Employe])
GO
ALTER TABLE [dbo].[tblcanalchatpublic] CHECK CONSTRAINT [FK_tblcanalchatpublic_tblemploye]
GO
ALTER TABLE [dbo].[tblcompteemploye]  WITH CHECK ADD  CONSTRAINT [FK_tblcompteemploye_tblemploye] FOREIGN KEY([Id_Employe])
REFERENCES [dbo].[tblemploye] ([Id_Employe])
GO
ALTER TABLE [dbo].[tblcompteemploye] CHECK CONSTRAINT [FK_tblcompteemploye_tblemploye]
GO
ALTER TABLE [dbo].[tblcompteemploye]  WITH CHECK ADD  CONSTRAINT [FK_tblcompteemploye_tbltypecompte] FOREIGN KEY([Id_TypeCompte])
REFERENCES [dbo].[tbltypecompte] ([Id_TypeCompte])
GO
ALTER TABLE [dbo].[tblcompteemploye] CHECK CONSTRAINT [FK_tblcompteemploye_tbltypecompte]
GO
ALTER TABLE [dbo].[tblmessagechatprive]  WITH CHECK ADD  CONSTRAINT [FK_tblmessagechatprive_tblcanalchatprive] FOREIGN KEY([Id_CanalChatPrive])
REFERENCES [dbo].[tblcanalchatprive] ([Id_CanalChatPrive])
GO
ALTER TABLE [dbo].[tblmessagechatprive] CHECK CONSTRAINT [FK_tblmessagechatprive_tblcanalchatprive]
GO
ALTER TABLE [dbo].[tblmessagechatprive]  WITH CHECK ADD  CONSTRAINT [FK_tblmessagechatprive_tblemploye] FOREIGN KEY([Id_Employe])
REFERENCES [dbo].[tblemploye] ([Id_Employe])
GO
ALTER TABLE [dbo].[tblmessagechatprive] CHECK CONSTRAINT [FK_tblmessagechatprive_tblemploye]
GO
ALTER TABLE [dbo].[tblmessagechatpublic]  WITH CHECK ADD  CONSTRAINT [FK_tblmessagechatpublic_tblemploye] FOREIGN KEY([Id_Employe])
REFERENCES [dbo].[tblemploye] ([Id_Employe])
GO
ALTER TABLE [dbo].[tblmessagechatpublic] CHECK CONSTRAINT [FK_tblmessagechatpublic_tblemploye]
GO
USE [master]
GO
ALTER DATABASE [TPI] SET  READ_WRITE 
GO
