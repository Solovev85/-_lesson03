// // Задача 1. Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
// //значения которых лежат в отрезке [20,90].
// int[] arr = new int[10];
//             Random random = new Random();
//             int count = 0;

//             for (int i = 0; i < 10; i++)
//             {
//                 arr[i] = random.Next(1, 101);
//                 if (arr[i] >= 20 && arr[i] <= 90)
//                 {
//                     count++;
//                 }
//             }

//             Console.WriteLine(String.Join(", ", arr));
//             Console.WriteLine(count);

// ---------------------------------------------------------------------------------------------------
// // Задача 2. Задайте массив на 10 целых чисел. Напишите программу,
// которая определяет количество четных чисел в массие.

// int[] array = { 5, 12, 7, 18, 24, 35, 46, 53, 62, 71 };
// Console.WriteLine("Массив: " + string.Join(", ", array));
// int countEvenNumbers = CountEvenNumbers(array);
// Console.WriteLine("Количество четных чисел в массиве: " + countEvenNumbers);

// static int CountEvenNumbers(int[] array)
//     {
//         int count = 0;

//         foreach (int number in array)
//         {
//             if (number % 2 == 0)
//             {
//                 count++;
//             }
//         }

//         return count;
//     }
// ---------------------------------------------------------------------------------------------

// // Задача 3. Задайте массив из вещественных чисел с ненулевой дробной частью.
//              Найдите разницу между максимальным и минимальным элементов массива.

// double[] array = { 3.14, 2.718, 1.618, 4.669, 0.577, 2.302, 1.414, 2.236, 3.792, 2.685 };
// Console.WriteLine("Массив: " + string.Join(", ", array));
// double difference = FindDifference(array);
// Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);

// static double FindDifference(double[] array)
// {
//     if (array.Length == 0)
//     {
//         throw new ArgumentException("Массив не может быть пустым.");
//     }

//     double min = array[0];
//     double max = array[0];


//     foreach (double element in array)
//     {
//         if (element < min)
//         {
//             min = element;
//         }   
//         if (element > max)
//         {
//             max = element;
//         }
//     }
//     double difference = max - min;

//     return difference;
// }
// -----------------------------------------------------------------------------
// // Задача 4. Дано натуральное число в диапазоне от 1 до 100 000.