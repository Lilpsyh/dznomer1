Console.WriteLine("Введите количество строк");
int zz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int rz=Convert.ToInt32(Console.ReadLine());
int[,] a=new int[rz,zz];
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        
        a[i,j]=Random.Shared.Next(0,10);
        

        
    }
}
int ipos=0;
int jpos=0;
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        Console.Write("{0,3}", a[i, j]);
        
    }
    Console.WriteLine();
}
Console.WriteLine();
int min=a[0,0];
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        if(a[i,j]<min){
            min=a[i,j];
            jpos=j;
            ipos=i;

        }
    }
}
for(int i=ipos;i<rz;i++){
    for(int j=jpos;j<zz;j++){
        Console.Write("{0,3}", a[i, j]);}
    Console.WriteLine();}
    

