using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiLista<T>
    {
        private T[] elementos;

        public T this[int t]
        {
            get
            {
                return elementos[t];
            }
        }

        public MiLista()
        {
            this.elementos = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref this.elementos, this.elementos.Length + 1);
            this.elementos[this.elementos.Length - 1] = item;
        }

        public bool Remove(T elemento)
        {
            bool retorno = true;

            if(!this.elementos.Contains(elemento))
            {
                retorno = false;
            }
            else
            {
                for(int i = 0; i < this.elementos.Length; i++)
                {
                    if (this.elementos[i].Equals(elemento))
                    {
                        for(int j = i; j < this.elementos.Length; j++)
                        {
                            this.elementos[i] = this.elementos[j];
                        }
                    }
                }
                Array.Resize(ref this.elementos, elementos.Count() - 1);
            }
            return retorno;
        }

        public int Count
        {
            get
            {
                return this.elementos.Count();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.elementos.Count(); i++)
            {
                yield return this.elementos[i];
            }
        }
    }
}
