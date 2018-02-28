using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface ICrud<T>
    {
        void insertar(T c);
        void modificar(T c);
        void eliminar(T c);

    }
}
