-- Criando o bacno de dados
create database dbprojeto1;
-- Usando o banco de dados
use dbprojeto1;

-- Criando as tabelas do banco

/*Usuario*/
create table Usuario(
	Id int primary key auto_increment,
    Nome varchar(50) not null,
    Email varchar(50) not null,
    Senha varchar(50) not null
);

-- Consultando as tabelas do banco
select * from Usuario;