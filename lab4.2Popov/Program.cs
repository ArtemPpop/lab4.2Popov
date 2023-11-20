//средний 6 
Random random = new Random();
int n = 5;
int[,] A = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        A[i, j] = random.Next(1, 100);
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}

int minElement = A[0, 0];
int min = 0;
for (int i = 1; i < n; i++)
{
    if (A[i, i] < minElement)
    {
        minElement = A[i, i];
        min = i;
    }
}

int[,] B = new int[n - 1, n];
for (int i = 0, k = 0; i < n; i++)
{
    if (i != min)
    {
        for (int j = 0; j < n; j++)
        {
            B[k, j] = A[i, j];
        }
        k++;
    }
}

Console.WriteLine("матрица B без строки:");
for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(B[i, j] + " ");
    }
    Console.WriteLine();
}