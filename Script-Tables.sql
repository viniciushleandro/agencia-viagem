create table dbo.Destino (
	Codigo_Destino int primary key not null,
	Cidade Varchar(50) not null,
	Uf varchar(2) not null 
);

create table dbo.Cliente (
	Nome varchar(100) not null,
	CPF varchar(20) primary key not null,
	Data_Nascimento datetime not null
);

create table dbo.Pacote (
	Numero_Pacote int primary key not null,
	Tipo_Passeio int not null,
	Data_Viagem datetime not null,
	Diarias int not null,
	Preco decimal not null
);

create table dbo.PacoteDestino (
	Codigo_Pacote int not null,
	Tipo_Passeio int not null,
	Codigo_Destino int not null
);

create table dbo.Agendamento (
	Data_Agendamento datetime not null,
	Pago bit not null,
	CPF_Cliente varchar(20) not null,
	Codigo_Agendamento int primary key not null
);

create table dbo.AgendamentoPacote (
	Codigo_Agendamento int not null,
	Numero_Pacote int not null,
	Tipo_Passeio int not null
);

select * from dbo.Cliente
select * from dbo.Destino
select * from dbo.Pacote
select * from dbo.PacoteDestino
select * from dbo.Agendamento
select * from dbo.AgendamentoPacote

--delete from dbo.Pacote;
--delete from dbo.PacoteDestino;
--delete from dbo.Agendamento
--delete from AgendamentoPacote;

--drop table Agendamento
--drop table Cliente
--drop table Destino
--drop table Pacote
--drop table PacotesDestino
--drop table AgendamentoPacote