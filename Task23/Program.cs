System.Console.Write ("Insert the number: ");
int num = int.Parse(System.Console.ReadLine());
int x = 1;
while (x <= num)
{
    double result = System.Math.Pow(x, 3);
    System.Console.Write($" {result}");
    x += 1;
}
