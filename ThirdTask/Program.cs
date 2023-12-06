// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void FindMinSumInARow(int[,] matrix){

    int[] ArrayOfSums = new int[matrix.GetLength(0)];

    for(int i = 0; i < matrix.GetLength(0); i++){

        int sum = 0;

        for(int j = 0; j < matrix.GetLength(1); j++){

            sum = sum + matrix[i,j];

        }

        ArrayOfSums[i] = sum;
    }

    int min = ArrayOfSums[0];
    int minRow = 1;

    for(int k = 1; k < ArrayOfSums.Length; k++){

        if(min > ArrayOfSums[k]){

            min = ArrayOfSums[k];
            minRow = k + 1;

        }

    }

    ShowMatrix(matrix);
    System.Console.Write($"Минимальная сумма равна = {min} и находится в {minRow} строке");

}

int rows = ReadInt("Введите кол-во строк: ");
int columns = ReadInt("Введите кол-во столбцов: ");
int MightBeMin = ReadInt("Введите минимальное значение, которое может быть сгенерированно для массива: ");
int MightBeMax = ReadInt("Введите максимальное значение, которое может быть сгенерированно для массива: ");

int[,] matrix = GenerateMatrix(rows, columns, MightBeMin, MightBeMax);

FindMinSumInARow(matrix);