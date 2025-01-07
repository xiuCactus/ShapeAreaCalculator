// See https://aka.ms/new-console-template for more information

string shape;
float Area=0;
Console.WriteLine("choose the shape you want to calculate it's area:Square, Rectangle, Triangle or  Circle");
shape= Console.ReadLine();

if (shape== "Circle")
{
    Console.WriteLine("enter the circle Radius: ");
    float Radius = float.Parse(Console.ReadLine());

    Area = (float)Math.PI * Radius * Radius;
}
else if (shape=="Square")
{
    Console.WriteLine("enter the square side: ");
    float side = float.Parse(Console.ReadLine());

    Area = side * side;
}
else if (shape=="Rectangle")
{
    Console.WriteLine("enter the Rectangle width: ");
    float width = float.Parse(Console.ReadLine()) ;
    
    Console.WriteLine("enter the Rectangle height: ");
    float height = float.Parse(Console.ReadLine()) ;

    Area = width * height;
}
else if (shape=="Triangle")
{
    Console.WriteLine("enter the Triangle base: ");
    float baseLength = float.Parse(Console.ReadLine());
    
    Console.WriteLine("enter the Triangle height: ");
    float height = float.Parse(Console.ReadLine());

    Area = (baseLength * height) / 2;
}
else
{
    Console.WriteLine("Invalid shape");
    return; 
}

Console.WriteLine("The area of the shape is: "+ Area);
Console.ReadKey();
