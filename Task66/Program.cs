// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите первое число");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int last = int.Parse(Console.ReadLine());
int sum = 0;

int AllNumbers(int a, int b)
{
    if(a <= b)
    {
        sum +=a;
        a++;
        return AllNumbers(a,b);
    }
    else return sum;
}
Console.Write(AllNumbers(first, last));