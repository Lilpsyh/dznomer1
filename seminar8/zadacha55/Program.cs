Console.WriteLine("Введите количество строк");
int zz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int rz=Convert.ToInt32(Console.ReadLine());
int[,] a=new int[rz,zz];
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        Console.WriteLine("Введите элемент");
        a[i,j]=Convert.ToInt32(Console.ReadLine());
        

        
    }
}
int[,] b=new int[zz,rz];
for(int i=0;i<zz;i++){
    for(int j=0;j<rz;j++){
        b[i,j]=a[j,i];
    }
}
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        Console.Write("{0,3}", a[i, j]);
        
    }
    Console.WriteLine();
}
Console.WriteLine();
for(int i=0;i<zz;i++){
    for(int j=0;j<rz;j++){
        Console.Write("{0,3}", b[i, j]);
        
    }
    Console.WriteLine();
}