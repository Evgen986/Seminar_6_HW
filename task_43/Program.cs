/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
              заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
              b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5);
*/

Main();

void Main()
{
    Console.Clear();
    double [] coord = GetlineСoordinates();
    double [] cross = FindLineCrossing(coord);
    PrintArray(cross);
}

double [] GetlineСoordinates()                     // Метод получения координат прямых от ползователя
{
    double [] array = new double[4];
    
    Console.WriteLine("Введите координаты для двух прямых:");
    Console.Write("Введите значение b1: ");
    array[0] = double.Parse(Console.ReadLine());
        
    Console.Write("Введите значение k1: ");
    array[1] = double.Parse(Console.ReadLine());
        
    Console.Write("Введите значение b2: ");
    array[2] = double.Parse(Console.ReadLine());
        
    Console.Write("Введите значение k2: ");
    array[3] = double.Parse(Console.ReadLine());
        
    return array;
}

double [] FindLineCrossing (double [] arr){         // Метод нахождения координат точки пересечения 2-х прямых
    double [] crossСoord = new double [2];
    crossСoord[0] = (arr[2]-arr[0])/(arr[1]-arr[3]);
    crossСoord[1] = arr[1]*(arr[2]-arr[0])/(arr[1]-arr[3])+arr[0];
    return crossСoord;
}

void PrintArray(double[] arr)                       // Метод вывода значений массива в терминал
{
    Console.Write("Координаты точки пересечения = ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + " и ");
        }
        else
        {
            Console.Write(arr[i]);
        }
    }
    Console.WriteLine();
}