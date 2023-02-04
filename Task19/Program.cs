Console.Write ("Insert the number: ");
int input = int.Parse (Console.ReadLine());
string number = input.ToString();
int length = number.Length;

if (input < 0)
{
    Console.WriteLine("This number isn't a palindrome"); // В моем понимании, отрицательное число не может быть палиндромом.
}
else{

string acc = "";
string acc2 = "";
while (length > 0)
{
    acc = (input % 10).ToString();
    input = input / 10;
    acc2 = acc2 + acc;
    length--;
}
if (acc2 == number)
{
    Console.WriteLine ("This number a palindrome!");
}
else
{
    Console.WriteLine("This number isn't a palindrome");
}}