using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLibro
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                return (i >= 0 && i < this.paginas.Count) ? this.paginas[i] : "";
            }
            set
            {
                if (i >= this.paginas.Count)
                    this.paginas.Add(value);
                else
                    this.paginas[i] = value;
            }
        }
    }
}
