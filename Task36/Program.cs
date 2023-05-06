// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = NewArray(4, 1, 100);
PrintArray(arr);
Console.WriteLine(FindSumUneven(arr));

static int[] NewArray(int size, int from, int to)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(from, to);

    }
    return arr;
}

static int FindSumUneven(int[] q)
{
    int sum = 0;
    for (int i = 0; i < q.Length; i += 2)
        sum += q[i];
    return sum;
}

static void PrintArray(int[] q)
{

    Console.Write("[ ");
 
        Console.Write(String.Join (", ", q));
       Console.Write("] ->");
}