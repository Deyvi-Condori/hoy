using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoy
{
    internal class Program
    {
        //
        static ClasePila Pila = new ClasePila(10);
        static void Main(string[] args)
        {
            int opcion = 0;
            do 
            {
                Console.Clear();
                Console.WriteLine("Pilas - Arreglos");
                Console.WriteLine("******************");
                Console.WriteLine("\n1. Insertar Dato (Push)");
                Console.WriteLine("*2. Eliminar Dato(Pop)*");
                Console.WriteLine("*3. Mostrar Dato en Pila*");
                Console.WriteLine("*4. Eliminar Dato de la Pila*");
                Console.WriteLine("0. Salir");
                Console.Write("\n \nOpcion : ");
                opcion=int.Parse(Console.ReadLine());
                switch(opcion) 
                {
                    case 1: InsertarEnPila(); break; 
                    case 2: EliminarEnPilas(); break;
                    case 3: MostrarDatos(); break;
                    case 4: VaciarPilas(); break;
                }
            }while(opcion!=0);
        }
        //
        public static void InsertarEnPila()
        {
            int Dato = 0;
            Console.Clear();
            Console.WriteLine("Insertar dato en Pila");
            Console.Write("Numero entero : ");
            Dato = int.Parse(Console.ReadLine());
            //
            if (Pila.Push(Dato))
                Console.WriteLine("Dato insertado en la Pila...!");
            else
                Console.WriteLine("\nPila llena...!");
            Console.ReadKey();
        }
        //
        public static void EliminarEnPilas() 
        {
            Console.Clear();
            Console.WriteLine("Eliminar dato en Pila");
            Console.Write("Numero entero : ");
            //
            if (Pila.Pop())
                Console.WriteLine("Dato eliminado en la Pila...!");
            else
                Console.WriteLine("\nPila vacia...!");
            Console.ReadKey();
        }
        // 
        public static void MostrarDatos()
        {
            Console.Clear();
            Console.WriteLine("Datos almacenados en la Pila");
            //
            Console.WriteLine(Pila.Mostrar());
            Console.ReadKey();
        }
        //
        public static void VaciarPilas() 
        {
            char sn;
            Console.Clear();
            Console.WriteLine("Eliminar la Pila");
            //
            do 
            {
                Console.Write("Esta seguro de desear vaciar la Pila");
                Console.WriteLine(" ");
                sn = char.Parse(Console.ReadLine());
                sn = Char.ToUpper(sn);


            }while(sn!= 'S' && sn!= 'N');
            if (sn == 'S')
            {
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
