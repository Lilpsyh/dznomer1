Console.WriteLine("Введите число a:"); 
string? ad=Console.ReadLine();
int a = Convert.ToInt32(ad);
Console.WriteLine("Введите число b:"); 
string? ag=Console.ReadLine();
int b = Convert.ToInt32(ag);
int pow(int a,int b){
    int pr=1;
    for(int i=1;i<=b;i++){
        pr=pr*a;
        

    }
    return pr;

}
int c=pow(a,b);
Console.WriteLine(c);