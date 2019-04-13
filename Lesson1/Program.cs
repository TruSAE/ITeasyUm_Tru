using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Program
    {
        public static void Main()
        {
            #region Занятие 1. типы данных. приведение типов




            ////short myShort;
            ////myShort = 456;
            //short myShort1 = 7891;
            ////int myInt = (int)myShort1 * 2019;
            //long myLong = long.MaxValue;
            //int myInt = (int)myLong;
            ////short myInt1 = (short)myShort1 * 20192;

            ////double myDouble = 7 / 3d + 7/3d + 7/3d;
            //double myDouble = 7 / 3.0;
            //myDouble++;
            //bool myBool = true;
            //myBool = myInt > myLong;
            //Console.WriteLine(myBool);

            //myBool = myInt < myLong;
            //Console.WriteLine(myBool);

            //myBool = myInt >= myLong;
            //Console.WriteLine(myBool);

            //myBool = myInt <= myLong;
            //Console.WriteLine(myBool);

            //myBool = myInt == myLong;
            //Console.WriteLine(myBool);

            //myBool = myInt != myLong;
            //Console.WriteLine(myBool);

            //myBool = !false;


            //Console.WriteLine(myBool);

            //Console.WriteLine(myDouble);

            //char myChar = 'F';
            //Console.WriteLine(myChar); ;
            //Console.WriteLine((int)myChar);
            #endregion

            #region  преобразования с потерей точности с типами данных.

            //int integer = Int32.MaxValue;
            //Console.WriteLine($"Максимальное значение переменной типа: \n");
            //Console.WriteLine($"int " + integer);
            //byte tooInteger = Byte.MaxValue;
            //Console.WriteLine($"byte " + tooInteger);
            //short integer1 = Int16.MaxValue;
            //Console.WriteLine($"short " + integer1);
            //long integer2 = Int64.MaxValue;
            //Console.WriteLine($"long " + integer2);
            //float integer3 = float.MaxValue;
            //Console.WriteLine($"float " + integer3);
            //double integer4 = double.MaxValue;
            //Console.WriteLine($"double " + integer4);
            //decimal integer5 = decimal.MaxValue;
            //Console.WriteLine($"decimal " + integer5 + "\n");

            //Console.WriteLine("Преобразование типов без потери данных:\n ");
            //short integer6 = tooInteger;
            //Console.WriteLine("byte {0}  -> short {1}: ", tooInteger, integer6);
            //int integer7 = integer1;
            //Console.WriteLine("short {0} -> int {1}: ", integer1, integer7);
            //long integer8 = integer;
            //Console.WriteLine("int {0} -> long {1}", integer, integer8);
            //float integer9 = integer2;
            //Console.WriteLine("long {0} -> float {1}", integer2, integer9);
            //double integer10 = integer3;
            //Console.WriteLine("float {0} -> double {1}", integer3, integer10);

            //Console.WriteLine();
            //Console.WriteLine("Преобразования типов с потерей данных: \n");
            //float integer12 = (float)integer4;
            //Console.WriteLine($"double {integer4} -> float {integer12}");
            //long integer13 = (long)integer3;
            //Console.WriteLine($"float {integer3} -> long {integer13}");
            //int integer14 = (int)integer2;
            //Console.WriteLine($"long {integer2} -> int {integer14}");
            //short integer15 = (short)integer;
            //Console.WriteLine($"int {integer} -> short {integer15}");
            //byte integer11 = (byte)integer1;
            //Console.WriteLine($"short {integer1} -> byte {integer11}");


            //int r = 87;

            //Console.WriteLine((char)r);

            //Console.WriteLine((float)integer);

            //Console.ReadKey();

            #endregion

        }
    }
}
