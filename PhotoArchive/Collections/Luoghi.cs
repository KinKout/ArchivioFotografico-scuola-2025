using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoArchive.Entities;

namespace PhotoArchive.Collections
{
    /// <summary>
    /// Classe Luoghi
    /// </summary>
    internal class Luoghi : IEntityCollection
    {
        private List<Luogo> _entities;
        private int _n_curr;
        private int _n_entities;
        private string _singular;
        private string _plural;

        public Luoghi()
        {
            _entities = new List<Luogo>();
            _n_curr = 0;
            _n_entities = GetCount();
            _singular = "luogo";
            _plural = "luoghi";
        }

        public void Add(Luogo results)
        {
            _entities.Add(results);
        }

        public Luogo GetFirstEntity()
        {
            _n_curr = 0;
            return _entities[_n_curr];
        }

        public Luogo? GetNextEntity()
        {
            if (_n_curr + 1 < _entities.Count)
            {
                _n_curr++;
                return _entities[_n_curr];
            }
            return null;
        }

        public Luogo? GetPreviousEntity()
        {
            if (_n_curr - 1 >= 0)
            {
                _n_curr--;
                return _entities[_n_curr];
            }
            return default;
        }

        public void ClearListEntities()
        {
            _entities.Clear();
            _n_curr = 0;
        }

        public int GetCount()
        {
            return _entities.Count;
        }

        public int GetNCurrent()
        {
            return _n_curr + 1;
        }

        public string ShowNumberResultEntities()
        {
            _n_entities = GetCount();
            if (_n_entities == 0)
                return $"Non è stato trovato nessun {_singular}";
            if (_n_entities == 1)
                return $"E' stato trovato 1 {_singular}";
            return $"Sono stati trovati {_n_entities} {_plural}";
        }

        public void SortByName()
        {
            _entities = _entities.OrderBy(p => p.GetName()).ToList();
        }

        public IEntity? GetFirst()
        {
            return GetFirstEntity();

        }

        public IEntity? GetNext()
        {
            IEntity? _e = GetNextEntity();
            return _e;
        }

        public IEntity? GetPrevious()
        {
            IEntity? _e = GetPreviousEntity();
            return _e;
        }

        public string ShowCount()
        {
            string _e = ShowNumberResultEntities();
            return _e;
        }
    }
}
