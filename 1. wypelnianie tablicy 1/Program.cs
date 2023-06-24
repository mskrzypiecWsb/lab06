int[,] array = new int[10, 10];

FillArray(array);
PrintArray(array);

    static void FillArray(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);
    int counter = 1;

    for (int i = 0; i < numRows; i++)
    {
        if (i % 2 == 0) // Parzyste wiersze
        {
            for (int j = 0; j < numCols; j++)
            {
                array[i, j] = counter++;
            }
        }
        else // Nieparzyste wiersze
        {
            for (int j = numCols - 1; j >= 0; j--)
            {
                array[i, j] = counter++;
            }
        }
    }
}

static void PrintArray(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCols; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}