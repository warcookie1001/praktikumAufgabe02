using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// In diesem Programm wird eine quadratische Gleichung in der Form ax^2+bx+c=0 gelöst.
/// 
/// In der Main-Funktion werden die Werte eingelesen und nach drei Fällen
/// (nicht lösbar/lineare Gleichung/quadratische Gleichung) unterschieden. Die letztendliche Berechnung
/// wird in zwei einzelnen Funktionen (lineare oder quadratische Gleichung) ausgeführt.
/// </summary>

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
            Console.WriteLine("\r\n\r\n");    //zwei Leerzeilen zur besseren Lesbarkeit



            a = Convert.ToInt32(aStr);  //casten der eingelesenen Werte zu int
            b = Convert.ToInt32(bStr);
            c = Convert.ToInt32(cStr);

            if (a == 0 & b == 0)        //Fall 1: Keine Lösung möglich
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

            nullstelle = (double) - c / b;    //Lösung einer linearen Gleichung

            Console.WriteLine("Die Nullstelle der Linearen Gleichung:");
            Console.WriteLine("x = " + nullstelle); 
        }




        static void BerechneQuadratischeGleichung(int a, int b, int c)  //Funktion zur Berechnung der quadratischen Gleichung
        {
            double nullstelle1, nullstelle2, diskriminante;

            diskriminante = (double) b*b - 4 * a * c;  //Berechnung der Diskriminante

            if (diskriminante < 0)          //D<0: Nur komplexe Lösungen, keine weitere Berechnung
            {
                Console.WriteLine("Die Gleichung enthält nur Lösungen im komplexen Bereich");
                Console.WriteLine("Es kann keine Lösung berechnet werden");
            }
            else if (diskriminante == 0)    //D==0: eine Nullstelle
            {
                nullstelle1 = (double) - b / (2 * a);

                Console.WriteLine("Die quadratische Gleichung enthält eine Nullstelle:");
                Console.WriteLine("x = " + nullstelle1);
            }
            else                            //D>0: zwei reelle Nullstellen
            {
                nullstelle1 = (-b + Math.Sqrt(diskriminante)) / (2 * a);    //Berechnung Nullstelle 1
                nullstelle2 = (-b - Math.Sqrt(diskriminante)) / (2 * a);    //Berechnung Nullstelle 2

                Console.WriteLine("Die quadratische Gleichung enthält zwei Nullstellen:");
                Console.WriteLine("x1 = " + nullstelle1);
                Console.WriteLine("x2 = " + nullstelle2);
            }
        }

    }
}
