// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double[,] CreateRandom2dArray (int m, int n)
// {
//     double[,] array = new double [m,n];
//     for (int i = 0; i<m; i++)
//         for (int j=0;j<n;j++)
//             array[i,j] = Math.Round(Convert.ToDouble(new Random().Next(0,999))/new Random().Next(0,999),2);
//     return array;
// }
// void Show2dArray (double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j]>0 && array[i,j]<10) Console.Write(array[i,j] + "   ");
//             if (array[i,j]>9 && array[i,j]<100) Console.Write(array[i,j] + "  ");
//             if (array[i,j]>99) Console.Write(array[i,j] + " "); 
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("___________________________________");
// }
// double[,] myArray = CreateRandom2dArray(3,5);
// Show2dArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// void ShowElement(int[,] array, int row, int column)
// {
//     if (row<=array.GetLength(0) && column<=array.GetLength(1)) 
//     Console.WriteLine($"The value of the selected item {array[row,column]}");
//     else Console.WriteLine("Item missing");
// }
// int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int [rows,columns];
//     for (int i = 0; i<rows; i++)
//         for (int j=0;j<columns;j++)
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//     return array;
// }
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j]>0 && array[i,j]<10) Console.Write(array[i,j] + "   ");
//             if (array[i,j]>9 && array[i,j]<100) Console.Write(array[i,j] + "  ");
//             if (array[i,j]>99) Console.Write(array[i,j] + " "); 
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("___________________________________");
// }
// int m = new Random().Next(2,10);
// int n = new Random().Next(2,10);
// int[,] myArray = CreateRandom2dArray(m,n,1,999);
// Show2dArray(myArray);
// Console.WriteLine("Please enter row element");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please enter column element");
// int column = Convert.ToInt32(Console.ReadLine());
// ShowElement(myArray,row,column);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i,j]>0 && array[i,j]<10) Console.Write(array[i,j] + "   ");
//             if (array[i,j]>9 && array[i,j]<100) Console.Write(array[i,j] + "  ");
//             if (array[i,j]>99) Console.Write(array[i,j] + " "); 
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("___________________________________");
// }
// int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int [rows,columns];
//     for (int i = 0; i<rows; i++)
//         for (int j=0;j<columns;j++)
//             array[i,j] = new Random().Next(minValue,maxValue+1);
//     return array;
// }
// void Show(double[] myArray)
// {   
//     for (int i = 0; i<myArray.Length; i++)
//         Console.WriteLine(i+1 + "'column = " + myArray[i] + " ");
// }
// double[] ArithmeticMeanOfColumns (int[,] array)
// {
// double[] arithmeticMean = new double[array.GetLength(1)];
// for (int l = 0, c=0; l<array.GetLength(1); l++, c++)
// {
//     double sum=0;
//         for(int r=0; r<array.GetLength(0);r++)
//         sum=sum+array[r,c];
// arithmeticMean[l] = Math.Round(sum/array.GetLength(0),2);
// }
// return arithmeticMean;
// }
// int m = new Random().Next(2,10);
// int n = new Random().Next(2,10);
// int[,] myArray = CreateRandom2dArray(m,n,1,999);
// Show2dArray(myArray);
// double[] result = ArithmeticMeanOfColumns(myArray);
// Console.WriteLine("The Arithmetic means of columns are : ");
// Show(result);
// Console.WriteLine();