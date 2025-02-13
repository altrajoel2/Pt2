using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
         // Crear llistes per a cada tipus de vehicle
        List<Vaixell> vaixells = new List<Vaixell>
        {
            new Vaixell("Explorer", "OceanX", 2015, 45, 12000),
            new Vaixell("Voyager", "BlueWave", 2020, 60, 15000),
            new Vaixell("Destructor","Acer",2021,23,20000),
            new Vaixell("Portavions","Acer",2025,21,2000),
            new Vaixell("Canoa","de alguna empresa",2015,23,3221),
            new Vaixell("Titanic","alguna empresa",1936,24,2122),
            new Vaixell("Yate","Oceans",2021,23,214232)
        };

        List<Cotxe> cotxes = new List<Cotxe>
        {
            new Cotxe("Model S", "Tesla", 2022, 250, 4),
            new Cotxe("Civic", "Honda", 2019, 220, 4),
            new Cotxe("BIO23","Vil",2023,200,4),
        };

        List<Cotxe> cotxes2=new List<Cotxe>
        {
            new Cotxe("Cord","Goldo",2018,24,2),
            new Cotxe("Cotxe volador","future",2025,26,4)
        };

        List<Camio> camions = new List<Camio>
        {
            new Camio("Actros", "Mercedes", 2021, 120, 18000),
            new Camio("FH16", "Volvo", 2018, 110, 25000),
        };

        // Mostrar informació de cada tipus de vehicle
        Console.WriteLine("Llista de Vaixells:");
        foreach (var vaixell in vaixells)
        {
            vaixell.MostrarInformacio();
        }

        Console.WriteLine("\nLlista de Cotxes:");
        foreach (var cotxe in cotxes)
        {
            cotxe.MostrarInformacio();
        }

        Console.WriteLine("\nLlista de Camions:");
        foreach (var camio in camions)
        {
            camio.MostrarInformacio();
        }
    }
}
