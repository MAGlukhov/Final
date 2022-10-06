// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.WriteLine("Введите первое число");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int last = int.Parse(Console.ReadLine());

void AllNumbers(int a, int b)
{
    if(a <= b)
    {
        Console.Write(a + " ");
        a++;
        AllNumbers(a,b);
    }
    else return;

}
AllNumbers(first, last);