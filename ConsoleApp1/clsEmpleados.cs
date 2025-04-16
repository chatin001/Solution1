

namespace ConsoleApp1;

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


    private double _sueldo;

    public double SueldoPublico
    {
        //devuelve
        get { return _sueldo; }

        //Define 
        set { _sueldo = value; } 
    }

    public clsEmpleados(string nombre, string edad, string genero, double sueldo)
    {
        _nombre = nombre;
        _edad = edad;
        _genero = genero;
        _sueldo = sueldo;

    }

}
