// Задача 66.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.

int M = InputNumbers("Введите число M=");
int N = InputNumbers("Введите число N=");
Console.WriteLine(SumNumbers(M, N));

//Сумма натуральных чисел в промежутке от M до N
int SumNumbers(int M, int N)
{
    int result = 0;
    for (int i = M; i <= N; i = i + 1)
    {
        result = result + i;
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



