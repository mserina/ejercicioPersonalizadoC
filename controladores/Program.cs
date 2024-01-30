using ejercicioExamenPersonalizado.servicios;

namespace ejercicioExamenPersonalizado.controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[7];
            List<int> listaNumeros = new List<int>();
            Random rand = new Random();
            OperacionInterfaz op = new OperacionImplementacion();
            op.pedirNumeros(listaNumeros);
            op.mostrarLista(listaNumeros);
            listaNumeros.Sort();
            listaNumeros.Reverse();
            Console.WriteLine(" ");
            op.mostrarLista(listaNumeros);

            //ARRAY
            Console.WriteLine(" ");
            op.asignarNumerosArray(arrayNumeros, rand);
            Console.WriteLine(" ");
            op.ordenarBurbuja(arrayNumeros);
            Console.WriteLine(" ");
            op.añadirAntePenultimaPosicion(arrayNumeros);
            Console.WriteLine(" ");
            op.filtroMayorQue(arrayNumeros);
            Console.WriteLine(" ");
            op.PosicionYAñadir(arrayNumeros);
            Console.WriteLine(" ");
            op.mostrarAray(arrayNumeros);





        }
    }
}