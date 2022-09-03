//Задача 25: Напишите цикл, который принимает на 
//вход два числа (A и B) и возводит число A в натуральную степень B

int Exercice25()
{
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
if(a != 0)
{
    for(int i = result; i <= b; i++)
{
    result = result * a;
}
}
else result = 0;
return result;
}
Console.WriteLine(Exercice25());

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Exercice27()
{
    Console.WriteLine("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    for(int i = a; i > 0; i /= 10)
    {
        result += i % 10;
    }
    return result;
}
Console.WriteLine(Exercice27());

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void Exercice29()
{
    int size = 8;
    int[] array = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-99, 100);
    }
    
    for(int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Exercice29();


