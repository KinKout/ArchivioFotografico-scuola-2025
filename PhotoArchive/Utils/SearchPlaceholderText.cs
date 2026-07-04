using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoArchive.Utils
{
    internal class SearchPlaceholderText
    {
        private string _article1;
        private string _tipo;
        private string _article2;
        private string _genre;

        public SearchPlaceholderText(string article1, string tipo, string article2, string genre)
        {
            _article1 = article1;
            _tipo = tipo;
            _article2 = article2;
            _genre = genre;
        }

        public void SetArticle1(string article1) { _article1 = article1; }
        public string GetArticle1() { return _article1; }
        public void SetTipo(string tipo) { _tipo = tipo; }
        public string GetTipo() { return _tipo; }
        public void SetArticle2(string article2) { _article2 = article2; }
        public string GetArticle2() { return _article2; }
        public void SetGenre(string genre) { _genre = genre; }
        public string GetGenre() { return _genre; }

        public string GetPlaceHolder()
        {
            return "Inserisci" + (_article1 + _tipo + _article2 + _genre);
        }
    }
}
