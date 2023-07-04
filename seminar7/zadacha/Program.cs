Console.WriteLine("Введите количество строк");
int zz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int rz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("диапазон чисел");
int s=Convert.ToInt32(Console.ReadLine());
int[,] a=new int[rz,zz];
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        a[i,j]=Random.Shared.Next(-s,s+1);
        
    }
}
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        Console.Write("{0,3}", a[i, j]);
        
    }
    Console.WriteLine();
}