// Вводим любое число и любой номер цифры, выводим цифру или сообщаем что ее нет.
int ExtractNumber (int number, int position) // ищем цифру в числе number на позиции position, возвращаем 0..9 либо -1
{
    int slicedNumber = number;
    int extractedNumber = 0;
    int i = 0;
    
    while ((slicedNumber !=0)&&(i < position))
    {
        extractedNumber = slicedNumber % 10;
        slicedNumber /= 10;
        i += 1;
    }

if (i < position) return -1;
else return extractedNumber;
}

Console.WriteLine("Введите любое целое число");
int inputNumber = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine("Введите номер позиции цифры");
int numberPosition = int.Parse(Console.ReadLine());

int result = ExtractNumber(inputNumber, numberPosition);

if (result == -1) Console.WriteLine("Цифры в позиции " + numberPosition + " не существует");
else Console.WriteLine("В позиции " + numberPosition + " находится цифра " + result);