
-- DataBase for --https://github.com/danhpaiva/login-csharp-sqlServer
-- Drop DataBase Login
CREATE DATABASE [LOGIN]
GO
USE LOGIN
CREATE TABLE [dbo].[Authentication](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
insert into Authentication values('admin', 'admin')
insert into Authentication values('paiva', '12345')

GO
select * from Authentication