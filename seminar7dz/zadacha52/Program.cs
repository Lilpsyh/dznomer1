Console.WriteLine("Введите количество cтолбцов");
int zz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int rz=Convert.ToInt32(Console.ReadLine());
int[,] a=new int[rz,zz];
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        a[i,j]=Random.Shared.Next(0, 10);
        
    }
}
int[,] b=new int[zz,rz];
for(int i=0;i<zz;i++){
    for(int j=0;j<rz;j++){
        b[i,j]=a[j,i];}}



for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        Console.Write("{0,3}", a[i, j]);
    }
    Console.WriteLine();}
double[] c=new double[zz];
for(int i=0;i<zz;i++){
    for(int j=0;j<rz;j++){
        c[i]=c[i]+b[i,j];}}

for(int i=0;i<zz;i++){
    c[i]=c[i]/rz;
    Console.Write($"{c[i].ToString("F" + 2)} ");

}
