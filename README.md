# Archivio Fotografico

Applicazione desktop **Windows Forms (C#)** con backend **SQL Server** per la gestione e consultazione di un archivio digitale di fotografie legate a diverse categorie di entità: politici, sportivi, artisti e luoghi. Lo strumento facilita la ricerca, la consultazione e l'esplorazione delle fotografie associate a ciascun soggetto, con funzionalità di filtraggio e visualizzazione dinamiche.

## Contesto

Progetto realizzato nell'ambito del percorso di studi serale (indirizzo Informatica), anno scolastico 2024/2025. Il modello Entità-Relazione è stato sviluppato in classe insieme al prof. Ezio Gava, che ha fornito come base un progetto di esempio con la sola entità `Politico`, connesso a un database SQL Server chiamato `ArchivioFotografico`.

A partire da quella base ho completato l'implementazione aggiungendo le entità `Sportivo`, `Artista` e `Luogo`, provando, con le competenze che avevo in quel momento, a spingermi oltre la richiesta minima e a costruire qualcosa di più strutturato: un modello a interfacce (`IEntity`/`IEntityCollection`) e la separazione tra costruzione ed esecuzione delle query (`*Builder`/`*Processor`), nel tentativo di esplorare in prima persona il tema della manutenibilità del codice.

Ho dedicato cura anche alla UX/UI dell'interfaccia, cercando che i controlli guidassero l'utente in modo naturale a seconda del tipo di entità selezionata.

## Obiettivi del progetto

- Permettere una ricerca dinamica delle entità, filtrando i risultati in base a parametri come nome, cognome, professione e date rilevanti
- Consentire la visualizzazione dei dettagli relativi a ciascun soggetto (dati biografici, professione, attività svolta, ecc.)
- Integrare la gestione delle fotografie, allegando una o più immagini a ciascuna entità e consentendo di sfogliarle in modo semplice e intuitivo
- Favorire l'uso di un'interfaccia utente chiara e modulare, che si adatta dinamicamente in base al tipo di entità selezionata

## Funzionalità principali

- **Ricerca personalizzata**: tramite selezione del tipo di entità (politico, sportivo, artista o luogo) e filtri dedicati, per ricerche mirate e risultati precisi
- **Visualizzazione dei risultati**: dettagli delle entità selezionate accompagnati dalle fotografie collegate
- **Navigazione tra i risultati**: scorrimento sequenziale dei record trovati
- **Gestione delle fotografie**: query dedicate per associare correttamente le fotografie ai soggetti, con interfaccia di sfoglio intuitiva
- **Interfaccia dinamica**: i controlli si adattano automaticamente in base alla categoria selezionata (es. campo "partito" per i politici, "sport" per gli sportivi)

## Struttura tecnica

Il progetto è costruito con **.NET 8 Windows Forms**, attorno a un modello a interfacce (`IEntity`, `IEntityCollection`) che disaccoppia la logica applicativa dal tipo concreto di entità gestita.

```
PhotoArchive/
├── Core/              # Entry point dell'applicazione
├── Entities/          # Modelli di dominio (Politico, Sportivo, Artista, Luogo, Persona)
├── Collections/       # Collezioni tipizzate delle entità
├── Query/             # Costruzione ed esecuzione delle query verso il database
│   └── EntityQuery/   # Query specifiche per ciascun tipo di entità
├── UI/                # Interfaccia Windows Forms
└── Utils/             # Utility di supporto
```

La costruzione ed esecuzione delle query è separata in due responsabilità distinte:
le classi `*Builder` (`DataQueryBuilder`, `PhotoQueryBuilder`) compongono la query,
 le classi `*Processor` (`DataQueryProcessor`, `PhotoQueryProcessor`) la eseguono e mappano il risultato sulle entità di dominio.

La connessione ai dati usa autenticazione Windows verso un database SQL Server (`ArchivioFotografico`), con trusted connection e certificato server.

## Database

Il database è composto da cinque tabelle:

| Tabella | Descrizione |
|---|---|
| `Politico` | Nome, cognome, sesso, partito, data di nascita/morte, periodo di attività |
| `Sportivo` | Nome, cognome, sesso, sport praticato, squadra, data di nascita/morte |
| `Artista` | Nome, cognome, sesso, attività (pittore, cantante, attore...), data di nascita/morte |
| `Luogo` | Città e descrizione |
| `Foto` | Tabella centrale: dimensione, stato (restaurata/da restaurare), tipo di stampa e di foto, immagine binaria (`Image`), con foreign key verso una delle quattro tabelle precedenti |

Il design prevede relazioni uno-a-molti tra ciascuna entità (`Politico`/`Sportivo`/`Artista`/`Luogo`) e `Foto`, mantenendo l'integrità referenziale.

Gli script si trovano in `PhotoArchive_Database/SQL code/`:
- `Archivio_Fotografico_DDL.sql` — creazione del database e delle tabelle
- `Archivio_Fotografico_DML.sql` — popolamento con i dati di esempio e le relative foto

## Guida all'installazione

### Requisiti

- Windows
- Visual Studio Community (o successivo) con workload ".NET desktop development"
- .NET 8 SDK
- SQL Server (va bene anche l'edizione Express)
- Privilegi di amministratore (per creare database e tabelle)

### 1. Clona il repository

```bash
git clone https://github.com/KinKout/ArchivioFotografico-scuola-2025.git
```

### 2. Crea il database

Apri SQL Server Management Studio (o un client equivalente) ed esegui in sequenza:

1. `PhotoArchive_Database/SQL code/Archivio_Fotografico_DDL.sql` — crea il database e le tabelle
2. `PhotoArchive_Database/SQL code/Archivio_Fotografico_DML.sql` — popola le tabelle

> **Nota:** nel file DML, gli `INSERT` sulla tabella `Foto` caricano le immagini da percorso locale tramite `OPENROWSET(BULK ...)`. Prima di eseguire lo script, sostituisci il prefisso del percorso (es. `C:\Users\______ IL TUO PATH _______\ArchivioFotografico\...`) con il percorso in cui hai clonato il repository — le immagini di esempio si trovano in `PhotoArchive_Database/Image/`.

### 3. Configura la connessione al database

L'app si connette con autenticazione Windows (`Trusted_Connection`), quindi non servono credenziali — va però indicato il nome della tua istanza SQL Server.

In `PhotoArchive/UI/FormGUI.cs`, aggiorna:

```csharp
private string _localHostName = "KK-Laptop-01"; // sostituisci con il nome della tua istanza
```

Per trovarlo, esegui in SSMS:

```sql
USE ArchivioFotografico;
SELECT SERVERPROPERTY('MachineName') AS ServerName;
```

### 4. Avvia il progetto

Apri `PhotoArchive/PhotoArchive.sln` in Visual Studio, lascia ripristinare i pacchetti NuGet (`Microsoft.Data.SqlClient`), quindi avvia con F5.

## Note

Le fotografie incluse in `PhotoArchive_Database/Image/` sono usate esclusivamente a scopo didattico/dimostrativo.

## Licenza

Distribuito con licenza [MIT](LICENSE).
