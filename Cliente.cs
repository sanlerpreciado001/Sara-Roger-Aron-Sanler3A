using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sara_arón_roger_sanler
{
    public class Cliente
    {
        private String identificacion;

        public String Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private List<Factura> facturas;

        public List<Factura> Facturas
        {
            get { return facturas; }
            set { facturas = value; }
        }




    }
}
