//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
void RandArray()
{
  int[] arr = new int[10];
  for(int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(0,2);
    //Console.Write("{0} ", arr[i]);
  }
    Console.WriteLine($"[{String.Join(",", arr)}]");
}
RandArray();

