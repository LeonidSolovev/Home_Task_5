// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = NewArray (6, 100, 1000);
PrintArray(arr);
ShowEven(arr);

static void PrintArray(int[] q)
{
    
    Console.Write("[ ");
    for(int i =0; i<q.Length; i++){
    Console.Write($"{q[i]}, ");
}
    Console.Write("] ->");
}

 static int [] NewArray(int size, int from, int to)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i=0; i<size; i++)
      {
  arr[i] = rnd.Next(from, to);
    
     }
     return arr;
}

    static int ShowEven (int[] array)
    {
      int c = 0;
        foreach (int k in array)
      {
 if (k % 2 == 0)
    c++;
      }
     Console.WriteLine (c);
    return c;
     }
        