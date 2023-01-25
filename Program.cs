Console.Write("Введите любое количество чисел от -1000 до 1000 ЧЕРЕЗ ПРОБЕЛ: ");
    int[] newarray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count = 0;
for (int i = 0; i < newarray.Length; i++)
{
    if (newarray[i] > 0)
    {
        count++;
  }

}
    Console.WriteLine($"Введено чисел больше 0: {count}");
