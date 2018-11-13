using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IDataBase<T>
    {
        void Guardar(T a);
        bool Modificar(T a);
        List<T> Traer(int id);
    }
}
