using System;
namespace Arreglos_Producto
{
    class Program
    {
        static void Main(string[] args)
        {
            Arreglo_Producto arregloProducto = new Arreglo_Producto();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese los datos para el producto {i + 1}");

                Console.Write("Nombre del producto: ");
                string nombre = Console.ReadLine();

       
                Console.Write("Precio del producto: ");
                int precio = Convert.ToInt32(Console.ReadLine());

       
                Producto nuevoProducto = new Producto(nombre, precio);

                Console.Write("Posición en el arreglo: ");
                int posicion = Convert.ToInt32(Console.ReadLine());

            
                arregloProducto.Insertar(nuevoProducto, posicion);
            }


            Console.WriteLine("Arreglo antes de ordenar:");
            arregloProducto.Mostrar();

   
            arregloProducto.OrdenarCreciente();


            Console.WriteLine("Arreglo después de ordenar:");
            arregloProducto.Mostrar();

          
            Console.Write("Ingrese un precio para buscar: ");
            int precioBuscar = Convert.ToInt32(Console.ReadLine());

            arregloProducto.BuscarPrecio(precioBuscar);

        
        }
    }
}