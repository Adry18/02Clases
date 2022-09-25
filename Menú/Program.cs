
internal class Program
{
    private static void Main(string[] args)
    {
        {

            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" MENÚ ");
                Console.WriteLine(" \n " +
                    " \n 1.- Ejercicio 1 " +
                    " \n 2.- Ejercicio 2  " +
                    " \n 3.- Ejercicio 3  " +
                    " \n 4. - Salir \n ");
                Console.WriteLine(" Introduzca una opción : ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(" Este es el ejercicio de fechas ");
                        break;
                    case 2:
                        Console.WriteLine(" Este es el ejercicio de la libreria");
                        break;
                    case 3:
                        Console.WriteLine(" Este es el ejercicio de los barcos ");
                        break;
                    case 4:
                        Console.WriteLine(" Usted esta saliendo ");
                        break;
                }
                Console.ReadKey();
            } while (opcion > 4);
        }
    }
}