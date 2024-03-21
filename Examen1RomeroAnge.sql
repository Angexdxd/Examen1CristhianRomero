CREATE DATABASE EXAMEN1_CRISTHIANROMERO

CREATE TABLE CLIENTE (
IDCLIENTE INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR(25) NOT NULL,
DINERO MONEY NOT NULL,
CI NVARCHAR(15) NOT NULL,
FECHANAC DATETIME NOT NULL,
PRIMARY KEY (IDCLIENTE),
);

CREATE TABLE VENTA (
IDVENTA INT IDENTITY (1,1) NOT NULL,
IDCLIENTE INT NOT NULL,
PRODUCTO NVARCHAR(25) NOT NULL,
PRECIO MONEY NOT NULL,
FECHA DATETIME NOT NULL,
PRIMARY KEY (IDVENTA),
FOREIGN KEY (IDCLIENTE) REFERENCES CLIENTE (IDCLIENTE),
);

insert into CLIENTE values('Jose',1000,'10648578', '2022-01-09 12:47:29');
insert into CLIENTE values('Jose',1000,'10648578', '2022-01-09 12:47:29');
insert into CLIENTE values('Jose',1000,'10648578', '2022-01-09 12:47:29');
insert into CLIENTE values('Jose',1000,'10648578', '2022-01-09 12:47:29');

select * from CLIENTE

insert into VENTA values(1,'soda',10,'2022-01-09 12:47:29')
insert into VENTA values(2,'soda',10,'2022-01-09 12:47:29')
insert into VENTA values(3,'soda',10,'2022-01-09 12:47:29')


select * from venta