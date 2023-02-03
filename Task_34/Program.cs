//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
int count = 0;
int [] arr;
int[] CreatingAnArray(int number)
    {
        int [] array = new int [number];
        return array;
    }

void FillingTheArray(int [] arr)
    {
        Random rand = new Random();
        for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100, 1000);
                Console.WriteLine(arr[i]);
            }
    }

int CountingEvenNumbers(int [] arr)
    {
        for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    {
                        count++;
                    }
            }
        return count;
    }
arr = CreatingAnArray(5);
FillingTheArray(arr);
count = CountingEvenNumbers(arr);
Console.WriteLine($"Количество четных чисел в массиве равно {count}");