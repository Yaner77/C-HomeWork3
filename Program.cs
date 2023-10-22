№1 int Prompt (string message)
{ 
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput); 
    return result;
}
int Power (int powerBase, int exponent); 
{
    int power = 1; 
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power; 
}
bool ValidateExponent (int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true; 
}
int powerBase = Prompt ("Введите основание: ");
int exponent = Prompt ("Введите показатель: "); 
if (ValidateExponent(exponent))
{ 
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}


№2 int Prompt (string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput); 
    return result;
}
int SumAlldigit (int number)
{
    int result = 0; 
    while (number > 0)
    {
        result += number % 10; 
        number = number / 10; 
    }
    return result; 
}
int number = Prompt ("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAlldigit(number)}");


№3 int Prompt (string message)
{ 
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput); 
    return result;
}
int [] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int [Length];
    Random random = new Random (); 
    for (int i = 0; i < Length; i++)
    {
        array [i] = random.Next(minValue, maxValue + 1);
    }
    return array; 
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.WriteLine($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}
int Length = Prompt("Длина массива: "); 
int minValue = Prompt("Начальное значение, для диапазона случайного числа: "); 
int maxValue = Prompt("Конечное значение, для диапазона случайного числа: "); 
int [] array = GenerateArray(Length, minValue, maxValue); 
PrintArray(array);

