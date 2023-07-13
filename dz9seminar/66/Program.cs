Console.WriteLine("Введите M");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());
int vivod(int m,int n){
    if(m>n){
        return 0;


    }
    return vivod(m+1,n)+m;

}
int a=vivod(m,n);
Console.WriteLine(a);