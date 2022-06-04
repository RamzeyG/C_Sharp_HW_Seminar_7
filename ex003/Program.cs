//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


void Func(){
    
    int size1 = Convert.ToInt32(new Random().Next(5, 10));
    int size2 = Convert.ToInt32(new Random().Next(5, 10));
    
    int[,] array = new int[size1, size2];
    int count1 = 0;
     

    while (count1 < size1){
        int count2 = 0;
        while(count2 <size2){
            Random x = new Random();
            int random = Convert.ToInt32(x.Next(0, 100));
            
            array[count1, count2] = random;
            count2++;
        }
        count1++;
    }
    
    int rows = array.GetUpperBound(0) + 1;    
    int columns = array.Length / rows;

    Console.WriteLine();
    Console.WriteLine($"Был созан массив размером: {columns} столбцов, {rows} строк");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
    
    double[] ArrayAverage = new double[columns];

    for (int i = 0; i < columns; i++)
    {
        double summ = 0;
        for (int j = 0; j < rows; j++)
        {
            summ = summ + array[j, i];
            
        }
        
        ArrayAverage[i] = summ/rows;
        
        
    }

    Console.WriteLine();
    Console.WriteLine("Среднее арифтметическое по столбцам:");
    
    for (int i = 0; i<columns; i++){
        Console.Write($"{Math.Round(ArrayAverage[i], 2)} \t");
    }

}


Func();
