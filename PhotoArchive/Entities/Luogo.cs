using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoArchive.Core;

namespace PhotoArchive.Entities
{
    /// <summary>
    /// Classe Luogo
    /// </summary>
    internal class Luogo : IEntity
    {
        private int _id;
        private string _city;
        private string _description;
        private List<Image> _foto;
        private int _n_curr_foto;
        private int _n_foto;

        public Luogo(
            int ID,
            string citta,
            string descrizione)
        {
            _id = ID;
            _city = citta;
            _description = descrizione;
            _foto = new List<Image>();
            _n_curr_foto = 0;
            _n_foto = _foto.Count;
        }

        public int GetID() { return _id; }
        public string GetName() { return _city; }

        public Dictionary<string, string> GetDisplayData()
        {
            _description = _description.Replace(", ", Environment.NewLine);
            var _data = new Dictionary<string, string>
            {
                ["tb_dataF_1"] = _city,
                ["tb_dataF_8"] = _description
            };
            return _data;
        }

        public int GetCountPhoto()
        {
            _n_foto = _foto.Count;
            return _n_foto;
        }

        public int GetNPhoto()
        {
            if (GetCountPhoto() > 0)
                return _n_curr_foto + 1;
            return 0;
        }

        public void AddPhoto(Image image)
        {
            _foto.Add(image);
        }

        public Image? GetFirstPhoto()
        {
            _n_curr_foto = 0;
            if (_n_curr_foto < _foto.Count)
                return _foto[_n_curr_foto];
            return null;
        }

        public Image? GetPrevPhoto()
        {
            if (_n_curr_foto - 1 < _foto.Count && _n_curr_foto - 1 >= 0)
                return _foto[--_n_curr_foto];
            return null;
        }

        public Image? GetNextPhoto()
        {
            if (_n_curr_foto + 1 < _foto.Count && _n_curr_foto + 1 >= 0)
                return _foto[++_n_curr_foto];
            return null;
        }
    }
}