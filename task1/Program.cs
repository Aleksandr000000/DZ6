// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void FillArray(int [] arr) // метод ручного заполнения массива числами
{
    
    for (int i = 0; i < arr.Length; i ++ )
    {
        Console.Write("Введите  число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    } 
}

void PrintArray(int [] arr) // метод вывода этого массива
{

    Console.WriteLine("Создали массив: ");
    for (int i= 0; i < arr.Length; i++ )
    {
        Console.Write(arr[i]+ " ");
    }
     
}

void SummPozitive(int [] arr) // Метод подсчета 
{   
    int sum = 0;
    for (int i= 0; i < arr.Length; i++ )
    {
        if (arr[i] > 0)
        sum++;
        
    }     
    Console.WriteLine($"=>  {sum} элемента(ов) больше 0");
}


Console.WriteLine("Количество чисел в массиве? ");
int[] array = new int [Convert.ToInt32(Console.ReadLine())]; 
FillArray(array);
PrintArray(array);
SummPozitive(array);