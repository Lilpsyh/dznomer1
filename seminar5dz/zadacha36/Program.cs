Console.WriteLine("Введите размер массива");
int rz=Convert.ToInt32(Console.ReadLine());
int[] d=new int[rz];
Console.WriteLine("В каком диапазоне будут числа? (В + и -)");
int a=Convert.ToInt32(Console.ReadLine());
int summ=0;
for(int i=0;i<rz;i++){
    d[i]=Random.Shared.Next(-a,a+1);

}
for(int i=1;i<rz;i++){
    if(i%2==1){
        summ=summ+d[i];
    }
    
    
}

Console.WriteLine($"[{string.Join(", ", d)}] сумма стоящих на нечетных - {summ}");