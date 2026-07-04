using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoArchive.Entities;

namespace PhotoArchive.Query
{
    public class DataQueryBuilder
    {
        private string _entity;
        private string _parameter;
        private string _query = "";

        public DataQueryBuilder(string entity, string parameter)
        {
            _entity = entity;
            _parameter = parameter;
        }

        public string GetDataQuery()
        {
            switch (_entity)
            {
                case "Politico":
                    PoliticoQuery();
                    break;
                case "Sportivo":
                    SportivoQuery();
                    break;
                case "Artista":
                    ArtistaQuery();
                    break;
                case "Luogo":
                    LuogoQuery();
                    break;
            }
            return _query;
        }

        private void PoliticoQuery()
        {
            _query = @"select ID_Politico, Nome, Cognome, Sesso, Partito, Data_N, Data_M, Data_In, Data_Fi
                        from Politico
                        where";
            ParameterSelector();
        }

        private void SportivoQuery()
        {
            _query = @"select ID_Sportivo, Nome, Cognome, Sesso, Sport, Squadra, Data_N, Data_M
                        from Sportivo
                        where";
            ParameterSelector();
        }
        
        private void ArtistaQuery()
        {
            _query = @"select ID_Artista, Nome, Cognome, Sesso, Attivita, Data_N, Data_M
                        from Artista
                        where";
            ParameterSelector();
        }

        private void LuogoQuery()
        {
            _query = @"select ID_Luogo, Citta, Descrizione
                        from Luogo
                        where";
            ParameterSelector();
        }

        private void ParameterSelector()
        {
            switch (_parameter)
            {
                case "Nome":
                    _query += " Nome like @name";
                    break;
                case "Citta'":
                    _query += " Citta like @city";
                    break;
                case "Cognome":
                    _query += " Cognome like @surname";
                    break;
                case "Descrizione":
                    _query += " Descrizione like @description";
                    break;
                case "Partito":
                    _query += " Partito like @party";
                    break;
                case "Sport":
                    _query += " Sport like @sport";
                    break;
                case "Attivita'":
                    _query += " Attivita like @activity";
                    break;
                case "Team'":
                    _query += " Squadra like @team";
                    break;
                case "Nato fra il":
                    _query += " Data_N between @date_b and @date_d";
                    break;
                case "Attivo dal":
                    _query += " Data_In between @date_in and @date_out";
                    break;
            }
        }
    }
}
