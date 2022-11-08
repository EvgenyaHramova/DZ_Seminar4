/* Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int Summa(int a)
{
    string aNew = Math.Abs(a).ToString(); // преобразование числа в модуль и в строку 
    int[] array = new int[aNew.Length];
    int sum = 0;

    for (int i = 0; i < aNew.Length; i++)
    {
        array[i] = int.Parse(aNew[i].ToString());
        sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр в введенном числе равна  " + Summa(a));

