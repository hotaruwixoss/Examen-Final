using System;

namespace Examen_Final
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] products = { "Galleta oreo", "Coca cola" , "Agua", "Gomitas", "Papitas lays" ,
                "Malta morena" };
            int i = 0;
            for( i = 0; i > products.Length; i++)
            {
                Console.WriteLine(i);
            }
           
            

            Console.WriteLine("Digita un numero para seleccionar alguno de los productos: " );
            int select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    Console.WriteLine("Galleta oreo");
                    break;
                case 2:
                    Console.WriteLine("Coca cola");
                    break;
                case 3:
                    Console.WriteLine("Agua");
                    break;
                case 4:
                    Console.WriteLine("Gomitas");
                    break;
                case 5:
                    Console.WriteLine("Papitas lays");
                    break;
                case 6:
                    Console.WriteLine("Malta morena");
                    break;

               
            }
            do 
                {
                double[] moneda = { 5, 10, 15 };
                double[] billete = { 50, 100, 200 };

                Console.WriteLine("Puede pagar en monedas o en billetes:");
                double dinero = Convert.ToDouble(Console.ReadLine());
                for (int e = 0; e > moneda.Length; e++)
                {
                    if (dinero != moneda[e])
                    {
                        Console.WriteLine("Vuelve a intentarlo");
                    }

                    if (dinero != billete[e])
                    {
                        Console.WriteLine("Vuelve a intentarlo");
                    }

                    else
                    {
                        Console.WriteLine("Uste ha comprado un producto.");
                        break;
                    }
                }
                
            
            } while (i > 3);



        }
    }
    class Producto: Program

    {
        string nombre;
        double precio;
        int existencia;

    }

}
