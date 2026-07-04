using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoArchive.Query
{
    internal class ControlQueryText
    {
        public bool ControlTextToSearch(string _text)
        {
            _text = _text.Trim();
            if (_text.Length <= 0)
            {
                return false;
            }
            return true; 
        }
    }
}
