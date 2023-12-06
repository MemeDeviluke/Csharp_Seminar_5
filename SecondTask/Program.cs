// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int ReadInt(string text){

    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

int[,] GenerateMatrix(int row, int column, int leftRange, int rightRange){

    int[,] GeneratedMatrix = new int[row, column];
    Random random = new Random();

    for(int i = 0; i < GeneratedMatrix.GetLength(0); i++){
        for(int j = 0; j < GeneratedMatrix.GetLength(1); j++){
            GeneratedMatrix[i,j] = random.Next(leftRange, rightRange + 1);
        }
    }

    return GeneratedMatrix;

}

void ShowMatrix(int[,] ShowedMatrix){

    for(int i = 0; i < ShowedMatrix.GetLength(0); i++){
        for(int j = 0; j < ShowedMatrix.GetLength(1); j++){
            System.Console.Write(ShowedMatrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }

}

void SwapMatrixRows(int[,] matrix){

    ShowMatrix(matrix);

    int[] TempRow = new int[matrix.GetLength(1)];

    for(int j = 0; j < matrix.GetLength(1); j++){

        TempRow[j] = matrix[0,j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        
    }

    System.Console.WriteLine();

    for(int k = 0; k < TempRow.Length; k++){

        matrix[matrix.GetLength(0) - 1, k] = TempRow[k];

    }

    ShowMatrix(matrix);

}

int rows = ReadInt("Введите кол-во строк: ");
int columns = ReadInt("Введите кол-во столбцов: ");
int MightBeMin = ReadInt("Введите минимальное значение, которое может быть сгенерированно для массива: ");
int MightBeMax = ReadInt("Введите максимальное значение, которое может быть сгенерированно для массива: ");

int[,] matrix = GenerateMatrix(rows, columns, MightBeMin, MightBeMax);

SwapMatrixRows(matrix);