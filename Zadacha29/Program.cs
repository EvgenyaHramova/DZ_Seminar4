/* Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] array = new int[8];

for (int i = 0; i <= 7; i++) //i<array.Length
{
    Console.Write($"Введите значение элемента массива под номером {i}: "); // -запрос массива от пользователя склавиатуры
    int a = Convert.ToInt32(Console.ReadLine());
    array[i] = a;
       
}

for (int i = 0; i <= 7; i++) 
{
    Console.Write(array[i]+ ",  ");
}




/*int[] array = new int[8];
for (int i = 0; i <= 7; i++) //i<array.Length
{
    
    //Console.Write($"Введите элемент массива под номером {i}: "); -запрос массива от пользователя склавиатуры
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i]+ ", ");
}*/