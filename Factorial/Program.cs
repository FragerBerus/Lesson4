//УРОК 4. Рекурсия.
// Вычисление факториала
Console.Clear();
Console.Write("Введите число, факториал которого необходимо найти: ");
int n = Convert.ToInt32(Console.ReadLine());
double Factorial(int n)    // Создание метода вычисления факториала
{   // Тип данных необходимо указать не int, а double, т.к.
    // при вычислении факториала быстро наступит переполнение
    // типа данных
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
Console.WriteLine($"Факториал {n}! равен {Factorial(n)}.");
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"Факториал {i}! = {Factorial(i)}.");
}