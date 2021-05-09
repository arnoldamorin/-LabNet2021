using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newT);
        void Delete(int id);
        void Update(T newT);

    }
}
