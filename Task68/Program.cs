// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите m");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n");
int last = int.Parse(Console.ReadLine());
int[,] matrix = new int[100,100];

int AckermannElement (int row, int column) // row и column индексы элемента
{
    if(row==0)
    {
        matrix[row,column] = column+1;
    }
    if(column==0)
    {
        matrix[row,column] = AckermannElement(row-1, 1);
    }
    if(row>0 && column>0)
    {
        matrix[row,column] = AckermannElement(row-1, AckermannElement(row,column-1));
    }
    return matrix[row,column];
}
Console.WriteLine(AckermannElement(first, last));
