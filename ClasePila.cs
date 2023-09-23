using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoy
{
    //
    //
    public class ClasePila
    {
        //
        private readonly int Max;
        private int Top;
        private int[] Arreglo;

        //Constructor
        public ClasePila(int Tamaño)
        {
            Top = 0;
            Max = Tamaño;
            Arreglo = new int[Tamaño];
        }
        //
        private bool EstaLlena()
        {
            if(Top==Max)
                return true;
            else 
                return false;
        }
        //
        private bool EstaVacia()
        {
            if(Top==0)
                return true;
            else
                return false;
        }
        //
        public bool Push(int dato)
        {
            if (!EstaLlena())
            {
                Arreglo[Top] = dato;
                Top++;
                return true;
            }
            else 
                return false;
        }
        //
        public bool Pop() 
        {
            if (!EstaVacia())
            {
                Top --;
                return true;
            }
            else
                return false;
        }
        //
        public string Mostrar()
        {
            string Resultado = "\n";
            if (!EstaVacia()) 
            {
                //
                for(int i = 0; i<=Top -1 ; i++)
                    Resultado = Resultado + "\n[" +i.ToString() +"] ->" + Arreglo[i].ToString();
            }
            else
                Resultado = "\n Cola Vacia";

            Resultado = Resultado + "\n\nTop = " + Top.ToString();
            Resultado = Resultado + "\n\nMax = " + Max.ToString();
            return (Resultado);
        }
        public void Vaciar()
        {
            
            Top = -1;
        }
    }
}
