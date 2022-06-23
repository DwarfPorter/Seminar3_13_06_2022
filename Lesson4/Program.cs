// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int SumA(int maxNumber)
{
    int answer = 0;
    for (int i = 1; i <= maxNumber; i++)
    {
        answer += i;
    }
    return answer;
}

int SumAGauss(int maxNumber){
    return maxNumber * (maxNumber + 1) / 2;
}

int numberA = Prompt("Введмте число > ");
System.Console.WriteLine($"Сумма от 1 до {numberA} равна {SumA(numberA)}");
System.Console.WriteLine($"Гаусс сумма {SumAGauss(numberA)}");

