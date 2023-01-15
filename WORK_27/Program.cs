// //  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("ВВЕДИТЕ ЧИСЛО: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber (int number)
{
   int result = 0; // конечный результат (сумма цифр заданного числа)
   int Digit = 0; 
   int product = 0; // произведение ( произдение цифр заданного числа )

   for(int i = 0; i <= numberN; i++) // забыл добавить N к слову number
    { 
    Digit = number % 10;
    result = result + Digit;
    product = product * Digit;
    number = number / 10;
    }
   return result;
}
int sumNumber = SumNumber(numberN);
Console.WriteLine(sumNumber);
