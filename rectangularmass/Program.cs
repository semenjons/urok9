// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строк





Console.WriteLine("Введите данные массива b - c и диапазон значений:");
 int b = InputNumbers("Введите b: ");
 int c = InputNumbers("Введите c: ");
 int rondom = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[b, c];
CreateArray(array);
WriteArray(array);

int minSumTop = 0;
int sumTop = SumTopElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumTop = SumTopElements(array, i);
  if (sumTop > tempSumTop)
  {
    sumTop = tempSumTop;
    minSumTop = i;
  }
}


int SumTopElements(int[,] array, int i)
{
  int sumTop = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumTop += array[i,j];
  }
  return sumTop;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array){
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
      array[i, j] = new Random().Next(rondom);
    }
  }
}

void WriteArray (int[,] array){
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
      Console.Write(array[i,j] + " ");}
    Console.WriteLine();
  }
}
Console.WriteLine($"\n{minSumTop+1} - строкa с наименьшей суммой ({sumTop}) элементов ");