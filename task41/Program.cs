/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Введите числа через запятую: ");
int[] array = Array.ConvertAll<string, int>
(Console.ReadLine().Split(','), i => { return System.Convert.ToInt32(i); });
int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        res = res + 1;
    }
}
Console.WriteLine(res);