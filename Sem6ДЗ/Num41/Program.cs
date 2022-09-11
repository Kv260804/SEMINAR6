// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// void CreateArray(int[] array)
// {
//     for (i = 0; i < M; i++)
// {
//     Console.WriteLine("Введите элемент массива: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
     
// }
// i = 0;
// for (i = 0; i < M; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }


// void CheckArray(int[] array)
// {
//    for(i = 0; i < M; i++)
// {
//     if(array[i] > 0)
//     {
//         count = count + 1;
//     }
//     else
//     { 
//         count = count;
//     }
// } 
// }

Console.WriteLine("Введите количество чисел массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int [M];
int i = 0;
int count = 0;
for (i = 0; i < M; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
     
}
i = 0;
for (i = 0; i < M; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for(i = 0; i < M; i++)
{
    if(array[i] > 0)
    {
        count = count + 1;
    }
    else
    { 
        count = count;
    }
}
Console.WriteLine("Количество чисел больше 0, которые ввёл пользователь: " + count);
