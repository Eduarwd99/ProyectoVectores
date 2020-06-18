using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVectores
{
    public class NumLetras
    {
        private static string[] unidades = new string[] {"", "Uno", "Dos", "Tres",
        "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once",
        "Doce", "Trece", "Catorce", "Quince", "Diesciseis", "Diescisiete", "Diesciocho","Diescinueve"};

        private static string[] decenas = new string[] {"","Diez", "Veinte", "Treinta",
        "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa"};

        private static string[] centenas = new string[] {"","Ciento", "Doscientos", "Trescientos",
        "Cuatrocientos","Quinientos", "Seiscientos", "Setecientos", "Ochocientos", "Novecientos"};

        public static string getUnidades(int num)
        {
            string aux = "";
            aux = unidades[num];
            return aux;
        }

        public static string getDecenas(int num)
        {
            string aux = "";
            aux = decenas[num / 10];
            if (num % 10 != 0)
                aux = aux + " y " + unidades[num % 10];            
            return aux;
        }

        public static string getCentenas(int num)
        {
            string aux = "";
            aux = centenas[num / 100];
            if (num % 100 < 20)
                aux = aux + " " + getUnidades(num % 100);
            else
                aux = aux + " " + getDecenas(num % 100);
            
            if (num == 100)
                aux = "Cien";
            return aux;
        }

        public static string getMilesimas(int num)
        {
            int num1 = 0, num2 = 0;
            string numS1 = num.ToString();
            string numS2 = num.ToString();
            string aux1 = "", aux2 = "";

            num1 = int.Parse(numS1.Substring(0, 2));
            num2 = int.Parse(numS2.Substring(3, 5));

            if (num1 < 20)
                aux1 = getUnidades(num1);
            else if (num1 >= 20 && num1 < 100)
                aux1 = getDecenas(num1);
            else if (num1 >= 100 && num1 < 1000)
                aux1 = getCentenas(num1);

            if (num2 < 20)
                aux2 = getUnidades(num2);
            else if (num2 >= 20 && num2 < 100)
                aux2 = getDecenas(num2);
            else if (num2 >= 100 && num2 < 1000)
                aux2 = getCentenas(num2);

            if (num2 == 0)
                aux2 = "";

            return aux1 + " Mil  " + aux2;
        }

        public static string getLetras(int num)
        {
            string aux = "";
            if (num < 20)
                aux = getUnidades(num);
            else if (num >= 20 && num < 100)
                aux = getDecenas(num);
            else if (num >= 100 && num < 1000)
                aux = getCentenas(num);
            else if (num >= 1000 && num < 1000000)
                aux = getMilesimas(num);

            if(num == 0)
                aux = "Cero";

            return aux;
        }
    }
}
