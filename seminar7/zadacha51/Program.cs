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
int summ=0;
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        if(i==j){
            summ=summ+a[i,j];

        }
        

        
    }
}
Console.WriteLine(summ);