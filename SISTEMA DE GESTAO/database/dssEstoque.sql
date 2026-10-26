create database dssEstoque;
use dssEstoque;

create table if not exists Produto(
CodProd int primary key,
DescProd varchar(30) not null,
ValorProd decimal (5,2) not null,
VencProd date)engine=InnoDB;

insert into Produto(CodProd, DescProd, ValorProd, VencProd)
values (1 ,'Soja', 9.99, '2027-08-28'),
	   (2 ,'Banana', 5.00, '2026-12-30'),
 	   (3 ,'Banana nanica', 6.70, '2026-11-25');

create table if not exists tb_estoque(
CodEstoque int primary key,
DescEstoque varchar(30) not null,
QtndEstoque int not null,
dataEstoque date) engine=InnoDB;

insert into tb_estoque(CodEstoque, DescEstoque, QtndEstoque, dataEstoque)
values (1, 'Soja', 67, '2027-08-27'),
	   (2, 'Banana', 20, '2030-08-28'),
	   (3, 'Banana nanica', 100, '2030-08-28');

CREATE TABLE IF NOT EXISTS tb_cliente(
CPF_cliente CHAR(11) PRIMARY KEY NOT NULL, ##caso o usuario digite (. ou - no formato XXX.XXX.XXX-XX) o sistema vai tirar para entrar no banco
Nome_cliente VARCHAR(60) NOT NULL, ##limitado no form
Cel_cliente char(11) NOT NULL,  ##(xx)xxxxx-xxxx (sistema tira qualquer outra coisa que nao for numero)
Email_cliente VARCHAR(120),
Genero_cliente CHAR(3) ##Sistema reconhece os RadioButton como FEM ou MAS
);

##23/10/26
## NAO SEI A REGRA DO FORM, MAS COLOQUEI QUE O USUARIO É OBRIGADO A PREENCHER CELULAR MAS NAO O EMAIL E GENERO

INSERT INTO tb_cliente(CPF_cliente, Nome_cliente, Cel_cliente, Email_cliente, Genero_cliente)
VALUE (99999999999, "Marcelo", 11111111111, "Marcelo@terra.com", "Mas");

##-------CHAMADOS DAS TABELAS-------
## analise tabela cliente
SELECT * FROM tb_cliente;

## analise tabela de estoque
SELECT * FROM tb_estoque;

## analise tabela de Produto
SELECT * FROM tb_Produto;
