// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] arr = NewArray (6, 1, 100);

PrintArray(arr);
    
int max = FindMax(arr);
   
int min = FindMin(arr);

int diff = FindDiff(max, min);

Console.WriteLine (diff);


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
    
    static int FindMax(int[] array)
    {
        int max = array[0];
        for(int i =1; i<array.Length; i++)
        {
        if(max<array[i])
        max = array[i];
        }
        return max;
    }
    
     static int FindMin(int[] array)
    {
        int min = array[0];
        for(int i =1; i<array.Length; i++)
        {
        if(min>array[i])
        min = array[i];
        }
        return min;
    }
    
    static int FindDiff(int a, int b)
    {
        int diff = a - b;
        return diff;
    }
