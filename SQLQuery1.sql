create database MvcCrud
use MvcCrud
Create table NotasEst(
	IdNotasE int IDENTITY(1,1) ,
	Nombre nvarchar(30),
	Apellido nvarchar (30) ,
	IPN smallint,
	IIPN smallint,
	Siste smallint,
	Proyect smallint,
	NF smallint,
	EXCI smallint,
	NFCI smallint,
	EXCII smallint,
	NFCII smallint
)