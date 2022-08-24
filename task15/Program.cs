// Вводим номер дня недели и узнаем выходной он или нет
bool IsHoliday (int number)
{ 
    int saturday = 6;
    int sunday = 7;
    return (number == saturday)||(number == sunday);
}

Console.WriteLine("Введите номер дня недели (1..7)");
int numberOfDay = int.Parse(Console.ReadLine());

if (IsHoliday(numberOfDay)) Console.WriteLine("Это выходной день");
else Console.WriteLine("Это не выходной день");
