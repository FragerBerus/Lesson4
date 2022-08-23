// УРОК 4. Двумерные массивы.
Console.Clear();
string[,] table = new string[2, 5]; // При задании двумерного
                                    // массива задается тип данных
                                    // (string), в квадратных
                                    // скобках запятая ([,]), что
                                    // указывает на две размерности
                                    // (строки и столбцы), далее - 
                                    // наименование массива
                                    // (table), далее после new
                                    // string указываем количество
                                    // строк и столбцов в 
                                    // квадратных скобках через
                                    // запятую ([2, 5])
// По умолчанию элементы массива типа string инициализируются
// пустыми строками, т.е. String.Empty
table [1, 2] = "слово"; // Присвоение элементу массива table,
                        // находящемуся в первой строке [1] во
                        // втором столбце [2]
Console.WriteLine("Массив table:");
for (int rows = 0; rows < 2; rows++) // Массив table
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
int[,] matrix = new int[3, 4]; // Массив (матрица) matrix
Console.WriteLine("Мартица matrix:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}  
Console.Write("Количество строк в матрице: ");
Console.WriteLine(
matrix.GetLength(0)); // Определяет длину строки в матрице matrix
Console.Write("Количество столбцов в матрице: ");
Console.WriteLine(
matrix.GetLength(1)); // Определяет длину столбца в матрице matrix
void PrintArray(int[,] matr)    // Создание метода распечатывания 
                                // массива, где int[,] - тип
                                // параметра, matr - имя параметра
{
    Console.WriteLine("Матрица matrix:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }  
    Console.WriteLine();
}
PrintArray(matrix); // Вызов метода.
void FillArray(int[,] matr) // Создание метода заполнения массива
{                           // (матрицы) случайными числами
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
PrintArray(matrix); // Вызов метода распечатывания матрицы
FillArray(matrix);  // Вызов метода заполнения матрицы
PrintArray(matrix); // Вызов метода распечатывания матрицы