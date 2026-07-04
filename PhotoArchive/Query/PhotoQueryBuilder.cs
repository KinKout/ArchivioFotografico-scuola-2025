using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoArchive.Query
{
    public class PhotoQueryBuilder
    {
        private string _entity;
        private string _query = "";

        public PhotoQueryBuilder(string entity)
        {
            _entity = entity;
        }
        public string GetPhotoQuery()
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
            _query = @"select F.Foto from Foto F where F.id_Politico = @id_politico";
        }
        private void SportivoQuery()
        {
            _query = @"select F.Foto from Foto F where F.id_Sportivo = @id_sportivo";
        }
        private void ArtistaQuery()
        {
            _query = @"select F.Foto from Foto F where F.id_Artista = @id_artista";
        }
        private void LuogoQuery()
        {
            _query = @"select F.Foto from Foto F where F.id_Luogo = @id_luogo";
        }
        
    }
}
