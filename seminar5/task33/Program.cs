int[] massiv(int d){
    Console.WriteLine("ввод массива");
    int[] a=new int[d];
    for(int i=0;i<a.Length;i++){

        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return a;
}
bool findd(int find, int[] array ){
    bool a=false;
    for(int i=0;i<array.Length;i++){
        if(find==array[i]){
            a=true;

        }
    }
    return a;}
Console.WriteLine("количество чисел в массиве");
int a=Convert.ToInt32(Console.ReadLine());
int[] b=massiv(a);
bool c;
Console.WriteLine("число которое ищем");
int k=Convert.ToInt32(Console.ReadLine());
c=findd(k,b);
if(c==false){
    Console.WriteLine("нету");
}
else{
    Console.WriteLine("есть");
}

