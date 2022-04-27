using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kerítés
{
    class Program
    {
        class Telek
        {
            public string paritas;
            public int szelesseg;
            public string szin;
            public int hazszam;

            public static int paros = 0; // nem az egyes telkek tulajdonsága, hanem az összes telek közös tulajdonsága, hogy hol tart a számozás!
            // static int paros = 0; // ha classon belül használjuk csak, ez is jó!
            public static int paratlan = -1;

            public static List<Telek> lista = new List<Telek>();
            public static List<Telek> parosak = new List<Telek>();
            public static List<Telek> paratlanok = new List<Telek>();

            public Telek(string[] sortömb)
            {
                this.paritas = sortömb[0];
                this.szelesseg = int.Parse(sortömb[1]);
                this.szin = sortömb[2];

                if (this.paritas == "0")
                {
                    this.hazszam = paros + 2;
                    paros += 2;
                    Telek.parosak.Add(this);
                }
                else
                {
                    this.hazszam = paratlan + 2;
                    paratlan += 2;
                    Telek.paratlanok.Add(this);
                }

                Telek.lista.Add(this);
            }
        static void Main(string[] args)
        {
                string[] sorok = File.ReadAllLines("kerites.txt");





                foreach (string sor in sorok)
                {
                    string[] sortömb = sor.Split(' ');
                    Telek t = new Telek(sortömb);

                    /** / //Itt is lehet
                    Telek.lista.Add(t);
                    if (t.paritas=="0")
                    {
                        Telek.parosak.Add(t);
                    }
                    else
                    {
                        Telek.paratlanok.Add(t);
                    }
                    /**/
                }

                /* itt jöhetnek a feladatok!*/
                Console.WriteLine("2. feladat");
                Console.WriteLine($"Az eladott telkek száma: {Telek.lista.Count}");
            }
    }
}
