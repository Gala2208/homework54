int m = 4,
    n = 4;
int[,] arr = new int[m, n];
int[] arrHelper = new int[n];
Random rnd = new Random();

// Заполняем массив
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < m; k++) arr[i, k] = rnd.Next(10);
}

// Сортируем массив
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++) arrHelper[k] = arr[i, k];
    Array.Sort(arrHelper);
    Array.Reverse(arrHelper);
    for (int k = 0; k < n; k++) arr[i, k] = arrHelper[k];
}

// Выводим массив
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < m; k++) Console.Write("{0} ", arr[i, k]);
    Console.WriteLine();
}