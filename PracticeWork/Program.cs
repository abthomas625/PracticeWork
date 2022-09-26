// See https://aka.ms/new-console-template for more information
string restart = "yes";
while (restart == "yes" || restart == "y")
{
    Console.WriteLine("Input the radius of a circle.");

    string input = Console.ReadLine();
    double radius = double.Parse(input);

    Console.WriteLine("Radius: " + radius);
    Console.WriteLine();

    double area = Math.PI * radius * radius;

    Console.WriteLine("Area: " + area);

    Console.WriteLine("Would you like to measure the radius of another circle? Yes/No");
    restart = Console.ReadLine();
}
Console.WriteLine("Goodbye!");