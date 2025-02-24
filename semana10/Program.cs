using System;
using System.Collections.Generic;

public class Ciudadano
{
    public string Nombre { get; set; }
    public string Cedula { get; set; }
    public HashSet<string> Vacunas { get; set; }

    public Ciudadano(string nombre, string cedula, HashSet<string> vacunas)
    {
        Nombre = nombre;
        Cedula = cedula;
        Vacunas = vacunas;
    }
}

public class Programa
{
    public static void Main()
    {
        // Crear el conjunto global de 500 ciudadanos
        HashSet<Ciudadano> ciudadanos = new HashSet<Ciudadano>();

        // Crear 75 ciudadanos con solo Pfizer
        for (int i = 1; i <= 75; i++)
        {
            string nombre = "Ciudadano " + i;
            string cedula = "C" + i;

            // Solo Pfizer
            HashSet<string> vacunas = new HashSet<string> { "Pfizer" };
            ciudadanos.Add(new Ciudadano(nombre, cedula, vacunas));
        }

        // Crear 75 ciudadanos con solo AstraZeneca
        for (int i = 76; i <= 150; i++)
        {
            string nombre = "Ciudadano " + i;
            string cedula = "C" + i;

            // Solo AstraZeneca
            HashSet<string> vacunas = new HashSet<string> { "AstraZeneca" };
            ciudadanos.Add(new Ciudadano(nombre, cedula, vacunas));
        }

        // Crear 100 ciudadanos con ambas vacunas
        for (int i = 151; i <= 250; i++)
        {
            string nombre = "Ciudadano " + i;
            string cedula = "C" + i;

            // Ambas vacunas
            HashSet<string> vacunas = new HashSet<string> { "Pfizer", "AstraZeneca" };
            ciudadanos.Add(new Ciudadano(nombre, cedula, vacunas));
        }

        // Crear los ciudadanos no vacunados (resto hasta 500)
        for (int i = 251; i <= 500; i++)
        {
            string nombre = "Ciudadano " + i;
            string cedula = "C" + i;

            // No vacunados
            HashSet<string> vacunas = new HashSet<string>();
            ciudadanos.Add(new Ciudadano(nombre, cedula, vacunas));
        }

        // Crear conjuntos para las tres categorías: solo Pfizer, solo AstraZeneca, ambas vacunas
        HashSet<Ciudadano> soloPfizer = new HashSet<Ciudadano>();
        HashSet<Ciudadano> soloAstraZeneca = new HashSet<Ciudadano>();
        HashSet<Ciudadano> ambasVacunas = new HashSet<Ciudadano>();
        HashSet<Ciudadano> noVacunados = new HashSet<Ciudadano>();

        // Recorrer el conjunto de ciudadanos y categorizar
        foreach (var ciudadano in ciudadanos)
        {
            if (ciudadano.Vacunas.Contains("Pfizer") && ciudadano.Vacunas.Contains("AstraZeneca"))
            {
                // Ambas vacunas
                ambasVacunas.Add(ciudadano);
            }
            else if (ciudadano.Vacunas.Contains("Pfizer"))
            {
                // Solo Pfizer
                soloPfizer.Add(ciudadano);
            }
            else if (ciudadano.Vacunas.Contains("AstraZeneca"))
            {
                // Solo AstraZeneca
                soloAstraZeneca.Add(ciudadano);
            }
            else
            {
                // No vacunados
                noVacunados.Add(ciudadano);
            }
        }

        // Mostrar los resultados
        Console.WriteLine("\nCiudadanos con ambas vacunas:");
        if (ambasVacunas.Count == 0)
        {
            Console.WriteLine("No hay ciudadanos con ambas vacunas.");
        }
        else
        {
            foreach (var ciudadano in ambasVacunas)
            {
                Console.WriteLine($"{ciudadano.Nombre} - {ciudadano.Cedula}");
            }
        }

        Console.WriteLine("\nCiudadanos con solo Pfizer:");
        if (soloPfizer.Count == 0)
        {
            Console.WriteLine("No hay ciudadanos con solo Pfizer.");
        }
        else
        {
            foreach (var ciudadano in soloPfizer)
            {
                Console.WriteLine($"{ciudadano.Nombre} - {ciudadano.Cedula}");
            }
        }

        Console.WriteLine("\nCiudadanos con solo AstraZeneca:");
        if (soloAstraZeneca.Count == 0)
        {
            Console.WriteLine("No hay ciudadanos con solo AstraZeneca.");
        }
        else
        {
            foreach (var ciudadano in soloAstraZeneca)
            {
                Console.WriteLine($"{ciudadano.Nombre} - {ciudadano.Cedula}");
            }
        }

        Console.WriteLine("\nCiudadanos no vacunados:");
        if (noVacunados.Count == 0)
        {
            Console.WriteLine("No hay ciudadanos no vacunados.");
        }
        else
        {
            foreach (var ciudadano in noVacunados)
            {
                Console.WriteLine($"{ciudadano.Nombre} - {ciudadano.Cedula}");
            }
        }
    }
}
