int[] massiv(int d){
    Console.WriteLine("ввод массива");
    int[] a=new int[d];
    for(int i=0;i<a.Length;i++){
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return a;
}
int[] abs(int[]  array){
    int[] b=new int [(array.Length+1)/2];
    int sum=1;
    for(int i=0;i<b.Length;i++){
        b[i]=array[i]*array[array.Length-i-1];
    }
    if(array.Length%2!=0){
        b[b.Length-1]=array[array.Length/2];
    }
    return b;
}
Console.WriteLine("количество чисел в массиве");
int a=Convert.ToInt32(Console.ReadLine());
int[] b=massiv(a);
int[] d=abs(b);
Console.WriteLine("пары");
Console.WriteLine(string.Join(", ", d));