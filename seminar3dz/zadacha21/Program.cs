int[] X= new int[2];
int[] Y= new int[2];
int[] Z= new int[2];
double rX=0;
double rY=0;
double rZ=0;
double res=0;
for(int i=0;i<2;i++){
    Console.WriteLine("Координату X, координату Y, последовательно 2 раза");
    Int32.TryParse(Console.ReadLine(), out X[i]);
    Int32.TryParse(Console.ReadLine(), out Y[i]);
    Int32.TryParse(Console.ReadLine(), out Z[i]);

}
rX=Math.Pow(X[1]-X[0],2);
rY=Math.Pow(Y[1]-Y[0],2);
rZ=Math.Pow(Z[1]-Z[0],2);
res=Math.Sqrt(rX+rY+rZ);
Console.WriteLine(res);

