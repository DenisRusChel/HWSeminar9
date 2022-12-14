// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 5, 6, 7, 8""


string NaturalNumberRec(int m, int n)
{
  if (m == n) return Convert.ToString(m);
  return m + ", " + NaturalNumberRec(m + 1, n);
}
System.Console.WriteLine(NaturalNumberRec(1, 5));
