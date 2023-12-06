// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void FindElement(int[,] SomeMatrix, int row, int column){

    if(row > SomeMatrix.GetLength(0) || column > SomeMatrix.GetLength(1)){

        System.Console.WriteLine("Такого элемента нет");

    }
    else{

        ShowMatrix(SomeMatrix);
        System.Console.WriteLine($"Ваше число: {SomeMatrix[row - 1, column - 1]}");

    }
}

int rows = ReadInt("Введите кол-во строк: ");
int columns = ReadInt("Введите кол-во столбцов: ");
int MightBeMin = ReadInt("Введите минимальное значение, которое может быть сгенерированно для массива: ");
int MightBeMax = ReadInt("Введите максимальное значение, которое может быть сгенерированно для массива: ");
int GetElemRow = ReadInt("Введите строку у элемента, который хотите получить: ");
int GetElemColumn = ReadInt("Введите столбец у элемента, который хотите получить: ");

int[,] matrix = GenerateMatrix(rows, columns, MightBeMin, MightBeMax);

FindElement(matrix, GetElemRow, GetElemColumn);