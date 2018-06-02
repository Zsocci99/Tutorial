using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Létrehozás
            int A5 = 0;
            int A6 = 0;
            int A7 = 0;
            int A8 = 0;
            int A9 = 0;
            int S0 = 0;
            int S1 = 0;
            int S2 = 0;
            int S3 = 0;
            int S4 = 0;
            #endregion
            S1:
            Console.Clear();
            Console.WriteLine("-C#-");
            Console.WriteLine("Változók: 1");
            Console.WriteLine("Vissza lépés: 0");
            S1 = Convert.ToInt32(Console.ReadLine());
            switch (S1)
            {
                case 1://Változók
                    S0:
                    Console.Clear();
                    Console.WriteLine("-C#-");
                    Console.WriteLine("--Változók--");
                    Console.WriteLine("Logikai: 1");
                    Console.WriteLine("Szám: 2");
                    Console.WriteLine("Karakteres: 3");
                    Console.WriteLine("Vissza lépés: 0");
                    S0 = Convert.ToInt32(Console.ReadLine());
                    switch (S0)
                    {
                        case 1://Logical/ Bool
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Bool:\n"); Console.ResetColor();
                                Console.WriteLine("A Bool egy logikai típusú változó.\nMérete 1 byte.");
                                Console.WriteLine("A logikai típus értéke a true vagy false értéket veheti fel.");
                                Console.WriteLine("Deklarálása:\nbool (NÉV) = (true/false);");
                                Console.WriteLine("PL:\nbool Boolean = true;\nBoolean = false;");
                                break;
                            }
                            
                        case 2://Numerical
                            {
                            A9:
                                Console.Clear();
                                Console.WriteLine("-C#-");
                                Console.WriteLine("--Változók--");
                                Console.WriteLine("---Numerical---");
                                Console.WriteLine("Byte: 1");
                                Console.WriteLine("Vissza lépés: 0");
                                A9 = Convert.ToInt32(Console.ReadLine());

                                switch (A9)
                                {
                                    case 1:
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Byte:\n"); Console.ResetColor();
                                            Console.WriteLine("A Byte egy olyan szám tipusú változó amely 0 és 255 között képes tárolni számokat.\nMérete 1 byte");
                                            Console.WriteLine("A Byte 1 byton az az 8 biten tárol csak pozitív számokat(0-255).");
                                            Console.WriteLine("Deklarálása:\nbyte (NÉV) = (0-255);");
                                            Console.WriteLine("PL:\nbyte Byte = 99;\nByte = 0;");
                                            break;
                                        }
                                    case 0:
                                        {
                                            goto S0;
                                        }
                                }
                                break;
                            }
                        case 3://betűs
                            {
                                A9:
                                Console.Clear();
                                Console.WriteLine("-C#-");
                                Console.WriteLine("--Változók--");
                                Console.WriteLine("---Betűs---");
                                Console.WriteLine("Char: 1");
                                Console.WriteLine("Vissza lépés: 0");
                                A9 = Convert.ToInt32(Console.ReadLine());
                                switch (A9)
                                {
                                    case 1://Char
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Char:\n"); Console.ResetColor();
                                            Console.WriteLine("A Char egy karakter típusú változó.\nMérete 2 byte.");
                                            Console.WriteLine("A char 16 bites karakterábrázolást (unikód) használ.");
                                            Console.WriteLine("A backslash (\\) karakter speciális jelentéssel bír. Az utána következő karakter(eke)t, mint egy escape szekvenciát dolgozza föl a fordító.Az így használható escape szekvenciák a következők:");
                                            Console.WriteLine("\\a - a 7-es kódú csipogás\n\\b - backspace, előző karakter törlése\n\\f - formfeed, soremelés karakter\n\\r - kocsi vissza karakter\n\\n - új sor karakter (soremelés + kocsi vissza)");
                                            Console.WriteLine("Az új sor karakter hatása azonos a formfeed és a kocsi vissza karakterekhatásával");
                                            Console.WriteLine("\\t - tabulátor karakter\n\\v - függőleges tabulátor\n\\\\ - backslash karakter\n\\' - aposztróf\n\\\" - idézőjel\n\\? - kérdőjel\n\\uxxyy xx és yy unikódú karakter");
                                            Console.WriteLine("Deklarálása: \n char (NÉV) = '(BÁRMELY KARAKTER';");
                                            Console.WriteLine("PL:\nchar Character = 'Z';\nCharacter = 'S';");
                                            break;
                                        }
                                    case 0:
                                        {
                                            goto S0;
                                        }
                                }
                                break;
                            }
                        case 0:
                            {
                                goto S1;
                            }
                    }
                    break;
                case 0:
                    {
                        goto S2;
                    }
            }


            Console.ReadLine();
        S2:;
        }
    }
}
