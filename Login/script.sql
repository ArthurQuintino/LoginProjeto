create database login;
use login;

create table cliente(
	id int primary key auto_increment,
    nome varchar(50),
    dataNascimento date,
	telefone bigint,
    cep int,
    sexo varchar(30),
    cpf bigint,
	email varchar(100),
    senha varchar(30),
    situacao varchar(50)
);

create table colaborador(
	id int primary key auto_increment,
    nome varchar(50),
	email varchar(100),
    senha varchar(30),
    tipoColaborador varchar(50)
);