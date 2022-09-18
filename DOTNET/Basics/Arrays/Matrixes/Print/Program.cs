int[,] matrix2D_4x2 = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
int[,] matrix2D_3x3 = new int[3, 3] { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 } };
//
Print(matrix2D_4x2);
System.Console.WriteLine("***");
Print(matrix2D_3x3);
//
void Print(int[,] mat){
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            System.Console.Write(mat[i,j]);
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }
}