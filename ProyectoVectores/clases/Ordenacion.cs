using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVectores.clases
{
    public class Ordenacion
    {
        public static int[] ordenaSeleccion(int[] vector, int tamanio)
        {
            int aux = 0;

            for(int i=0; i<tamanio;i++)
                for(int j=i+1; j<tamanio; j++)
                    if(vector[i]>vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }

            return vector;
        }
    }
}
