using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sara_arón_roger_sanler
{
    public class Factura
    {
        private String numero;

        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private String fecha;

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }



    }
}
