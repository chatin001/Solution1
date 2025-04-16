using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class clsEmpleados
    {
        private string _nombre;

        public string NombrePublico
        {
            //devuelve
            get { return _nombre; }

            //Define 
            set { _nombre = value; }
        }


        private string _edad;

        public string EdadPublico
        {
            //devuelve
            get { return _edad; }

            //Define 
            set { _edad = value; }
        }



        private string _genero;

        public string GeneroPublico
        {
            //devuelve
            get { return _genero; }

            //Define 
            set { _genero = value; }
        }


        private string _sueldo;

        public string SueldoPublico
        {
            //devuelve
            get { return _sueldo; }

            //Define 
            set { _sueldo = value; } 
        }

    }
}
