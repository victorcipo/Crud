DROP DATABASE Crud
GO
CREATE DATABASE Crud
GO
USE Crud
GO
CREATE TABLE empresa(
	id int identity primary key,
	nome varchar(100) not null
)
GO
CREATE TABLE pedido(
	id int identity primary key,
	funcionario varchar(100) not null,
	tamanho varchar(10) not null,
	empresaId int FOREIGN KEY REFERENCES empresa(id),
	horario datetime not null,
	arroz bit,
	feijao bit,
	refogado bit,
	proteina bit,
	salada bit
)
INSERT INTO empresa(nome) VALUES('Empresa A')
INSERT INTO empresa(nome) VALUES('Empresa B')
INSERT INTO empresa(nome) VALUES('Empresa C')

select * from pedido