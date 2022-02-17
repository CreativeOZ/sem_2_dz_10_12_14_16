// Найти третью цифру числа или сообщить, что её нет.
Console.Clear();

Console.Write("Ввести число: ");
string A = Console.ReadLine();
int X = A.Length;
if (X < 3) Console.WriteLine ("Третий цифры нет.");
else Console.WriteLine("Третья цифра: " + A[2]);