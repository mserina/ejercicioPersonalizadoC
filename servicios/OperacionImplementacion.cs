using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioExamenPersonalizado.servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void pedirNumeros(List<int> listaNumeros)
        {
            bool cerrarBucle = false;
            while (!cerrarBucle) 
            {
                Console.WriteLine("Inserte un numero");
                listaNumeros.Add (Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Quiere seguir insertando numeros s/n");
                string respuestaUsuario = Console.ReadLine();

                if(respuestaUsuario == "n")
                {
                    cerrarBucle=true;
                }
            }
        }

        public void mostrarLista(List<int> listaNumeros)
        {
            Console.WriteLine(" ");
            foreach(int numeros in listaNumeros)
            {
                Console.WriteLine(numeros);
            }
        }

        public void ordenarAscendenteList(List<int> listaNumeros)
        {
            listaNumeros.Sort();
       
        }

        public void asignarNumerosArray(int[] arrayNumeros, Random rand)
        {
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = rand.Next(1, 100);
            }

            foreach (int numeros in arrayNumeros)
            {
                Console.WriteLine(numeros.ToString());
            }
        }

        public void ordenarBurbuja(int[] arrayNumeros)
        {
            for(int i = 0; i < arrayNumeros.Length -1; i++)
            {
                for (int j = 0; j < arrayNumeros.Length -1 -i; j++)
                {
                    if (arrayNumeros[j] > arrayNumeros[j + 1])
                    {
                        int aux = arrayNumeros[j];
                        arrayNumeros[j] = arrayNumeros[j + 1];
                        arrayNumeros[j + 1] = aux;
                    }
                }
            }

            foreach(int numeros in arrayNumeros)
            {
                Console.WriteLine(numeros);
            }
            
        }

        public void añadirAntePenultimaPosicion(int[] arrayNumeros)
        {
            Console.WriteLine(arrayNumeros[0]);
            Console.WriteLine(arrayNumeros[4]);
            Console.WriteLine(arrayNumeros[6]);
        }

        public void filtroMayorQue(int[] arrayNumeros)
        {
            arrayNumeros.Where(x => x > 45);

            foreach (int numeros in arrayNumeros)
            {
                Console.WriteLine(numeros);
            }
        }

        public void PosicionYAñadir(int[] arrayNumeros)
        {
            arrayNumeros[4] = 23;
        }

        public void mostrarAray(int[] arrayNumeros)
        {
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine(arrayNumeros[i]);
            }
        }
    }
}
