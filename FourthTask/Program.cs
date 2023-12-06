// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
//                             на пересечении которых расположен наименьший элемент массива. 
//                             Под удалением понимается создание нового двумерного массива без строки и столбца

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

void DeleteRowAndColumn(int[,] matrix, int NewRow, int NewColumn){

    int min = matrix[0,0];
    int minRow = 0;
    int minColumn = 0;

    int[,] newMatrix = new int[NewRow - 1, NewColumn - 1];

    for(int i = 0; i < matrix.GetLength(0); i++){

        for(int j = 0; j < matrix.GetLength(1); j++){

            if(min > matrix[i, j]){

                min = matrix[i,j];
                minRow = i;
                minColumn = j;

            }

        }
    }

    int TempRow = 0;
    int TempColumn = 0;

    for(int k = 0; k < newMatrix.GetLength(0); k++){

        if(TempRow == minRow){
            TempRow++;
        }

        for(int l = 0; l < newMatrix.GetLength(1); l++){

            if(TempColumn == minColumn){
                TempColumn++;
            }

            newMatrix[k, l] = matrix[TempRow, TempColumn];

            TempColumn++;

        }

        TempColumn = 0;
        TempRow++;

    }

    
    System.Console.WriteLine();
    System.Console.WriteLine($"Минимальный элемент ->{min} находится на {minRow + 1} строке и {minColumn + 1} столбце");
    System.Console.WriteLine();
    ShowMatrix(newMatrix);

}

int rows = ReadInt("Введите кол-во строк: ");
int columns = ReadInt("Введите кол-во столбцов: ");
int MightBeMin = ReadInt("Введите минимальное значение, которое может быть сгенерированно для массива: ");
int MightBeMax = ReadInt("Введите максимальное значение, которое может быть сгенерированно для массива: ");

int[,] matrix = GenerateMatrix(rows, columns, MightBeMin, MightBeMax);

ShowMatrix(matrix);

DeleteRowAndColumn(matrix, rows, columns);