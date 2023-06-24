int[,] array = new int[10, 10];

FillArray(array);
PrintArray(array);

    static void FillArray(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);
    int counter = 1;
    int currentRow = 0;
    int currentCol = 0;
    int direction = 0; // 0 - w prawo, 1 - w dół, 2 - w lewo, 3 - w górę

    while (counter <= numRows * numCols)
    {
        array[currentRow, currentCol] = counter++;

        switch (direction)
        {
            case 0: // W prawo
                if (currentCol + 1 < numCols && array[currentRow, currentCol + 1] == 0)
                {
                    currentCol++;
                }
                else
                {
                    direction = 1; // Zmiana kierunku w dół
                    currentRow++;
                }
                break;
            case 1: // W dół
                if (currentRow + 1 < numRows && array[currentRow + 1, currentCol] == 0)
                {
                    currentRow++;
                }
                else
                {
                    direction = 2; // Zmiana kierunku w lewo
                    currentCol--;
                }
                break;
            case 2: // W lewo
                if (currentCol - 1 >= 0 && array[currentRow, currentCol - 1] == 0)
                {
                    currentCol--;
                }
                else
                {
                    direction = 3; // Zmiana kierunku w górę
                    currentRow--;
                }
                break;
            case 3: // W górę
                if (currentRow - 1 >= 0 && array[currentRow - 1, currentCol] == 0)
                {
                    currentRow--;
                }
                else
                {
                    direction = 0; // Zmiana kierunku w prawo
                    currentCol++;
                }
                break;
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