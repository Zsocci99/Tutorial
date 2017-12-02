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
            int first = 0;
            int second = 0;
            //delet |
            //      V
            first = 1;
            second = 2;
            Console.WriteLine("Variables: 1");
            //first = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            first:
            switch (first)
            {
                case 1:
                    Console.WriteLine("Bool: 1");
                    Console.WriteLine("Char: 2");
                    Console.WriteLine("Decimal: 3");
                    Console.WriteLine("Double: 4");
                    Console.WriteLine("Enum: 5");
                    Console.WriteLine("Float: 6");
                    Console.WriteLine("Int: 7");
                    Console.WriteLine("Long: 8");
                    Console.WriteLine("Sbyte: 9");
                    Console.WriteLine("Short: 10");
                    Console.WriteLine("Struct: 11");
                    Console.WriteLine("Uint: 12");
                    Console.WriteLine("Ulong: 13");
                    Console.WriteLine("Ushort: 14");
                //second = Convert.ToInt32(Console.ReadLine());
                second:
                    switch (second)
                    {
                        case 1:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Bool:\n"); Console.ResetColor();
                            Console.WriteLine("A Bool egy logikai típusú változó.\nMérete 1 byte.");
                            Console.WriteLine("A logikai típus értéke a true vagy false értéket veheti fel.");
                            Console.WriteLine("Deklarálása:\nbool (NÉV) = (true/false);");
                            Console.WriteLine("PL:\nbool Boolean = true;\nBoolean = false;");
                            break;
                        case 2:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Byte:\n"); Console.ResetColor();
                            Console.WriteLine("A Byte egy olyan szám tipusú változó amely 0 és 255 között képes tárolni számokat.\nMérete 1 byte");
                            Console.WriteLine("A Byte 1 byton az az 8 biten tárol csak pozitív számokat(0-255).");
                            Console.WriteLine("Deklarálása:\nbyte (NÉV) = (0-255);");
                            Console.WriteLine("PL:\nbyte Byte = 99;\nByte = 0;");
                            break;
                        case 3:
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
