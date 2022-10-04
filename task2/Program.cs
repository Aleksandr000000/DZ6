// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FillArray(int [] arr) // метод заполения координат точек через массив
{
    
    for (int i = 0; i < arr.Length; i ++ )
    {
        Console.Write("Введите координаты двух прямых: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    } 
}


void TochkaP(int [] arr)// вычисление точки перечечения
{ 
    double b1 = 0;
    double k1 = 0;
    double b2 = 0;
    double k2 = 0;
    double x = 0;
    double y = 0;
    for (int i= 0; i < arr.Length; i++ )
    {
        b1 = arr[0];
        k1 = arr[1];
        b2 = arr[2];
        k2 = arr[3];
        x = (b2-b1)/(k1-k2);
        y = (k1*(b2-b1))/(k1-k2)+b1;
    }
    Console.WriteLine($"Точка пересечения двух прямых ({Math.Round(x,2)} ; {Math.Round(y,2)}) ");        


}

int[] array = new int [4]; 
FillArray(array);
TochkaP(array);
