using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------- 1 a задание ----------------------
            //bool isTrue = true;
            //Console.WriteLine(isTrue);

            //Int16 yearBirth = 2005;
            //Console.WriteLine(yearBirth);

            //double price = 453.13;
            //Console.WriteLine(price);

            //Byte maxBite = 255;
            //Console.WriteLine(maxBite);

            //sbyte minSbite = -127;
            //Console.WriteLine(minSbite);

            //short maxShort = 32767;
            //Console.WriteLine(maxShort);

            //ushort randomUshort = 65535;
            //Console.WriteLine(randomUshort);

            //int currentYear = 2024;
            //Console.WriteLine(currentYear);

            //uint maxUint = 4294967295;
            //Console.WriteLine(maxUint);

            //long maxLong = -9223372036854755808;
            //Console.WriteLine(maxLong);

            //ulong maxUlong = 18446744073709551615;
            //Console.WriteLine(maxUlong);

            //double randomDouble = 21.14;
            //Console.WriteLine(randomDouble);

            //char aChar = 'A';
            //Console.WriteLine(aChar);

            //decimal randomDecimal = 3.2M;
            //Console.WriteLine(randomDecimal);

            //string hello = "Hello";
            //Console.WriteLine(hello);

            //object word = "Word";
            //Console.WriteLine($"{word}");

            //var randomType = 30;
            //Console.WriteLine($"{randomType}\n");

            //------- 1 b задание ----------------------

            //int randomIntB = 123;
            //long randomLongB = randomIntB;
            //Console.WriteLine(randomLongB);

            //int oneHundredB = 100;
            //double copyOneHundred = oneHundredB;
            //Console.WriteLine(copyOneHundred);

            //int fiveHundred = 500;
            //float copyFiveHundred = fiveHundred;
            //Console.WriteLine(copyFiveHundred);

            //Int16 ninetineHundredB = 900;
            //Int32 copyNinetineHundredB = ninetineHundredB;
            //Console.WriteLine(copyNinetineHundredB);

            //int thousand = 10000;
            //long copyThousand = thousand;
            //Console.WriteLine(copyThousand);



            //double fourHundredB = 400;
            //float copyFourHundredB = (float)fourHundredB;
            //Console.WriteLine(copyFourHundredB);

            //long twoHundredB = 200;
            //int copyTwoHundredB = (int)twoHundredB;
            //Console.WriteLine(copyTwoHundredB);

            //double randomDoubleB = 111.1;
            //int copyRandomDoubleB = (int)randomDoubleB;
            //Console.WriteLine(copyRandomDoubleB);

            //double randomDoubleTwoB = 362.2;
            //float copyRandomDoubleTwoB = Convert.ToSingle(randomDoubleTwoB);
            //Console.WriteLine(copyRandomDoubleTwoB);

            //char b = 'b';
            //int copyB = Convert.ToInt16(b);
            //Console.WriteLine(copyB);

            // --------- 1 c задание ----------------------------

            //int numRandom = 321;
            //object copyNumRandom = numRandom;   // упаковка типа (неявно)
            //numRandom = (int)copyNumRandom;     // распаковка    (явно)
            //Console.WriteLine(numRandom);

            //byte byteRandom = 123;
            //object copyByteRandom = byteRandom;
            //byteRandom = (byte)copyByteRandom;
            //Console.WriteLine(byteRandom);

            //sbyte sbyteRandom = -127;
            //object copySbyteRandom = sbyteRandom;
            //sbyteRandom = (sbyte)copySbyteRandom;
            //Console.WriteLine(sbyteRandom);

            //short maxShort = 32676;
            //object copyMaxShort = maxShort;
            //maxShort = (short)copyMaxShort;
            //Console.WriteLine(maxShort);

            //ushort maxUnshort = 65535;
            //object copyMaxUnshort = maxUnshort;
            //maxUnshort = (ushort)copyMaxUnshort;
            //Console.WriteLine(maxUnshort);

            //uint maxUint = 4294967295;
            //object copyMaxUint = maxUint;
            //maxUint = (uint)copyMaxUint;
            //Console.WriteLine(maxUint);

            //long maxLong = 9223372036854775807;
            //object copyMaxLong = maxLong;
            //maxLong = (long)copyMaxLong;
            //Console.WriteLine(maxLong);

            //ulong maxUlong = 18446744073709551615;
            //object copyMaxUlong = maxUlong;
            //maxUlong = (ulong)copyMaxUlong;
            //Console.WriteLine(maxUlong);

            //float randomFloat = 3.4F;
            //object copyRandomFloat = randomFloat;
            //randomFloat = (float)copyRandomFloat;
            //Console.WriteLine(randomFloat);

            //double randomDouble = 1.2;
            //object copyRandomDouble = randomDouble;
            //randomDouble = (double)copyRandomDouble;
            //Console.WriteLine(randomDouble);

            //decimal randomDecimal = 11.21M;
            //object copyRandomDecimal = randomDecimal;
            //randomDecimal = (decimal)copyRandomDecimal;
            //Console.WriteLine(randomDecimal);

            //bool isFalse = false;
            //object copyIsFalse = isFalse;
            //isFalse = (bool)copyIsFalse;
            //Console.WriteLine(isFalse);

            //char randomChar = 't';
            //object copyRandomChar = randomChar;
            //randomChar = (char)copyRandomChar;
            //Console.WriteLine(randomChar);


            // ---------- 1 d ЗАДАНИЕ --------------------

            //int randomIntB = 123;
            //long randomLongB = randomIntB;

            //randomLongB++;
            //Console.WriteLine(randomLongB);

            // ---------- 1 e ЗАДАНИЕ --------------------

            //int? nul = 15;
            //Console.WriteLine(nul);
            //nul = null;
            //Console.WriteLine(nul);

            // ---------- 1 f ЗАДАНИЕ --------------------

            //var randomType = "Привет";
            //Console.WriteLine(randomType);
            ////randomType = 20;

            // ---------- 2 a ЗАДАНИЕ --------------------

            //string hello = "hello";
            //string world = "world";

            //Console.WriteLine(hello == world);

            // ---------- 2 b ЗАДАНИЕ --------------------

            //string hello = "Hello";
            //string world = " World ";
            //string _ = " !!!";

            //string sumHelloAndWorld = hello + world + _;

            //Console.WriteLine(sumHelloAndWorld);

            //string[] words = sumHelloAndWorld.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);   // разделить строку на подстроки по разделителю ' '

            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}

            //hello = hello + world;
            //hello = hello.Insert(5, _);     // вставка подстроки на позицию 5
            //Console.WriteLine(hello);

            //Console.WriteLine(sumHelloAndWorld);
            //sumHelloAndWorld = sumHelloAndWorld.Remove(3, 7);       // удаление подстроки с позиции 3 до позиции 7
            //Console.WriteLine(sumHelloAndWorld);



            //string wor = "o";

            //Console.WriteLine(sumHelloAndWorld.IndexOf(wor));


            //string[] arrStr = new string[] { hello, world, _};
            //Console.WriteLine(String.Join(" ", arrStr));  //// соединяет строки и задает разделитель (" ")

            // ----------- 2 с ЗАДАНИЕ ------------------------

            //string randomTextNull = null;
            //string randomText = "";
            //Console.WriteLine(String.IsNullOrEmpty(randomText));

            // ----------- 2 d ЗАДАНИЕ --------------------------

            //var sb = new StringBuilder("Hello, World!");
            //Console.WriteLine(sb);  // можно использовать метод ToString()

            //sb.Remove(8, 1);
            //sb.Remove(3, 1);

            //sb.Insert(0, "&&&");
            //sb.Insert(sb.Length, "Bye");

            //Console.WriteLine(sb.ToString());


            // ----------- 3 a ЗАДАНИЕ ---------------------------

            //int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 }, };

            //int rows = numbers.GetUpperBound(0) + 1;
            //int colums = numbers.Length / rows;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < colums; j++)
            //    {
            //        Console.Write($"{numbers[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}

            // ------------ 3 b ЗАДАНИЕ ----------------------------


            //string[] strings = { "Price", "Grade", "Shop" };

            //Console.WriteLine($"Длинна массива: {strings.Length}");

            //Console.Write("Содержимое массива: ");
            //foreach( string s in strings )
            //{
            //    Console.Write( $"{s} " );
            //}

            //Console.WriteLine();
            //Console.WriteLine("Введите какую подстроку заменить: ");
            //int choiceStringsValue = Convert.ToInt32(Console.ReadLine());
            //choiceStringsValue--;

            //Console.Write("Введите строку: ");
            //string strValueInArray = Console.ReadLine();

            //strings[choiceStringsValue] = strValueInArray;

            //Console.WriteLine("Содержимое массива: ");
            //foreach (string item in strings)
            //{
            //    Console.Write($"{item} ");
            //}


            // ------------ 3 c ЗАДАНИЕ ------------------------

            //int[][] arrs =
            //{
            //    new int[] { 1, 2 },
            //    new int[] { 6 },
            //    new int[] { 7, 8, 9 },
            //    new int[] { 10, 11, 12, 13, 14, 15 },
            //};

            //foreach (int[] row in arrs)
            //{
            //    foreach (int i in row)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //    Console.WriteLine();
            //}

            // ------------- 3 d ЗАДАНИЕ -------------------------

            //var a = new[] { "hello", null, "world" }; // string[] --- неявно типизированный массив строк
            //var b = new[] { 1, 2, 3 };

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // ------------- 4 a ЗАДАНИЕ --------------------------

            //var kortage = (1, "Hello", 'A', "World", 18446744073709551615);

            // ------------- 4 b ЗАДАНИЕ --------------------------

            //var kortage = (1, "Hello", 'A', "World", 18446744073709551615);

            //Console.WriteLine(kortage.ToString());

            //Console.WriteLine($"\n{kortage.Item1}");
            //Console.WriteLine(kortage.Item3);
            //Console.WriteLine(kortage.Item2);

            // ------------- 4 c ЗАДАНИЕ ---------------------------

            //var (name, age) = ("John", 26);
            //Console.WriteLine($"Имя: {name}");
            //Console.WriteLine($"Возраст: {age}");


            //var (name, _, age) = ("Katrin", "unused", 24);
            //Console.WriteLine(name);
            //Console.WriteLine(age);

            // ------------- 4 d ЗАДАНИЕ -----------------------------

            //var kortage1 = (1, "Hello", 'A', "World", 18446744073709551615);
            //var kortage2 = (1, "Hello", 'A', "Wod", 18446744073709551615);

            //Console.WriteLine(kortage1 == kortage2);

            // ------------- 5 ЗАДАНИЕ --------------------------------

            //(int minNum, int maxNum, char firstChar) localFunc((int[], string) kortage1)
            //{
            //    var minNum = kortage1.Item1[0];

            //    foreach (int minNumber in kortage1.Item1)
            //    {
            //        if (minNumber < minNum )
            //            minNum = minNumber;
            //    }

            //    var maxNum = kortage1.Item1[0];

            //    foreach (int maxNumber in kortage1.Item1)
            //    {
            //        if (maxNumber > maxNum)
            //            maxNum = maxNumber;
            //    }

            //    var firstCharKortage = kortage1.Item2[0];

            //    return (minNum, maxNum, firstCharKortage);
            //}

            //var kortage = (new int[]{ 5,111,278, -5}, "Hello, World!");

            //var result = localFunc(kortage);
            //Console.WriteLine($"Результат выполнения функции:\nМинимальное число: {result.minNum}\nМаксимальное число: {result.maxNum}\nПервая буква строки: {result.firstChar}\n ");

            // ---------------- 6 а ЗАДАНИЕ -------------------------------

            void localFunc1()
            {
                int maxNumInt = int.MaxValue;
                unchecked
                {
                    Console.WriteLine(maxNumInt + 3);
                }
            }

            void localFunc2()
            {
                int maxNumInt = unchecked(int.MaxValue);
                checked
                {
                    Console.WriteLine(maxNumInt + 3);
                }
            }

            localFunc1();
            localFunc2();

        }


    }
}
