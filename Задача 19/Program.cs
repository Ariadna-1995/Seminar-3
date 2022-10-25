//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void PalindromicNumber(int number)
{
    int num1 = number/10000;
    int num2 = number%10;
    if(num1 == num2)
    {
        number = number/10;
        int num3 = (number/100)%10;
        int num4 = number%10; 
        if(num3 == num4)
        {
            Console.Write("Да");
        }    
    }
    else 
    {
        Console.Write("Нет");
    }
}
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
PalindromicNumber(number); 
