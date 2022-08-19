// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] mas = new int[4];
Random rand = new Random();
int poz = 0;
for(int i = 0; i < mas.Length; i++)
{
    mas[i] = rand.Next(100, 1000);
}
Console.WriteLine(string.Join(", ", mas));
for(int i = 0; i < mas.Length; i++)
{
    if(mas[i] % 2 == 0)
    {
        poz += 1;
    }
}
Console.WriteLine(poz);