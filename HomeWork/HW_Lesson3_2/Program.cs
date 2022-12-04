// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Dist3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distX = Math.Pow(x2 - x1,2);
    double distY = Math.Pow(y2 - y1,2);
    double distZ = Math.Pow(z2 - z1,2);
return Math.Sqrt(distX+distY+distZ);
    
}


Console.WriteLine(Dist3D(3, 6, 8, 2, 1, -7));
Console.WriteLine(Dist3D(7,-5, 0, 1,-1, 9));
