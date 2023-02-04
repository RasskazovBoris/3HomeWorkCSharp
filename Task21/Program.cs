Console.Write ("Insert number X of first point: ");
float numX1 = float.Parse (Console.ReadLine());

Console.Write ("Insert number Y of first point: ");
float numY1 = float.Parse (Console.ReadLine());

Console.Write ("Insert number Z of first point: ");
float numZ1 = float.Parse (Console.ReadLine());

Console.Write ("Insert number X of second point: ");
float numX2 = float.Parse (Console.ReadLine());

Console.Write ("Insert number Y of second point: ");
float numY2 = float.Parse (Console.ReadLine());

Console.Write ("Insert number Z of second point: ");
float numZ2 = float.Parse (Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((numX2 - numX1), 2) + Math.Pow((numY2 - numY1), 2)+ Math.Pow((numZ2 - numZ1), 2));
Console.WriteLine ($"Distance between two points equals {distance}");