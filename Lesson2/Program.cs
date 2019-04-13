using System;
using System.Globalization;
using System.Threading;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region урок 2. ссылочные типы данных

            //Console.Write("Введите инициалы и любимую цифру: ");
            ////Console.Write("Please, input the number: ");
            //string userInput = Console.ReadLine();
            //char userDigit = userInput[4];
            ////userInput[4] = '9'; не работает в сторону "положить", т.к. неизменямый тип данных
            //int x = int.Parse(userDigit.ToString());

            //int secondDegree = x * x;

            ////int thirdDegree = x * x * x;
            ////int fourDegree = x * x * x * x;

            //int thirdDegree = secondDegree * x;

            //int fourDegree = thirdDegree * x;

            //Console.WriteLine($"User number: {userInput}, result\t{secondDegree}");
            //Console.WriteLine($"User number: {userInput}, result\t{thirdDegree}");
            //Console.WriteLine($"User number: {userInput}, result\t{fourDegree}");



            //Console.ReadKey();


            #endregion

            #region урок 2. массивы. инициализация

            //string[] arrOfString;
            //arrOfString = new string[5];

            //arrOfString[0] = "это первая ячейка";
            //arrOfString[1] = "это вторая ячейка";
            //arrOfString[2] = "это третья ячейка";
            //arrOfString[3] = "это четвертая ячейка";
            //arrOfString[4] = "это пятая ячейка";

            //foreach (var item in arrOfString)
            //{
            //    Console.WriteLine(item);
            //}

            //string[,] matrixStrings = new string[2,2];
            //matrixStrings[0,0] = "это первая ячейка";
            //matrixStrings[0,1] = "это вторая ячейка";
            //matrixStrings[1,0] = "это третья ячейка";
            //matrixStrings[1,1] = "это четвертая ячейка";

            //string[][] complexArr = new string[3][];
            //complexArr[0] = new string[10];
            //complexArr[1] = new string[20];
            //complexArr[2] = new string[30];

            //Console.ReadKey();

            #endregion

            #region  урок 2. ветвления


            //string[][] complexArr = new string[3][];
            //complexArr[0] = new string[10];
            //complexArr[1] = new string[20];
            //complexArr[2] = new string[30];
            //complexArr[1][19] = "Я появился";
            //// чисто примеры. смотри методы объекта string
            //if (complexArr[1][19] != null)
            //{
            //    if (complexArr[1][19] != "")
            //    {
            //        Console.WriteLine("Нет такого элемента");
            //    }
            //    Console.WriteLine(complexArr[1][19]);
            //}
            //else if (string.IsNullOrWhiteSpace(complexArr[1][19]))
            //{
            //    Console.WriteLine("Нет такого элемента");
            //}
            //{
            //    Console.WriteLine("Нет такого элемента");
            //}





            //Console.ReadKey();

            #endregion

            #region Домашнее задание 2_1.Вывод таблицы умножения  до 5-ти на консоль в виде таблицы и переплата по кредиту

            Console.WriteLine("Таблица умножения на 5 ");
            Console.WriteLine("____________________________________________");

            int result = 0;
            for (var i = 1; i <= 5; i++)
            {
                Console.Write($" {i}");

                for (int j = 1; j <= 5; j++)
                {
                    result = i * j;
                    if (j < 5)
                    {
                        Console.Write($"|\t{result} ");
                    }
                    else
                    {
                        Console.WriteLine($"|\t{result} ");
                        Console.WriteLine("____________________________________________");
                    }

                }

            }

            Console.WriteLine("To be continue... Press enter");

            Console.WriteLine();

            Console.ReadKey();

            Console.WriteLine();

            Console.WriteLine("Для отображения таблицы умножения\nвведите целое положительное число\nбольшее 1:\n");

            int n = int.Parse(Console.ReadLine());

            int[,] multy = new int[n, n];

            for (int i = 0; i < multy.GetLength(0); i++)
            {
                for (int j = 0; j < multy.GetLength(1); j++)
                {
                    multy[i, j] = (i + 1) * (j + 1);
                    Console.Write("{0,3}", multy[i, j]);
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("To be continue... Press enter");

            Console.ReadKey();



            Console.WriteLine("Введите целое число больше 1:");
            int multi = 0;
            int secondFactor = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                multi = i * secondFactor;
                Console.WriteLine($"{i} X {secondFactor} = {multi}");
            }
            Console.WriteLine();

            Console.WriteLine("To be continue... Press enter\n");

            Console.ReadKey();
            ////Console.WriteLine("Введите целое число больше 1:");
            ////int multi1 = 0;
            //////int cursorX, cursorY;
            ////int secondFactor1 = Convert.ToInt32(Console.ReadLine());
            ////for (int j = 1; j < secondFactor1; j++)
            ////{
            ////    for (int i = 1; i <= 10; i++)
            ////{
            ////    multi1 = i * secondFactor1;
            ////    Console.WriteLine($"{i} X {secondFactor1} = {multi1}");
            ////    //cursorX = 
            ////}
            ////    //Console.CursorLeft????? хотел выводить по столбцам параллельно от 1 до введенного юзверем
            //// как на старых тетрадях по математике, но задолбался...


            int countMonth = 1;
            double percentTotal = 0;
            double summKredit = 100000; //summa dolga
            double month = 12; //kol-vo mesyacev
            double everyMonth = summKredit / month; //Ежемесячный платеж по основному долгу
            double totalSumm; //выплата
            double userPercent = 0.12;
            double percentEveryMonth; //процент ежемесячно на остаток

            Console.WriteLine("#\tДолг\t\tПроцент\tВыплата");

            while (countMonth <= 12)
            {
                percentEveryMonth = summKredit * userPercent * 30 / 365;
                percentEveryMonth = Math.Round(percentEveryMonth, 2);
                totalSumm = percentEveryMonth + everyMonth;
                Console.WriteLine($"{countMonth}\t{summKredit:f2}\t{percentEveryMonth:f2}\t{totalSumm:f2}\n");// не могу понять изменения форматирования
                                                                                                            // в строке 12-го месяца

                percentTotal = percentTotal + percentEveryMonth;
                summKredit -= totalSumm;
                countMonth++;
            }

            Console.WriteLine($"Всего переплачено по кредиту:\t{percentTotal:C}");// не смог в рубли перевести.
                                                                                  // в доллары - да, но не в рубли.
                                                                                  //понимаю, что ? обозначает неспособность консоли распознать
                                                                                  // символ рубля

            Console.ReadKey();
            
            
            #endregion
        }
    }
}
    

