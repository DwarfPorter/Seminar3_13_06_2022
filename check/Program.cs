// See https://aka.ms/new-console-template for more information
double[] CreateArray(int length) 
 { 
 double[] array = new double[length]; 
 for(int i = 0; i < array.Length; i++) 
 { 
     array[i] = new Random().Next(0, 100); 
 } 
 return array; 
 }

void PrintArray(double[] array){
    foreach(var element in array){
        System.Console.Write($"{element} ");
    }
}

var array = CreateArray(5);
PrintArray(array);