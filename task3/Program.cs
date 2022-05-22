
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double [] GetArray(int length)
	{
	    double [] result = new double [length];
	    for (int i = 0 ; i< length ; i++)
	    {
	        result[i]= Math.Round(new Random().NextDouble()*100,4);
	    }
	    return result;
	}
void PrintArray(double[] array)
	{
	    int length = array.Length;
	    for (int i=0; i<length-1; i++)
	    {
	        Console.Write($"{array[i]}, ");
	    }
	    Console.Write(array[length-1]);
	    Console.WriteLine();
	}

double [] array = GetArray(12);
PrintArray(array);
	
   double min = array[0];
   double max = array[0]; 
	for (int i=1; i<12; i++){
	if (array[i] < min) min = array[i];
    if (array[i] >max) max = array[i];
	}

Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементом массива {max-min}");