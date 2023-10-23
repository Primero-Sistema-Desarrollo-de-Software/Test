using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Practica.Clases
{
    public class ProductClass
    {
        private string Product_Id { get; set; }
        private string ProductName { get; set; }
        private string ProductCategory { get; set; }
        private float ProductPrice { get; set; }
        private bool ProductState { get; set; } = true;

        private void GenerateID()
        {
            var newGuid = Guid.NewGuid().ToString("N").Substring(0, 6);
            Product_Id = newGuid;
        }

        public void AddProduct()
        {
            this.GenerateID();
            Console.WriteLine("Ingrese los Datos Solicitados");
            Console.WriteLine("Ingrese el Nombre del Producto");
            ProductName = Console.ReadLine();
            Console.WriteLine("Ingrese el Categoria del Producto");
            ProductCategory = Console.ReadLine();
            Console.WriteLine("Ingrese el Precio del Producto");
            ProductPrice = float.Parse(Console.ReadLine());
        }

        public void GetProduct()
        {
            Console.WriteLine("Los Datos del Producto son:");
            Console.WriteLine("El Id del Producto es: " + Product_Id);
            Console.WriteLine("El Nombre del Producto es: " + ProductName);
            Console.WriteLine("La Categoria del Producto es: " + ProductCategory);
            Console.WriteLine("El Precio del Producto es: " + ProductPrice);
            Console.WriteLine("El Estado del Producto es: " + ProductState);
        }
    }
}
