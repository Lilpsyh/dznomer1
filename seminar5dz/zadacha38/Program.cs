Console.WriteLine("Введите размер массива");
int rz=Convert.ToInt32(Console.ReadLine());
double[] d=new double[rz];
int raz;

for(int i=0;i<rz;i++){
    Random rand = new Random();
    d[i] = rand.NextDouble();
    d[i]=d[i]*100;
    Console.WriteLine($"{d[i]:F2}");
    
}
double max=d[0];
double min=d[0];
for(int i=0;i<rz;i++){
    if(d[i]>max){
        max=d[i];

    }
    if(d[i]<min){
        min=d[i];
        
    }

    
    
}
Console.WriteLine($"разница между максимальным и минимальным элементом {max-min:F2}");
