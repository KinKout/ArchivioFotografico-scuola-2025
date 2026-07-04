using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoArchive.Entities
{
    internal interface IEntityCollection
    {
        IEntity? GetFirst();
        IEntity? GetNext();
        IEntity? GetPrevious();
        string ShowCount();
        int GetCount();
        int GetNCurrent();
    }
}
