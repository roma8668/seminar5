// Задача 36:
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] mas = new int[10];
Random rand = new Random();
int samN = 0;
for(int i = 0; i < mas.Length; i++)
{
    mas[i] = rand.Next(0, 10);
}
Console.WriteLine(string.Join(", ", mas));
for(int i = 1; i < mas.Length; i = i + 2)
{
 samN = samN + mas[i]; 
}
Console.WriteLine(samN);