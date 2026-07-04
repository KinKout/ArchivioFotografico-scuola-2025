using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoArchive.Entities
{
    internal interface IEntity
    {
        int GetID();
        Dictionary<string, string> GetDisplayData();
        void AddPhoto(Image image);
        Image? GetFirstPhoto();
        Image? GetPrevPhoto();
        Image? GetNextPhoto();
        int GetCountPhoto();
        int GetNPhoto();
    }
}
