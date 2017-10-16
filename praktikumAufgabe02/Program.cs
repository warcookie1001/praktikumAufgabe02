using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikumAufgabe02
{
    class Program
    {
        static void Main(string[] args)
        {
            String aStr, bStr, cStr;
            int a, b, c;

            Console.WriteLine("Bitte Werte in der Form ax^2 + bx + c = 0  eingeben");
            Console.WriteLine();
            Console.Write("a=");    //Einlesen der Werte als String
            aStr = Console.ReadLine();
            Console.Write("\r\nb=");
            bStr = Console.ReadLine();
            Console.Write("\r\nc=");
            cStr = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();


            a = Convert.ToInt32(aStr);  //Casten der eingelesenen Werte zu int
            b = Convert.ToInt32(bStr);
            c = Convert.ToInt32(cStr);

            if (a == 0 & b == 0)        //Fall 1: Keine Lösung Möglich
            {
                Console.WriteLine("Fehlerhafte Eingabewerte.");
                Console.WriteLine("Es kann keine Lösung berechnet werden");
            }
            else if (a == 0)            //Fall 2: Lineare Gleichung
            {
                BerechneLineareGleichung(b, c);
            }
            else
            {
                BerechneQuadratischeGleichung(a, b, c); //Fall 3: Quadratische Gleichung
            }



            Console.ReadLine();
        }


        static void BerechneLineareGleichung(int b, int c) {
            double nullstelle;

            nullstelle = (double) c / b;

            Console.WriteLine("Die Nullstelle der Linearen Gleichung:");
            Console.WriteLine("x = " + nullstelle);
        }


        static void BerechneQuadratischeGleichung(int a, int b, int c)
        {
            double nullstelle1, nullstelle2, determinante;

            determinante = (double) b*b - 4 * a * c;

            if (determinante < 0)
            {
                Console.WriteLine("Die Gleichung enthält nur Lösungen im komplexen Bereich");
                Console.WriteLine("Es kann keine Lösung berechnet werden");
            }
            else if (determinante == 0)
            {
                nullstelle1 = (double) - b / (2 * a);

                Console.WriteLine("Die quadratische Gleichung enthält eine Nullstelle:");
                Console.WriteLine("x = " + nullstelle1);
            }
            else
            {
                nullstelle1 = (-b + Math.Sqrt(determinante)) / (2 * a);
                nullstelle2 = (-b - Math.Sqrt(determinante)) / (2 * a);

                Console.WriteLine("Die quadratische Gleichung enthält zwei Nullstellen:");
                Console.WriteLine("x1 = " + nullstelle1);
                Console.WriteLine("x2 = " + nullstelle2);
            }
        }

    }
}
