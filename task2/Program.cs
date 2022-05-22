// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int [] GetArray(int length)
	{
	    int [] result = new int [length];
	    for (int i = 0 ; i< length ; i++)
	    {
	        result[i]= new Random().Next(10);
	    }
	    return result;
	}
	void PrintArray(int[] array)
	{
	    int length = array.Length;
	    for (int i=0; i<length-1; i++)
	    {
	        Console.Write($"{array[i]}, ");
	    }
	    Console.Write(array[length-1]);
	    Console.WriteLine();
	}

	int [] array = GetArray(12);
	PrintArray(array);
	
	int count = 0;
	for (int i=1; i<12; i=i+2){
	   count += array[i];
	}
	Console.WriteLine("сумма элементов, стоящих на нечётных позициях " + count);