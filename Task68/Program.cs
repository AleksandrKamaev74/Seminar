// Задача 68.Напишите программу вычисления Функции Аккермана с помощью рекурсии.Даны два 
//неотрицательных числа m и n

int m = InputNumbers("Введите число m=");
int n = InputNumbers("Введите число n=");
int ackerman = Ack(m, n);
Console.WriteLine($"Функция Аккермана = {ackerman} ");

// Функция Аккермана
int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m > 0) && (n == 0))
        return Ack(m - 1, 1);
    else
        return Ack(m - 1, Ack(m, n - 1));
}

//Ввод целых чисел m,n
int InputNumbers(string input)
{
    Console.Write(input);//ввод строк
    int output = Convert.ToInt32(Console.ReadLine());//преобразование строк в числа
    return output;
}



