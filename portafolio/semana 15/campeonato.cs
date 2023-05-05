// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CampeonatoFutbol
{
    class Equipo
    {
        public string nombre;
        public int partidosJugados;
        public int partidosGanados;
        public int partidosEmpatados;
        public int partidosPerdidos;
        public int golesAFavor;
        public int golesEnContra;

        public Equipo(string nombre)
        {
            this.nombre = nombre;
            this.partidosJugados = 0;
            this.partidosGanados = 0;
            this.partidosEmpatados = 0;
            this.partidosPerdidos = 0;
            this.golesAFavor = 0;
            this.golesEnContra = 0;
        }

        public void RegistrarPartido(int golesAFavor, int golesEnContra)
        {
            this.partidosJugados++;
            this.golesAFavor += golesAFavor;
            this.golesEnContra += golesEnContra;

            if (golesAFavor > golesEnContra)
            {
                this.partidosGanados++;
            }
            else if (golesAFavor == golesEnContra)
            {
                this.partidosEmpatados++;
            }
            else
            {
                this.partidosPerdidos++;
            }
        }

        public int DiferenciaGoles()
        {
            return this.golesAFavor - this.golesEnContra;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Ingrese el número de equipos que participaron en el campeonato:");
            int numEquipos = int.Parse(Console.ReadLine());

            List<Equipo> equipos = new List<Equipo>();

            for (int i = 1; i <= numEquipos; i++)
            {
                Console.WriteLine("Ingrese el nombre del equipo " + i + ":");
                string nombre = Console.ReadLine();

                // Verificar que el nombre no se repita
                bool nombreRepetido = false;
                foreach (Equipo equipo in equipos)
                {
                    if (equipo.nombre == nombre)
                    {
                        nombreRepetido = true;
                        break;
                    }
                }

                if (nombreRepetido)
                {
                    Console.WriteLine("El nombre del equipo ya ha sido ingresado. Por favor ingrese un nombre diferente.");
                    i--;
                }
                else
                {
                    equipos.Add(new Equipo(nombre));
                }
            }

            // Generar resultados aleatorios
            foreach (Equipo equipo in equipos)
            {
                for (int i = 1; i <= numEquipos - 1; i++)
                {
                    int golesAFavor = random.Next(1, 16);
                    int golesEnContra = random.Next(1, 16);

                    equipo.RegistrarPartido(golesAFavor, golesEnContra);

                    // Registrar los mismos resultados en el equipo contrario
                    Equipo equipoContrario = equipos[i % numEquipos];
                    equipoContrario.RegistrarPartido(golesEnContra, golesAFavor);
                }
            }

            // Mostrar tabla de posiciones
            Console.WriteLine();
            Console.WriteLine("Tabla de posiciones:");
            Console.WriteLine("Equipo\tPJ\tPG\tPE\tPP\tGF\tGC\tDG\tPTS");
            Console.WriteLine();
        }
    }
}