// See https://aka.ms/new-console-template for more information
using System.Text;
public class Libro
{
    int cant = 0;
    int cod = 0;
    int pag = 0;
    int pagA = 0;
    bool leido;
    double porcentaje = 0;
    String nombre;

    public void Leer(int cant, int pag)
    {
        pag = pag + 1;
       
    }
    public double Porcentaje(int cant, int pag)
    {
        porcentaje = (pag * 100) / cant;
        return porcentaje;
    }

    public void PaginaActual(int pag)
    {
        Console.WriteLine("La pagina actual es " + pag);
    }
    public void MostrarLibro(int cod, string nombre, int cant, int pag)
    {
        Console.WriteLine("Libro");
        Console.WriteLine("Codigo: " + cod);
        Console.WriteLine("Nombre: "+nombre);
        Console.WriteLine("Cantidad de paginas: " + cant);
        Console.WriteLine("Cantidad de paginas leidas " + pag);
        Console.WriteLine("El porcentaje es "+ Porcentaje(cant, pag)+"%");
    }

    public void EstadoLibro(int pag, int cant)
    {
        if (pag == cant)
        {
            leido = true;
            Console.WriteLine("El libro esta leido");
        }
        if (pag < cant)
        {
            Console.WriteLine("El libro esta en proceso");
        }
        if (pag == 0)
        {
            Console.WriteLine("El libro no ha sido empezado");
        }
        if (pag > cant)
        {
            Console.WriteLine("Error");
        }
    }
    public static void Main()
    {
        int cant = 0;
        int pag = 0;
        int cod = 0;
        int porcentaje = 0;
        string nombre;
        Console.WriteLine("Ingrese la cantidad de paginas leidas");
        pag = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de paginas totales del libro");
        cant = Convert.ToInt32(Console.ReadLine());
        Libro x = new Libro();
        x.Porcentaje(cant, pag);
        x.Leer(cant, pag);
        x.EstadoLibro(pag, cant);
        x.PaginaActual(pag);
        Console.WriteLine("Ingrese el codigo del libro");
        cod = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el nombre del libro");
        nombre = Console.ReadLine();
        x.MostrarLibro(cod, nombre, cant, pag);


    }
}
