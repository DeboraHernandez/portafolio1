// See https://aka.ms/new-console-template for more information


using System.Diagnostics;

public class cafetera
{
    int cod = 0;
    bool lleno;
    int cap = 10;
    int disp = 0;
    int cant = 0;
    int tz = 0;
    int opcion = 0;

    public void hacerCafe()
    {
        lleno = true;
        disp = cant;
    }
    public void servirTaza(int cant)
    { 
        if (disp >= tz)
        {
            disp = disp - tz;
        }
        else
        {
            Console.WriteLine("No tenemos suficientes tazas disponibles");
        }
    }
    public double obtenerPorcentaje()
    {
        double por = (disp / cap) * 100;
        return por;
    }
    public void mostrarEstado()
    {
        string texto;
        texto = cod + " capacidad: " + cap + " tazas servidas: " + (cap - disp) + " porcentaje de disponibilidad " + obtenerPorcentaje() + "%";
    }

    public cafetera(int elCodigo, int laCapacidad)
    {
        cod = elCodigo;
        cap = laCapacidad;
        lleno = false;
        disp = 0;
    }

    public static void Main()
    {

        Console.WriteLine("Ingrese la capacidad de la cafetera");
        int cap =  Convert.ToInt32(Console.ReadLine());
        string opcion = "";
        cafetera cafe = new cafetera(1, cap);

        cafe.hacerCafe();
        do
        {
            Console.WriteLine("Cuantas tazas quiere servir?");
            int tz = Convert.ToInt32(Console.ReadLine());
            cafe.servirTaza(tz);
            cafe.mostrarEstado();

            Console.WriteLine("Desea ingresar mas tazas? s/n");
            opcion = Console.ReadLine();

        } while (opcion == "s");

        
    }
}
