/* Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Exponent(int a, int b)
{
    int exp = 1;
    for (int i = 1; i <= b; i++)
    {
        exp = exp * a;
    }
    return exp;
}

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b < 0)
{
    Console.WriteLine("Введите корректное число В, большее или равное 0");
    return;
}

Console.WriteLine("При возведении числа A в натуральную степень числа B результат равен  " + Exponent(a, b));
