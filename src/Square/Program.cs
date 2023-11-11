using Square;

string shape;

main:

Console.WriteLine("Choose shape\n[0] - Circle\n[1] - Triangle\n");
shape = Console.ReadLine();

switch (shape)
{
    case "0":
        Console.Write("Input radius of circle : ");
        double radius = double.Parse(Console.ReadLine());
        double circleArea = AreaCalculator.CircleArea(radius);
        Console.WriteLine($"Circle area equals : {circleArea}");
        
        break;
    case "1":
        Console.Write("Input three sides of triangle (3 4 5): ");
        var sides = Console.ReadLine().Split().Select(x => double.Parse(x)).ToList();
        var triangleArea = AreaCalculator.TriArea(sides[0], sides[1], sides[2]);
        if(sides[0] == sides[1] || sides[2] == sides[0] || sides[1] == sides[2])
            Console.WriteLine($"Triangle area equals : {triangleArea} and its right-angled triangle.");
        else
            Console.WriteLine($"Triangle area equals : {triangleArea}");
        
        break;
    default:
        Console.Clear();
        Console.WriteLine("You can input only 0(circle) and 1(triangle).");
        goto main;
}