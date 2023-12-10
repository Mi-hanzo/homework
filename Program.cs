// 1. Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат
// в отрезке [20,90].

// int[] mihanzo = new int[10];
// for (int i=0; i < mihanzo.Length; i++)
// {
//     mihanzo[i]=new Random().Next (1, 101);
//     Console.Write (mihanzo[i] + " ");
// }

// Console.WriteLine();

// int N=0;
// for (int i=0; i < mihanzo.Length; i++)
// {
//     if (mihanzo[i]>=20 && mihanzo[i]<=90)
//     {
//         N++;
//     }
// }

// Console.Write($"{N} элементов массива лежат в отрезке [20,90]");




// 2. Задайте массив на 10 целых чисел. Напишите программу, которая
// определяет количество чётных чисел в массиве.

// int[] mihanzo = new int[10];
// for (int i = 0; i < mihanzo.Length; i++)
// {
//     mihanzo[i] = new Random().Next(1, 101);
//     Console.Write(mihanzo[i] + " ");
// }

// Console.WriteLine();

// int N = 0;
// for (int i = 0; i < mihanzo.Length; i++)
// {
//     if (mihanzo[i] % 2 == 0)
//     {
//         N++;
//     }
// }

// Console.Write($"В данном массиве находится {N} четных чисел");




// 3. Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

// double[] mihanzo = new double[10];
// int R =0;
// for (int i = 0; i < mihanzo.Length; i++)
// {
//     mihanzo[i] = new Random().NextDouble() * 100;
//     mihanzo[i] = Math.Round(mihanzo[i], 2);
//     R= (int) mihanzo [i];
// while (R == mihanzo[i])
// {
//         mihanzo[i] = new Random().NextDouble() * 100;
//         mihanzo[i] = Math.Round(mihanzo[i], 2);
//         R = (int)mihanzo[i];
//     }
//     Console.Write(mihanzo[i] + "   ");
// }

// Console.WriteLine();

// double max = 0;
// double min = 100;
// for (int i=0; i < mihanzo.Length; i++)
// {
//     if (mihanzo[i] > max)
//     {
//         max = mihanzo [i];
//     }
//     else
//     {
//         if (mihanzo[i] < min)
//         min = mihanzo [i];
//     }
// }

// double final = max - min;
// final = Math.Round(final, 2);
// Console.Write($"Разница между максимальным и минимальным элементом массива равна {final}");




// 4. Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд числа должен располагаться
// на 0-м индексе массива, младший – на последнем. Размер массива должен быть
// равен количеству цифр.

// Console.WriteLine ("Введите натуральное число в диапазоне от 1 до 100 000: ");
// int N = int.Parse (Console.ReadLine());

// int L=N;
// while (L < 1 || L > 100000)
// {
//     Console.WriteLine("Введите натуральное число в диапазоне от 1 до 100 000 (!!!): ");
// int P = int.Parse(Console.ReadLine());
// L=P;
// }

// int Pt = L;
// int k = 0;
// while (Pt > 0)
// {
//     k++;
//     Pt= Pt/10;
// }

// int[] mihanzo = new int[k];
// int F=L;
// for (int i=0; i < mihanzo.Length; i++)
// {
//     while (k > 0)
//     {
//         double dm = Math.Pow(10, (k - 1));
//         int m = (int)dm;
//         L = L / m;
//         mihanzo[i] = L % 10;
//         Console.Write(mihanzo[i] + " ");
//         k--;
//         L = F;
//     }
// }