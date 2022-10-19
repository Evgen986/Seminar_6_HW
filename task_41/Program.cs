/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
              0, 7, 8, -2, -2 -> 2
              1, -7, 567, 89, 223-> 4
*/

Main();

void Main()
{
    Console.Clear();
    int[] arr = GetNumbers();
    int count = CountPositiveNumbers(arr);
    Console.Write($"Среди чисел: ");
    PrintArray(arr);
    Console.Write($" присутсвует: {count} положительных чисел");
}

int[] GetNumbers()                                      // Метод получения чисел от пользователя
{
    Console.Write("Введите числа через запятую: ");
    int[] array = Console.ReadLine()                                            // Полчаем данные введенные через терминал
        .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)     // Разбиваем строку на подстроки по символу "," исключая случайные пробелы
        .Select(b => int.Parse(b))                                              // Преобразовываем String-овые значения полученных подстрок в тип int 
        .ToArray();                                                             // Присваеваем полученные значения в массив
    return array;
}

int CountPositiveNumbers(int[] arr)                     // Метод нахождения кол-ва чисел в положительном диапозоне
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] arr)                              // Метод вывода значений массива в терминал
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }
        else
        {
            Console.Write(arr[i]);
        }
    }
}