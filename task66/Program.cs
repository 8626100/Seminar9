//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

 Console.Clear();
 Console.WriteLine("Введите натуральное число M (начало интервала):");
 int M=Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите натуральное  число N (конец интервала):");
 int N=Convert.ToInt32(Console.ReadLine());

 SumElementsInInterval(M, N, 0);

 void SumElementsInInterval (int M, int N, int sum)
 {
     if (M > N) 
      {
        Console.WriteLine($"Сумма натуральных элементов в интервале от M до N =: {sum}"); 
        return;
      }
     sum = sum + M;
     M++;
     SumElementsInInterval(M, N, sum);
 }


    



