//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


void Func(){
    int NumberColumn = 0;
    int NumberRow = 0;
    
    void Input(){
        try{
            Console.WriteLine("Введите номер столбца");
            NumberColumn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер строки");
            NumberRow = Convert.ToInt32(Console.ReadLine());
            
            
        }
        catch{
            Console.WriteLine("Неправильный ввод, пожалуйста введите целое число.");
            Input();
        
        }
                
    }
    Input();
        
    int size1 = Convert.ToInt32(new Random().Next(5, 10));
    int size2 = Convert.ToInt32(new Random().Next(5, 10));
    
    double[,] array = new double[size1, size2];
    int count1 = 0;
    
    
    

    while (count1 < size1){
        int count2 = 0;
        while(count2 <size2){
            Random x = new Random();
            double random = Convert.ToDouble(x.Next(-100, 100)/10.00);
            
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
    
    try{
        Console.WriteLine($"Элемент в позиции {NumberColumn}, {NumberRow} (Столбец {NumberColumn + 1}, Строка {NumberRow + 1}) имеет значение: {array[NumberColumn, NumberRow]}");
    }
    catch{
        Console.WriteLine($"Элемент в позиции {NumberColumn}, {NumberRow} (Столбец {NumberColumn + 1}, Строка {NumberRow + 1}) не существует");
    }

}


Func();

