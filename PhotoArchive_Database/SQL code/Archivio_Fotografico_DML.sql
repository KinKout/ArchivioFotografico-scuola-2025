/*

!!! CAMBIARE IL PERCORSO PER INSERIRE LE FOTO CON QUELLO IN CUI SI TROVA LA CARTELLA !!!

ES: C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Silvio_Berlusconi1.jpg
IN C:\Users\______ IL TUO PATH _______\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Silvio_Berlusconi1.jpg

*/





-- come inserire una immagine
-- (SELECT  BulkColumn FROM OPENROWSET(BULK  N'D:\Archivio fotografico\Politici\immagine.jpg', SINGLE_BLOB) as X)
--

/*
-- Inserzione di una nuova riga nella tabella Politico
use ArchivioFotografico
select *
from Politico
where Cognome='Berlusconi'

-- Query (interrogazione) per avere tutti i politici che hanno cominciato la loro
-- attivita' politica nel periodo specificato
use ArchivioFotografico
select *
from Politico
where Data_in between '1987-1-1' and '2012-1-1' 

-- La seguente query e' molto utile quando non si conosca esattamente tutto il cognome
-- ma si conosce come esso inizia.
use ArchivioFotografico
select * 
from Politico
where Cognome like  'Ber%' -- match parziale sul cognome
--and Nome like 'S%'-- match parziale sul nome

-- ritorna tutte le righe della tabella Politico ma visualizza solo 3 colonne
use ArchivioFotografico
select ID_Politico, Cognome, Nome
from Politico

-- ritorna il numero di records (righe) nella tabella Politico
use ArchivioFotografico
select count(*) from
Politico
*/

 /* ELIMINARE UNA TABELLA ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

 /*
-- ricerca nome del vincolo foreign key
use ArchivioFotografico
select 
    f.name as ForeignKeyName,
    OBJECT_NAME(f.parent_object_id) as TableName,
    COL_NAME(fc.parent_object_id, fc.parent_column_id) as ColumnName
from 
    sys.foreign_keys as f
INNER JOIN 
    sys.foreign_key_columns as fc 
    on f.object_id = fc.constraint_object_id
where 
    OBJECT_NAME(f.referenced_object_id) = 'Artista';

-- elimina vincolo
use ArchivioFotografico
alter table Foto
drop constraint FK__Foto__id_Artista__66603565

-- elimina colonna
use ArchivioFotografico
alter table Foto
Drop column id_Artista

-- elimina tabella
use ArchivioFotografico
drop table Artista

-- elimina tutte le righe della tabella foto
use ArchivioFotografico
delete from Foto
*/

 /* INSERZIONE DI UNA NUOVA RIGA NELLA TABELLA FOTO -----------------------------------------------------------------------------------------------------------------------------------------------*/

-- Inserzione esempio di una nuova riga nella tabella Foto
/*
use ArchivioFotografico
-- inserimento foto di Berlusconi
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Politici)
values('20x20', 'Buono', 'Lucido', 'Colori', (SELECT  BulkColumn FROM OPENROWSET(BULK  N'C:\Users\eg271\Documents\SCUOLA\Esercizi\Quarta\Archivio Fotografico\Silvio_Berlusconi.jpg', SINGLE_BLOB) as X), 1)

-- comando di modifica 
use ArchivioFotografico
update Foto
set id_Politico = 1
from Foto
where ID_foto = 1
*/

/* INSERIMENTO POLITICI ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

 -- Inserzione di una nuova riga nella tabella Politico
use ArchivioFotografico
insert into Politico (Nome, Cognome, Sesso, Partito, Data_N, Data_M, Data_In, Data_Fi)
values('Silvio', 'Berlusconi', 'M', 'Forza Italia', '1936-09-29', '2023-06-12', '1994-06-15', '2011-06-15')

 -- Inserzione di piu' righe contemporaneamente
use ArchivioFotografico
insert into Politico (Nome, Cognome, Sesso, Partito, Data_N, Data_M, Data_In, Data_Fi)
values ('Vladimir', 'Putin', 'M', 'Fronte Popolare', '1952-10-07', null, '2011-06-08', null),
		('Donald', 'Trump', 'M', 'Republican', '1946-06-14', null, '1987-06-15', null)

/* FOTO POLITICI ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
-- inserimento di una foto di Berlusconi
use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Politico)
values('35x23', 'Buono', 'Lucido', 'Colori', (SELECT  BulkColumn FROM OPENROWSET(BULK  N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Silvio_Berlusconi1.jpg', SINGLE_BLOB) as X), 1)

-- inserimento di 5 foto di Putin 
use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Politico)
values('13x6', 'Ottimo', 'Lucido', 'Colori', (SELECT  BulkColumn FROM OPENROWSET(BULK  N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Vladimir_Putin1.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Politico)
values('13x19', 'Soddisfacente', 'Lucido', 'Colori', (SELECT  BulkColumn FROM OPENROWSET(BULK  N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Vladimir_Putin2.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Politico)
values('13x9', 'Soddisfacente', 'Lucido', 'Colori', (SELECT  BulkColumn FROM OPENROWSET(BULK  N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Vladimir_Putin3.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Politico)
values('13x10', 'Soddisfacente', 'Lucido', 'Colori', (SELECT  BulkColumn FROM OPENROWSET(BULK  N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Vladimir_Putin4.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Politico)
values('13x7', 'Soddisfacente', 'Lucido', 'Colori', (SELECT  BulkColumn FROM OPENROWSET(BULK  N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Vladimir_Putin5.jpg', SINGLE_BLOB) as X), 2)

-- inserimento di 4 foto di Trump 
use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Politico)
values('9x6', 'Ottimo', 'Lucido', 'Colori', (SELECT  BulkColumn FROM OPENROWSET(BULK  N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Donald_Trump1.jpg', SINGLE_BLOB) as X), 3)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Politico)
values('9x6', 'Ottimo', 'Lucido', 'Colori', (SELECT  BulkColumn FROM OPENROWSET(BULK  N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Donald_Trump2.jpg', SINGLE_BLOB) as X), 3)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Politico)
values('8x6', 'Ottimo', 'Lucido', 'Colori', (SELECT  BulkColumn FROM OPENROWSET(BULK  N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Donald_Trump3.jpg', SINGLE_BLOB) as X), 3)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Politico)
values('10x6', 'Ottimo', 'Lucido', 'Colori', (SELECT  BulkColumn FROM OPENROWSET(BULK  N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Politico\Donald_Trump4.jpg', SINGLE_BLOB) as X), 3)


/* INSERIMENTO SPORTIVI ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

use ArchivioFotografico
insert into Sportivo (Nome, Cognome, Sesso, Sport, Squadra, Data_N, Data_M)
values('George', 'Weah', 'M', 'Calcio', 'Milan', '1966-10-01', null)

use ArchivioFotografico
insert into Sportivo (Nome, Cognome, Sesso, Sport, Squadra, Data_N, Data_M)
values ('Ayrton', 'Senna', 'M', 'Pilota F1', 'McLaren', '1960-03-21', '1994-05-1')

use ArchivioFotografico
insert into Sportivo (Nome, Cognome, Sesso, Sport, Squadra, Data_N, Data_M)
values ('Alberto', 'Tomba', 'M', 'Sci Alpino', 'Italia', '1966-12-19', null)

/*
-- controlla inserimenti dati
use ArchivioFotografico;
select * from Sportivo;
*/

/* FOTO SPORTIVI ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Sportivo)
values('16x25', 'Discreto', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Sportivo\George_Weah1.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Sportivo)
values('12x16', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Sportivo\George_Weah2.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Sportivo)
values('18x25', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Sportivo\George_Weah3.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Sportivo)
values('14x18', 'Buono', 'Opaco', 'Bianco/Nero', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Sportivo\Ayrton_Senna1.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Sportivo)
values('16x11', 'Buono', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Sportivo\Ayrton_Senna2.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Sportivo)
values('17x17', 'Buono', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Sportivo\Ayrton_Senna3.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Sportivo)
values('14x11', 'Buono', 'Opraco', 'Bianco/Nero', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Sportivo\Ayrton_Senna4.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Sportivo)
values('12x16', 'Buono', 'Opraco', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Sportivo\Alberto_Tomba1.jpg', SINGLE_BLOB) as X), 3)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Sportivo)
values('11x16', 'Buono', 'Opraco', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Sportivo\Alberto_Tomba2.jpg', SINGLE_BLOB) as X), 3)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Sportivo)
values('11x16', 'Buono', 'Opraco', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Sportivo\Alberto_Tomba3.jpg', SINGLE_BLOB) as X), 3)

/*
-- controlla inserimenti foto
use ArchivioFotografico;
select S.ID_Sportivo, S.Nome, S.Cognome, F.ID_Foto, F.Foto
from Sportivo S
JOIN Foto F on S.ID_Sportivo = F.id_Sportivo;
*/

/* INSERIMENTO ARTISTI ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

use ArchivioFotografico
insert into Artista (Nome, Cognome, Sesso, Attivita, Data_N, Data_M)
values('Salvador', 'Dalì', 'M', 'Pittore', '1904-05-11', '1989-01-23')

use ArchivioFotografico
insert into Artista (Nome, Cognome, Sesso, Attivita, Data_N, Data_M)
values('Morgan, Marco', 'Castoldi', 'M', 'Musicista', '1972-12-23', null)

use ArchivioFotografico
insert into Artista (Nome, Cognome, Sesso, Attivita, Data_N, Data_M)
values('Sheryl', 'Crow', 'F', 'Musicista', '1962-02-11', null)

use ArchivioFotografico
insert into Artista (Nome, Cognome, Sesso, Attivita, Data_N, Data_M)
values('Carrie-Anne', 'Moss', 'F', 'Attrice', '1967-08-21', null)

/*
-- controlla inserimenti dati
use ArchivioFotografico;
select * from Artista;
*/

/* FOTO ARTISTI ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Artista)
values('23x13', 'Buono', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Artista\Salvador_Dali1.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Artista)
values('8x11', 'Ottimo', 'Opraco', 'Bianco/Nero', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Artista\Salvador_Dali2.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Artista)
values('16x11', 'Buono', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Artista\Salvador_Dali3.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Artista)
values('13x17', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Artista\Morgan_Marco_Castoldi1.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Artista)
values('23x30', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Artista\Morgan_Marco_Castoldi2.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Artista)
values('13x9', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Artista\Morgan_Marco_Castoldi3.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Artista)
values('16x16', 'Buono', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Artista\Sheryl_Crow1.jpg', SINGLE_BLOB) as X), 3)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Artista)
values('16x11', 'Buono', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Artista\Sheryl_Crow3.jpg', SINGLE_BLOB) as X), 3)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Artista)
values('23x34', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Artista\Carrie_Anne_Moss1.jpg', SINGLE_BLOB) as X), 4)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Artista)
values('23x34', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Artista\Carrie_Anne_Moss2.jpg', SINGLE_BLOB) as X), 4)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Artista)
values('23x15', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Artista\Carrie_Anne_Moss3.jpg', SINGLE_BLOB) as X), 4)

/*
-- controlla ID per inserimento foto
use ArchivioFotografico
select A.ID_Artista, A.Nome, A.Cognome
from Artista A

-- controlla inserimenti foto
use ArchivioFotografico;
select A.ID_Artista, A.Nome, A.Cognome, F.ID_Foto, F.Foto
from Artista A
JOIN Foto F on A.ID_Artista = F.id_Artista;
*/

/* INSERIMENTO LUOGHI ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

use ArchivioFotografico
insert into Luogo (Citta,Descrizione)
values ('Amburgo', 'Germania, Porto, Fiume, Industria, Architettura')

use ArchivioFotografico
insert into Luogo (Citta,Descrizione)
values ('Firenze', 'Italia, Duomo, Ponte, Fiume, Architettura')

use ArchivioFotografico
insert into Luogo (Citta,Descrizione)
values ('Luxor', 'Egitto, Antico, Sabbia, Imponenti, Architettura')

/*
-- controlla inserimenti dati
use ArchivioFotografico
select * from Luogo
*/

/* FOTO LUOGHI ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('16x9', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Amburgo1.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('23x16', 'Buono', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Amburgo2.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('16x11', 'Buono', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Amburgo3.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('16x10', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Amburgo4.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('16x11', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Amburgo5.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('16x12', 'Buono', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Amburgo6.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('16x11', 'Sufficiente', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Amburgo7.jpg', SINGLE_BLOB) as X), 1)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('22x10', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Firenze1.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('18x32', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Firenze2.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('27x20', 'Buono', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Firenze3.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('27x20', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Firenze4.jpg', SINGLE_BLOB) as X), 2)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('16x11', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Luxor1.jpg', SINGLE_BLOB) as X), 3)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('23x16', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Luxor2.jpg', SINGLE_BLOB) as X), 3)

use ArchivioFotografico
insert into Foto (Dimensione, Stato, Tipo_Stampa, Tipo_Foto, Foto, id_Luogo)
values('11x16', 'Ottimo', 'Lucido', 'Colori', (SELECT BulkColumn FROM OPENROWSET(BULK N'C:\Users\Kin Kout\iCloudDrive\Development\Study\ArchivioFotografico\PhotoArchive_Database\Image\Luogo\Luxor3.jpg', SINGLE_BLOB) as X), 3)

/*
-- controlla inserimenti foto
use ArchivioFotografico;
select L.ID_Luogo, L.Citta, L.Descrizione, F.ID_Foto, F.Foto
from Luogo L
JOIN Foto F on L.ID_Luogo = F.id_Luogo;
*/

/*
use ArchivioFotografico
select F.ID_Foto, F.Foto
from Foto F

-- cambia ID politico 1 della foto con ID 1
use ArchivioFotografico
update Foto
set id_Politico = 1
from Foto
where ID_foto = 1

-- cerca tutte le foto di Politico dove Politico inizia la carica fra le date immesse
use ArchivioFotografico
select P.*, F.Foto
from Politico P
join Foto F
on F.id_Politico = P.ID_Politico
where Data_in between '1980-1-1' and '2020-1-1' 

-- cerca tutte le foto del ID politico 3
use ArchivioFotografico
select F.Foto
from Foto F
where F.id_Politico = 3


-- Eliminare tutte le foto di Trump

-- controlla inserimenti foto
USE ArchivioFotografico;
SELECT P.ID_Politico, P.Nome, P.Cognome, F.ID_Foto, F.Foto
FROM Politico P
LEFT JOIN Foto F ON P.ID_Politico = F.id_Politico
WHERE P.Nome LIKE 'Trump'

-- trova ID
use ArchivioFotografico
select ID_Politico
from Politico
where Nome = 'Trump'; -- ID 3

-- Elimina foto
use ArchivioFotografico
delete from Foto
where id_Politico = 3;

-- Eliminare tutte le foto di Weah

-- controlla inserimenti foto
USE ArchivioFotografico;
SELECT S.ID_Sportivo, S.Nome, S.Cognome, F.ID_Foto, F.Foto
FROM Sportivo S
LEFT JOIN Foto F ON S.ID_Sportivo = F.id_Sportivo
WHERE S.Nome LIKE '%Ge%'

-- trova ID
use ArchivioFotografico
select ID_Sportivo
from Sportivo
where Cognome = 'Weah'; -- ID 3

-- Elimina foto dell'entità
use ArchivioFotografico
delete from Foto
where id_Sportivo = 1

-- Elimina foto dell'entità
use ArchivioFotografico
delete from Foto
where id_Artista = 1

-- Elimina foto dell'entità
use ArchivioFotografico
delete from Foto
where id_Luogo = 1
*/