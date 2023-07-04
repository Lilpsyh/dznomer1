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
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        if((i%2==1)&&(j%2==1)){
            a[i,j]=a[i,j]*a[i,j];
        }
        

        
    }
}

for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        Console.Write("{0,3}", a[i, j]);
        
    }
    Console.WriteLine();
}