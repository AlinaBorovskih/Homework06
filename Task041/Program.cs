Console.Write("Введите колличество чисел, которые вы собираетесь ввести:  ");
int M = int.Parse(Console.ReadLine());
int [] mass = new int [M];
for (int i = 0; i < mass.Length; i++)
{
    Console.Write("Введите следующее число:  ");
    mass[i] = int.Parse(Console.ReadLine());
}

int count = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Колличество чисел больше нуля: {count}");