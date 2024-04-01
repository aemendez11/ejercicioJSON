using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioJSON
{
    class Notas
    {
        string nombre;
        List<int> notasAlum;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<int> NotasAlum { get => notasAlum; set => notasAlum = value; }
    }
}
