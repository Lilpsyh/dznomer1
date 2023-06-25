int[] massive(){
    int[] a=new int[8];
    for(int i=0;i<8;i++){
        Console.WriteLine("Введите число массива:"); 
        a[i]=Convert.ToInt32(Console.ReadLine());

    }
    return a;

    
}
int[] b=massive();
Console.WriteLine($"[{string.Join(", ", b)}]");