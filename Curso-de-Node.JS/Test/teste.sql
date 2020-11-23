create database sistema;
use sistema;

create table usuarios(
	id int not null auto_increment primary key,
	nome varchar(50), 
	idade int not null
);