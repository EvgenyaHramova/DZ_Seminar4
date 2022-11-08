/* Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int Summa(int a)
{
    string aNew = Math.Abs(a).ToString(); // преобразование числа в модуль и в строку 
    int count = aNew.Length; //число цифр в модуле числа
    //int aNew= aNew;
    Console.WriteLine(aNew);
    return count;

    int aNewInt = int.Parse(aNew);

    int [] array = new int([count]{aNewInt});  //  b[i] = int.Parse(str[i].ToString());
    //
    int sum=0;

    for (int i = 0; i <= count; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр в введенном числе равна  " + Summa(a));

