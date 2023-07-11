Console.WriteLine("Введите количество строк");
int zz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int rz=Convert.ToInt32(Console.ReadLine());
double[,] a=new double[rz,zz];

for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        a[i,j]=Random.Shared.Next(-100, 100)/10.0;
        
    }
}
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        Console.Write("{0,5}", a[i, j]);
        
    }
    Console.WriteLine();
}