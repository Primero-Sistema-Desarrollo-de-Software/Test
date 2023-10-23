using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Practica.Clases;

namespace POO_Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductClass product = new ProductClass();
            int Resultado = 0;
            do
            {
                Console.WriteLine("Catalogo de Productos");
                Console.WriteLine("");
                Console.WriteLine("1.- Agregar un Producto");
                Console.WriteLine("2.- Visualizar un Producto");
                Console.WriteLine("3.- Salir");
                Console.WriteLine("");
                Console.Write("Opcion: ");
                Resultado = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (Resultado)
                {
                    case 1:
                        product.AddProduct();
                        break;
                    case 2:
                        product.GetProduct();
                        break;
                    case 3:
                        Console.WriteLine("Fin de la operacion");
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("ERROR, Opcion Invalida...");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Console.Clear();
                        break;
                }

            } while (Resultado != 3);


        }
    }
}
