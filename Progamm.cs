using System.Text;

int sumsalary = 0;
double peremennya;
double otecperemennza = 0;
int max = 0;
int min = 5000;
int[] zarplata = new int[12];
Random rand = new Random();
for (int i = 0; i < 12; i++)
{

    zarplata[i] = rand.Next(1000, 5001);
}


foreach (int i in zarplata)
{

    sumsalary += i;
    peremennya = i * 0.02;
    otecperemennza += peremennya;

}
int ovveragesal = sumsalary / 12;
int monthmin = 0;
int monthmax = 0; int j = 0;
Console.WriteLine("Список зарплат:");
foreach (int i in zarplata)
{

    j += 1;
    Console.WriteLine($"Зарплата в {j} месяц составила {i}");
    peremennya = i * 0.02;
    Console.WriteLine();
    Console.WriteLine($"Отчисления в пенсионный фонд в этом месяце: {peremennya}");
    Console.WriteLine($"Отклонение от средней зарплаты: {i - ovveragesal}");
    if (min >= i)
    {
        min = i;
        monthmin = j;
    }
    if (max <= i)
    {
        max = i;
        monthmax = j;
    }
    Console.WriteLine();

}

Console.WriteLine($"Общая зарплата за год: {sumsalary}");
Console.WriteLine($"Сумма отчислений в пенсионный фонд:{otecperemennza}");
Console.WriteLine($"Средняя зарплата за год:{ovveragesal}");

Console.WriteLine($"Максимальная зарплата составила {max} в месяце номер {monthmax}");
Console.WriteLine($"Минимальная зарплата составила {min} в месяце номер {monthmin}");
