using TeamI;

Console.WriteLine("Enter coordinate x of dot A");
var xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot A");
var yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate x of dot B");
var xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot B");
var yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate x of dot C");
var xC = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot C");
var yC = Convert.ToDouble(Console.ReadLine());

Coordinate coordinateA = new Coordinate()
{
    X = xA, //A (x)
    Y = yA, //A(,y)
};
Coordinate coordinateB = new Coordinate()
{
    X = xB,
    Y = yB,
};
Coordinate coordinateC = new Coordinate()
{
    X = xC,
    Y = yC
};

var array = new double[]
{
    FormulStore.SideLength(coordinateA, coordinateB),
    FormulStore.SideLength(coordinateB, coordinateC),
    FormulStore.SideLength(coordinateA, coordinateC)
};

Console.WriteLine("Length of AB is : " + array[0].ToString());
Console.WriteLine("Length of BC is : " + array[1].ToString());
Console.WriteLine("Length of AC is : " + array[2].ToString() + "\r\n");