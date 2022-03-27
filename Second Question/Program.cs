// See https://aka.ms/new-console-template for more information
int[,] matrix =
{
{1, 2, 3, 4}, // row 0 values
{5, 6, 7, 8}, // row 1 value
};
// Print the matrix on the console
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]+"  ");
    }
    Console.WriteLine();
}
