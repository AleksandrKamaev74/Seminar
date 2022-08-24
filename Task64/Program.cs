// Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int M = InputNumbers("Введите число M=");
int N = InputNumbers("Введите число N=");
Console.WriteLine(PrintNumbers(M, N));

//Вывод натуральных чисел от M до N
String PrintNumbers(int M, int N)
{
    string result = String.Empty; //пустая строка
    for (int i = M; i <= N; i = i + 1)
    {
        result = result + $"{i} ";
    }
    return result;
}

//Ввод целых чисел M,N
int InputNumbers(string input)
{
    Console.Write(input);//ввод строк
    int output = Convert.ToInt32(Console.ReadLine());//преобразование строк в числа
    return output;
}
