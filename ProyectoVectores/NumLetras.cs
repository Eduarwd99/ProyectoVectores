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
            int num0, num1, num2;
            string numS1 = num.ToString();
            string numS2 = num.ToString();
            string numS0 = num.ToString();
            string aux0 = "", aux1 = "", aux2 = "";

            if(num>=1000 && num<10000)
            {
                int.TryParse(numS1.Substring(0, 1), out num1);
                aux1 = getMax999(num1) + " Mil ";
                if (num1 == 1)
                    aux1 = "Mil ";

                int.TryParse(numS2.Substring(1, 3), out num2);
                aux2 = getMax999(num2);
                if (num2 == 0)
                    aux2 = "";

                return aux1 + aux2;
            }
            else if(num >= 10000 && num < 100000)
            {
                int.TryParse(numS1.Substring(0, 2), out num1);
                aux1 = getMax999(num1) + " Mil ";
                if (num1 == 1)
                    aux1 = "Mil ";

                int.TryParse(numS2.Substring(2, 3), out num2);
                aux2 = getMax999(num2);
                if (num2 == 0)
                    aux2 = "";

                return aux1 + aux2;
            }
            else if (num >= 100000 && num < 1000000)
            {                
                int.TryParse(numS1.Substring(0, 3), out num1);
                aux1 = getMax999(num1) + " Mil ";
                if (num1 == 1)
                    aux1 = "Mil ";

                int.TryParse(numS2.Substring(3, 3), out num2);
                aux2 = getMax999(num2);
                if (num2 == 0)
                    aux2 = "";

                return aux1 + aux2;
            }
            else
            {                
                int.TryParse(numS0.Substring(0, 1), out num0);
                aux0 = getMax999(num0) + " Millon ";
                if (num0 == 1)
                    aux0 = "Un Millon ";

                int.TryParse(numS1.Substring(1, 3), out num1);
                aux1 = getMax999(num1) + " Mil ";
                if (num1 == 0)
                    aux1 = "";
                if (num1 == 1)
                    aux1 = "Mil ";

                int.TryParse(numS2.Substring(4, 3), out num2);
                aux2 = getMax999(num2);
                if (num2 == 0)
                    aux2 = "";

                return aux0 + aux1 + aux2;
            }
        }

        public static string getMax999(int num)
        {
            string aux = "";
            if (num < 20)
                aux = getUnidades(num);
            else if (num >= 20 && num < 100)
                aux = getDecenas(num);
            else if (num >= 100 && num < 1000)
                aux = getCentenas(num);
            return aux;
        }

        public static string getLetras(int num)
        {
            string aux = "";
            if(num > 0 && num < 1000)
                aux = getMax999(num);
            else if(num >= 1000)
                aux = getMilesimas(num);
            else if(num == 0)
                aux = "Cero";
            else if(num < 0 || num > 9999999)
                aux = "ERROR : El numero ingresado no pertenece al conjunto establecido (0 - 9999999)";
            return aux;
        }
    }
}
