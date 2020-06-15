using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVectores
{
    public class NumLetras
    {
        private static string[] unidades = new string[] {"cero", "uno", "dos", "tres",
        "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once",
        "doce", "trece", "catorce", "quince", "diesciseis", "diescisiete", "diesciocho","diescinueve"};

        private static string[] decenas = new string[] {"diez", "viente", "treinta",
        "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"};

        private static string[] centenas = new string[] {"cien", "doscientos", "trescientos",
        "cuatrocientos","quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"};
    
        public static string getLetras(int num)
        {
            string aux = "";
            if (num < 20)
                aux = unidades[num];
            else if (num < 100 && num >= 20) //tarea
                aux = decenas[(num/10)-1];
            return aux;
        }
    }
}
