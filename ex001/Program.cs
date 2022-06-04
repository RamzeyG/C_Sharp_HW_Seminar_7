//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void GetTwoLevelArray(){
        
    int size1 = Convert.ToInt32(new Random().Next(5, 10));
    int size2 = Convert.ToInt32(new Random().Next(5, 10));
    
    double[,] array = new double[size1, size2];
    int count1 = 0;
    
    
    

    while (count1 < size1){
        int count2 = 0;
        while(count2 <size2){
            Random x = new Random();
            double random = Convert.ToDouble(x.Next(1, 100)/10.00);
            
            array[count1, count2] = random;
            count2++;
        }
        count1++;
    }
    Console.WriteLine();
    Console.WriteLine("Был созан массив: ");
    int rows = array.GetUpperBound(0) + 1;    
    int columns = array.Length / rows;
    double[,] ArrayCopy = new double[columns, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            ArrayCopy[i, j] = array[i, j];
        }
        Console.WriteLine();
    }

    Console.WriteLine();
     
    Console.WriteLine($"Копия массива array:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{ArrayCopy[i, j]} \t");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Hello, World!");
