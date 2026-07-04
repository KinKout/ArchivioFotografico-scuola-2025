using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.VisualBasic;
using PhotoArchive.Collections;
using PhotoArchive.Core;
using PhotoArchive.Entities;
using PhotoArchive.Query.EntityQuery;
using PhotoArchive.UI;

namespace PhotoArchive.Query
{
    internal class DataQueryProcessor
    {
        private string _entity;
        private string _parameter;
        private string _textToSearch;
        private DateTime _dateBirth;
        private DateTime _dateDeath;
        private DateTime _dateStart;
        private DateTime _dateEnd;
        private string _queryToSend;
        private string _connectionString;

        public DataQueryProcessor(string entity,
                            string parameter,
                            string textToSearch,
                            DateTime datebirth,
                            DateTime dateDeath,
                            DateTime dateStart,
                            DateTime dateEnd,
                            string queryToSend,
                            string connectionString)
        {
            _entity = entity;
            _parameter = parameter;
            _textToSearch = textToSearch;
            _dateBirth = datebirth;
            _dateDeath = dateDeath;
            _dateStart = dateStart;
            _dateEnd = dateEnd;
            _queryToSend = queryToSend;
            _connectionString = connectionString;
        }

        public string GetParameter() { return _parameter; }
        public string GetTextToSearch() { return _textToSearch; }
        public DateTime GetDateBirth() { return _dateBirth; }
        public DateTime GetDateDeath() { return _dateDeath; }
        public DateTime GetDateStart() { return _dateStart; }
        public DateTime GetDateEnd() { return _dateEnd; }
        public string GetQueryToSend() { return _queryToSend; }
        public string GetConnectionString() { return _connectionString; }

        public IEntityCollection? CallDataQuery()
        {
            IEntityCollection? _e = null;
            switch (_entity)
            {
                case "Politico":
                    _e = CallDataQueryPolitico();
                    return _e;
                case "Sportivo":
                    _e = CallDataQuerySportivo();
                    return _e;
                case "Artista":
                    _e = CallDataQueryArtista();
                    return _e;
                case "Luogo":
                    _e = CallDataQueryLuogo();
                    return _e;
            } 
            return _e;
        }
        public Politici? CallDataQueryPolitico()
        {
            PoliticoQuery _politici = new PoliticoQuery(this);
            return _politici.ExecuteDataQuery();
        }

        public Sportivi? CallDataQuerySportivo()
        {
            SportivoQuery _sportivi = new SportivoQuery(this);
            return _sportivi.ExecuteDataQuery();
        }

        public Artisti? CallDataQueryArtista()
        {
            ArtistaQuery _artisti = new ArtistaQuery(this);
            return _artisti.ExecuteDataQuery();
        }

        public Luoghi? CallDataQueryLuogo()
        {
            LuogoQuery _luoghi = new LuogoQuery(this);
            return _luoghi.ExecuteDataQuery();
        }
    }
}
