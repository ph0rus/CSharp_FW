// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

//  Console.Write("Введите начальное число (M): ");
//     int M = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите конечное число (N): ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     Console.Write($"все натуральные числа в промежутке от {M} до {N}: ");
//     SimpleNumbers(M, N);


// void SimpleNumbers(int M, int N)
// {
//     if(M > N) return;
//     if (M>0) {
//     Console.Write($"{M}  ");
//     }
//     SimpleNumbers(M+1, N);
// }

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//     Console.Write("Введите начальное число (M): ");
//     int M = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите конечное число (N): ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Результат функции Аккермана {M} до {N}: ");
//     Console.WriteLine(AkermanFunctions(M, N));


// int AkermanFunctions(int M, int N)

// {
//   if (M == 0) return N + 1;
//   else if (N == 0) return AkermanFunctions(M - 1, 1);
//   else return AkermanFunctions(M - 1, AkermanFunctions(M, N - 1));
// }
   
// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// int[] HelperReverce(int[] arr, int counter, List<int> preparedData) 
//     {
//         if (counter == 0) {
//             return preparedData.ToArray();
//         }
//         preparedData.Add(arr[counter - 1]);
//         counter--;
//         return HelperReverce(arr, counter, preparedData);
//     }

// int[] Reverce(int[] arr) 
//     {
//         List<int> preparedData = new List<int>();
//         int counter = arr.Length;
//         int[] result = HelperReverce(arr, counter, preparedData);
//         return result;
//     }


// int[] arr = {1, 2, 3, 4, 5, 6,7,8,9,10};
// int[] result = Reverce(arr);
// Console.WriteLine(string.Join(" ", result));