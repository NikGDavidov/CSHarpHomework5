// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
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
    int length = array.Length;
    int iMax = array.Length/2;
	int [] newArray = new int [iMax];
	for (int i=0; i<iMax; i++)
    {
	newArray[i]=array[i]*array[length-1-i];
	}
	PrintArray(newArray);