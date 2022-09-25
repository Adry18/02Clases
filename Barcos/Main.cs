using System;

public class main
{

    public static void Main(string[] args)
    {
        Barco olympic = new Barco(500, "1565-FHD", 8, 2003);

        Cliente Pepe = new Cliente("Pepe", "18088821-B", 569874126);

        Alquiler alquilerPepe = new Alquiler(Pepe, 23, 5, 2015, 29, 5, 2015, 23, olympic);

        Console.WriteLine(alquilerPepe.ToString() + "\n");

        Console.WriteLine(olympic.ToString());

        alquilerPepe.calculaPrecioAlquiler(olympic);

        Console.WriteLine("\n----------------------------------------------");

        Console.Write("Precio del amarre: {0:F2}€\n", olympic.calculaPrecioAmarre());

        Console.Write("Precio del alquiler: {0:F2}€\n", alquilerPepe.getPrecioAlquiler());
    }
}

