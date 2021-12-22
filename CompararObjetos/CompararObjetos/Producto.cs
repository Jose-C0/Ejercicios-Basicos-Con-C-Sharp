using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CompararObjetos
{
    class Producto : IComparable<Producto>
    {
        public string Codigo { get; set; }
        public decimal Precio { get; set; }

        public int CompareTo([AllowNull] Producto otro)
        {
            //> 0 mayor
            // == 0 igual
            /// < 0 menor
            if (this.Precio > otro.Precio) return 1;
            if (this.Precio == otro.Precio) return 0;

            return -1;

           

        }
    }
}
