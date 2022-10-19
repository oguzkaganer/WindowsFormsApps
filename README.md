# WindowsFormsApps
Basit Windows Forms uygulamaları. (VS 2017)

***FormApp_5 için kullanılacak tabloyu bu sorgular ile oluşturabilirsiniz.

CREATE DATABASE [dbLogin]  // Bu satırı çalıştırıp önce database oluşturuyoruz.

//daha sonra aşağıdaki sorguyu çalıştırarak tabloyu oluşturuyoruz.

USE [dbLogin]
GO

/****** Object:  Table [dbo].[tblUser]    Script Date: 19.10.2022 14:23:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblUser](
	[id] [int] NOT NULL,
	[usr] [nvarchar](50) NULL,
	[pwd] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
