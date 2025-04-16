namespace ConsoleApp1
{
     class Program
    {
        
        static void Main(string[] args)

        {
           clsEmpleados empleados = new clsEmpleados(nombre: "g", edad: "19", genero: "Masc", sueldo:1500);

            
            Console.WriteLine(empleados.NombrePublico);
            Console.WriteLine(empleados.EdadPublico);
            Console.WriteLine(empleados.GeneroPublico);
            Console.WriteLine(empleados.SueldoPublico);


        }

        public class xxx()
        {
            public int nombre;
            public string edad;
            public int genero;
            public double sueldo;
        
        }
    }
}
