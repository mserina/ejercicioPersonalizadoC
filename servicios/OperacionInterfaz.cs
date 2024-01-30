using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioExamenPersonalizado.servicios
{
    internal interface OperacionInterfaz
    {
        public void pedirNumeros(List<int> listaNumeros);

        public void mostrarLista(List<int> listaNumeros);

        public void asignarNumerosArray(int[] arrayNumeros, Random rand);
       
        public void ordenarBurbuja(int[] arrayNumeros);

        public void añadirAntePenultimaPosicion(int[] arrayNumeros);

        public void filtroMayorQue(int[] arrayNumeros);

        public void PosicionYAñadir(int[] arrayNumeros);

        public void mostrarAray(int[] arrayNumeros);
    }
}
