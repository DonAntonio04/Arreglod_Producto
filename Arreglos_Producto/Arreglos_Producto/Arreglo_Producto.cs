using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Producto
{
    public class Arreglo_Producto
    {
        Producto[] productos = new Producto[4];

        public void Insertar(Producto valor, int posicion)
        {
            if(posicion < -1 || posicion > productos.Length)
            {
                Console.WriteLine("No puedes ingresar ese dato");
            }
            Console.WriteLine($"Se ingreso el nombre: {valor.Nombre} y el precio: {valor.Precio}");
            productos[posicion] = valor;
        }
        public void OrdenarCreciente()
        {
            for(int i = 0; i < productos.Length - 1; i++)
            {
                for(int j = 0; j < productos.Length - i - 1; j++)
                {
                    if (productos[j]?.Precio > productos[j + 1]?.Precio)
                    {
                        Producto temp = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = temp;
                    }
                   
                }
            }
        }
        public void Mostrar()
        {
            for(int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"Posición {i}: {productos[i]}");
            }
        }
        public void BuscarPrecio(int precio)
        {
            bool encontrado = false;
            for(int i = 0; i < productos.Length;i++)
            {
                if (productos[i]?.Precio == precio)
                {
                    Console.WriteLine($"El precio se se encuentra en la posicion: {i}");
                    encontrado = true;
                    break;
                }
            }
            if(!encontrado)
            {
                Console.WriteLine("No se encuentra ese precio");
            }
        }
    }
}
