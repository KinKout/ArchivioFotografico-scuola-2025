------ CREA DATABASE
create database ArchivioFotografico

------ ELIMINA DATABASE
--use master
--drop database if exists ArchivioFotografico

-- Trova nome server
--use ArchivioFotografico
--SELECT SERVERPROPERTY('MachineName') AS ServerName;

use ArchivioFotografico
create table Politico
(
	ID_Politico int identity primary key not null,
	Nome varchar (30) not null,
	Cognome varchar (30) not null,
	Sesso char (1) not null,
	Partito varchar (30) not null,
	Data_N date not null,
	Data_M date null,
	Data_In date not null,
	Data_Fi date null,
)

use ArchivioFotografico
create table Sportivo
(
	ID_Sportivo int identity primary key not null,
	Nome varchar (30) not null,
	Cognome varchar (30) not null,
	Sesso char (1) not null,
	Sport varchar (30) not null,
	Squadra varchar (30) null,
	Data_N Date not null,
	Data_M Date null
)

use ArchivioFotografico
create table Artista
(
	ID_Artista int identity primary key not null,
	Nome varchar (30) not null,
	Cognome varchar (30) not null,
	Sesso char (1) not null,
	Attivita varchar (30) not null,
	Data_N date not null,
	Data_M date null
)

use ArchivioFotografico
create table  Luogo
(
	ID_Luogo int identity primary key not null,
	Citta varchar (50) not null,
	Descrizione varchar (100) not null
)

use ArchivioFotografico
create table Foto
(
	ID_Foto int identity primary key not null,
	Dimensione varchar (10) not null,
	Stato varchar (20) not null,
	Tipo_Stampa varchar (20) not null,
	Tipo_Foto varchar (20) not null,
	Foto Image not null,
	id_Politico int foreign key references Politico (ID_Politico) null,
	id_Sportivo int foreign key references Sportivo (ID_Sportivo) null,
	id_Artista int foreign key references Artista (ID_Artista) null,
	id_Luogo int foreign key references Luogo (ID_Luogo) null	
)