//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

int max = 0;
int min = 0;
int [] arr;
int[] CreatingAnArray(int number)
    {
        int [] array = new int [number];
        return array;
    }

void FillingTheArray(int [] arr, int startlimit, int endlimit)
    {
        Random rand = new Random();
        for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(startlimit, endlimit);
                Console.WriteLine(arr[i]);
            }
    }

int MaxElement(int [] arr)
    {
        max = arr[0];
        for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    {
                        max = arr[i];
                    }
            }
        return max;
    }

int MinElement(int [] arr)
    {
        min = arr[0];
        for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    {
                        min = arr[i];
                    }
            }
        return min;
    }


arr = CreatingAnArray(5);
FillingTheArray(arr, 1, 100);
max = MaxElement(arr);
min = MinElement(arr);
Console.WriteLine($"Максимальное число массива равно: {max}");
Console.WriteLine($"Минимальное число массива равно: {min}");
Console.WriteLine($"Разница между наибольшим и наименьшим числом массива равна: {max-min}");