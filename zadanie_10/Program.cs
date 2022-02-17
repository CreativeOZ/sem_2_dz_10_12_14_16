// Показать вторую цифру трёхзначного числа.

Console.Clear();

int TwoNumber(int Number)
{
    int result = Number % 11;
    return result;
}
Console.Write("Ввести трехзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра: " + TwoNumber(num));