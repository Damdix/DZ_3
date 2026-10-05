
Console.WriteLine("\t\t=== Калькулятор ===");

Console.WriteLine("\nВведите первое число: ");
double firstNum = Convert.ToDouble(Console.ReadLine());         //Получаем Первое Число 

Console.WriteLine("\nВведите второе число: ");
double secondNum = Convert.ToDouble(Console.ReadLine());        //Получаем Второе число

Console.WriteLine("\nВведите оператор (+ , - , * , /)");
string oper = Convert.ToString(Console.ReadLine());

switch(oper)
{
    case "+":
        Console.WriteLine($"Сложение: {firstNum} + {secondNum} = {firstNum + secondNum}");
        break;

    case "-":
       Console.WriteLine($"Вычитания: {firstNum} - {secondNum} = {firstNum - secondNum}");
        break;

    case "*":
        Console.WriteLine($"Умножение: {firstNum} * {secondNum} = {firstNum * secondNum}");
        break;

    case "/":
        Console.WriteLine($"Деление: {firstNum} / {secondNum} = {firstNum / secondNum}");
        break;
    default: Console.WriteLine("Вы ввели неверный оператор"); break;
}

