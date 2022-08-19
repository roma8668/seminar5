// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] mas = new double[10];
  for (int i = 0; i < mas.Length; i++ )
  {
    mas[i] = new Random().Next(1, 10);
    Console.Write(mas[i] + " ");
  }
double max = mas[0];
double min = mas[0];
  for (int i = 1; i < mas.Length; i++)
  {
    if (max < mas[i])
    {
      max = mas[i];
    }
        if (min > mas[i])
    {
      min = mas[i];
    }
  }
  double dif = max - min;
  Console.WriteLine($"\nразница между между максимальным ({max}) и минимальным({min}) элементами: {dif}");

