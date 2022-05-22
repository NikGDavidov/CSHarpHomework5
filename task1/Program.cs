// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int [] GetArray(int length)
	{
	    int [] result = new int [length];
	    for (int i = 0 ; i< length ; i++)
	    {
	        result[i]= new Random().Next(100,999);
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
	//PrintArray(GetArray(123));
	int [] array = GetArray(12);
	PrintArray(array);
	
	int count = 0;
	for (int i=0; i<12; i++){
	    if (array[i]%2==0) count ++;
	}
	Console.WriteLine("Количество четных чисел в массиве " + count);