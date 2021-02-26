using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetById(int id);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
