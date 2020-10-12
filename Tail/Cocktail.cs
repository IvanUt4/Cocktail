using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tail
{
    class Cocktail

    {
        int[,] matrizOriginal = { 
            {45,49,30,1,2 },
            {34,123,100,4,3}
        
        };

        int []auxiliar = new int[10];
        public Cocktail()
        {
            
            mostrarMatriz();
            Console.ReadKey();



            llenarArray();
            Console.WriteLine();


            mostrarArray();
            Console.WriteLine();

            orden();
            Console.WriteLine();

            mostrarArray();
            Console.ReadKey();

            Console.WriteLine();
            colocarValoresEnMatriz();
            Console.WriteLine();
            mostrarMatriz();
        }

        public void orden()
        {
            int end = auxiliar.Length -1;
            int start = 0;
            bool ordenado = true;
            int aux = 0;
            do
            {
                ordenado = true;
                for (int i = start; i < end; i++)
                {
                    if(auxiliar[i]> auxiliar[i + 1])
                    {
                        aux = auxiliar[i];
                        auxiliar[i] = auxiliar[i+1];
                        auxiliar[i + 1] = aux;
                        ordenado = false;
                        
                    }
                }
                if (!ordenado)
                {
                    for (int i = end; i > start; i--)
                    {
                        if (auxiliar[i] < auxiliar[i - 1])
                        {
                            aux = auxiliar[i];
                            auxiliar[i] = auxiliar[i - 1];
                            auxiliar[i - 1] = aux;
                            ordenado = false;
                          
                        }
                    }
                    end--;
                    start++;
                }
            } while (!ordenado);

        }

        public void mostrarMatriz()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrizOriginal[i,j]+" ");
                }
                Console.WriteLine();
            }
        }


        public void llenarArray()
        {
            int indice = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    auxiliar[indice] = matrizOriginal[i, j];
                    indice++;
                }
                
            }
        }
        public void mostrarArray()
        {
            foreach (int x in auxiliar)
            {
                Console.Write(x+" ");
            }
        }

        public void colocarValoresEnMatriz()
        {
            int indice = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrizOriginal[i, j] = auxiliar[indice];
                    indice++;
                }

            }
        }
    }
}
