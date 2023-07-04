//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] kxy=new double [2];
double[] kxy2=new double [2];
for(int i=0;i<2;i++){
    Console.WriteLine("введите сначало k для каждой точки потом b");
    kxy[i]=Convert.ToInt32(Console.ReadLine());
    kxy2[i]=Convert.ToInt32(Console.ReadLine());
    

}
double k3=kxy[0]-kxy[1];
double b3=kxy2[0]-kxy2[1];
double x=-(b3/k3);
double y=kxy[0]*x+kxy2[0];
Console.WriteLine($"({x}; {y})");
