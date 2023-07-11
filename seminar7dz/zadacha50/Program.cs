Console.WriteLine("Введите количество cтолбцов");
int zz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int rz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Строчку Числа");
int c=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Столбец Числа");
int b=Convert.ToInt32(Console.ReadLine());
int[,] a=new int[rz,zz];

for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        a[i,j]=Random.Shared.Next(0, 100);
        
    }
}
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        Console.Write("{0,3}", a[i, j]);
        
    }
    Console.WriteLine();
}
if((zz-1<c)||(rz-1<b)){
    Console.WriteLine("такого числа нет");


}
else{
     Console.WriteLine(a[b,c]);

}