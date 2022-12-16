/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет  */

int[,] array = new int[3,4];
int n = 15;

for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(20);
        Console.Write($"{array[i, j]} "); 
    }
    Console.WriteLine();
}

bool find = false;
foreach (var i in array)
     if (i == n) { find = true; break; }
if (find)
    Console.Write($"Число присутствует");
else
    Console.Write($"Такого числа нет в массиве");
