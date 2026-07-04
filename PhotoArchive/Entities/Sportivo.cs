using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoArchive.Entities
{
    /// <summary>
    /// Classe Sportivo
    /// </summary>
    internal class Sportivo : Persona, IEntity
    {
        private string _sport;
        private string _team;
        private List<Image> _foto;
        private int _n_curr_foto;
        private int _n_foto;

        public Sportivo(
            int ID,
            string name,
            string surname,
            string gender,
            string sport,
            string team,
            DateTime date_birth,
            DateTime date_death)
            : base(ID, name, surname, gender, date_birth, date_death)
        {
            _sport = sport;
            _team = team;
            _foto = new List<Image>();
            _n_curr_foto = 0;
            _n_foto = _foto.Count;
        }

        public int GetID() { return _id; }
        public string GetName() { return _name; }

        public Dictionary<string, string> GetDisplayData()
        {
            var _data = new Dictionary<string, string>
            {
                ["tb_dataF_1"] = _name,
                ["tb_dataF_2"] = _surname,
                ["tb_dataF_3"] = _sport,
                ["tb_dataF_4"] = _team,
                ["tb_dataF_6"] = _date_birth.ToShortDateString(),
                ["tb_dataF_7"] = _date_death == DateTime.MinValue ? "In vita" : _date_death.ToShortDateString()
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