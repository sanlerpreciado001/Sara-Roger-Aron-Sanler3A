using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sara_arón_roger_sanler
{
    class Producto
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private double precio;

        public  double Precio
        {
            get { return precio; }
            set { precio = value; }
        }



    }
}
