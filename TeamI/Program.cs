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

Coordinate coordinateA = new Coordinate();
coordinateA.X = xA;
coordinateA.Y = yA;

Coordinate coordinateB = new Coordinate();
coordinateB.X = xB;
coordinateB.Y = yB;

Coordinate coordinateC = new Coordinate();
coordinateC.X = xC;
coordinateC.Y = yC;

var array = new double[]
{
    FormulStore.SideLength(coordinateA, coordinateB),
    FormulStore.SideLength(coordinateB, coordinateC),
    FormulStore.SideLength(coordinateA, coordinateC)
};

Console.WriteLine("Length of AB is : " + array[0].ToString());
Console.WriteLine("Length of BC is : " + array[1].ToString());
Console.WriteLine("Length of AC is : " + array[2].ToString() + "\r\n");

Array.Sort(array);

var sidesLength = FormulStore.PowAll(array);
string isEquiLateralTriangle = FormulStore.IsEquiLateralTriangle(array) ? "" : "NOT";
string isoscelesTriangle = FormulStore.IsoscelesTriangle(array) ? "" : "NOT";
string isRightTriangle = FormulStore.IsRightTriangle(sidesLength) ? "" : "NOT";
double perimeter = FormulStore.Perimeter(array);



Console.WriteLine("Triangale IS " + isEquiLateralTriangle + " Equilareral");
Console.WriteLine("Triangale IS " + isoscelesTriangle + " Isosceles");
Console.WriteLine("Triangale IS " + isRightTriangle + " Right" + "\r\n");

Console.WriteLine("Perimeter: " + perimeter + "\r\n");

for (int i = 0; i < perimeter; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}