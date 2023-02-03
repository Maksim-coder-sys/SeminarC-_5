//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int sum = 0;
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

int SumOfElementsInOddPositions(int [] arr)
    {
        for(int i = 1; i < arr.Length; i += 2)
            {
                sum = sum + arr[i];
            }
        return sum;
    }
arr = CreatingAnArray(10);
FillingTheArray(arr);
sum = SumOfElementsInOddPositions(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
