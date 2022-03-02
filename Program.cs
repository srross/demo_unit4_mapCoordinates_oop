//--------------------------------- STUDENT -> demo of what doesn't work
using demo_unit4_mapCoordinates_oop;

//Student f = new Student("John", 20);
//Console.WriteLine(f.Name);
//Console.WriteLine(f.Age);

//Student f2 = new Student("Melissa", 100);
//Console.WriteLine(f2.Name);
//Console.WriteLine(f2.Age);

//f.Name = "Bill";  // control access - set properties to private so they can only be changed within scope, or within the Student class

//--------------------------------- CIRCLE -> works
//var circle = new Circle(5);
//Console.WriteLine(circle.GetCircumference());

//--------------------------------- exercise 42: Point.cs -> works

var enterPt1 = "y";
var enterAnotherPt = "y";


while (enterPt1 == "y" || enterAnotherPt == "y")
{
    double x;
    double y;

    Console.WriteLine("enter a number for x");
    var userInputX = double.TryParse(Console.ReadLine(), out x); // why output 0 when letters are entered?

    Console.WriteLine("enter a number y");
    var userInputY = double.TryParse(Console.ReadLine(), out y);

    //--------------------------------- exercise 42: Point.cs

    var point = new Point(x, y);
    Console.WriteLine(point.MapPointObject());

    //--------------------------------- exercise 43: CalculateDistance()

    Console.WriteLine(point.CalculateDistance());

    enterPt1 = "n"; // stop coord 1 entrys

    // //--------------------------------- exercuse 44 CalculateMidpoint()

    Console.WriteLine("Enter coordinates for another point: ");
    double[] pt = new double[2];
    var userInputX2 =  double.TryParse(Console.ReadLine(), out pt[0]);
    var userInputY2 = double.TryParse(Console.ReadLine(), out pt[1]);

    point = new Point(x, y, pt);
    Console.WriteLine(point.CalculateMidpoint(pt));

    Console.WriteLine("Would you like to continue (y/n): ");
    enterAnotherPt = Console.ReadLine();
    enterPt1 = enterAnotherPt;
}

Console.WriteLine("By-bye");

Console.ReadLine();

// https://www.completecsharptutorial.com/basic/pass-array-parameter.php#:~:text=An%20array%20can%20also%20be%20passed%20to%20a,an%20array%20as%20argument%20and%20then%20processes%20them.