using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase1_vector_pgIIIA.clases
{
    public class Vector
    {
        public double[] notas;
        public int contador = 0;

        public void cargar(int tamanioVector)
        {
            notas = new double[tamanioVector];
        }

        public string IngresarDatosVector(double valor)
        {
            notas[contador] = valor;
            contador = contador + 1;
            return "El dato fue ingresado correctamente";
        }

        public double retornarValor(int posicion)
        {
            return notas[posicion];
        }
        public string asignarValor(int posicion, double valor)
        {
            notas[posicion] = valor;
            return "El dato fue modificado en la posicion." + posicion;
        }
    }
}
