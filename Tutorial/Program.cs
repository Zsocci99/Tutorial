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
            S1 = Convert.ToInt32(Console.ReadLine());
            switch (S1)
            {
                case 1:
                    Console.WriteLine("Bool: 1");
                    Console.WriteLine("Byte: 2");
                    Console.WriteLine("Char: 3");
                    Console.WriteLine("Decimal: 4");
                    Console.WriteLine("Double: 5");
                    Console.WriteLine("Enum: 6");
                    Console.WriteLine("Float: 7");
                    Console.WriteLine("Int: 8");
                    Console.WriteLine("Long: 9");
                    Console.WriteLine("Sbyte: 10");
                    Console.WriteLine("Short: 11");
                    Console.WriteLine("Struct: 12");
                    Console.WriteLine("Uint: 13");
                    Console.WriteLine("Ulong: 14");
                    Console.WriteLine("Ushort: 15");
                    S0 = Convert.ToInt32(Console.ReadLine());
                    switch (S0)
                    {
                        case 1://Bool
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Bool:\n"); Console.ResetColor();
                            Console.WriteLine("A Bool egy logikai típusú változó.\nMérete 1 byte.");
                            Console.WriteLine("A logikai típus értéke a true vagy false értéket veheti fel.");
                            Console.WriteLine("Deklarálása:\nbool (NÉV) = (true/false);");
                            Console.WriteLine("PL:\nbool Boolean = true;\nBoolean = false;");
                            break;
                        case 2://Byte
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Byte:\n"); Console.ResetColor();
                            Console.WriteLine("A Byte egy olyan szám tipusú változó amely 0 és 255 között képes tárolni számokat.\nMérete 1 byte");
                            Console.WriteLine("A Byte 1 byton az az 8 biten tárol csak pozitív számokat(0-255).");
                            Console.WriteLine("Deklarálása:\nbyte (NÉV) = (0-255);");
                            Console.WriteLine("PL:\nbyte Byte = 99;\nByte = 0;");
                            break;
                        case 3://Char
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
                    break;
            }


            Console.ReadLine();
        }
    }
}
