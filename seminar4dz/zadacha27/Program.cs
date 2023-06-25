Console.WriteLine("Введите число a:"); 
string? ad=Console.ReadLine();
int a = Convert.ToInt32(ad);




int aaa(int a){
    int c=a;
    int sum=0;
    while(c!=0){
        sum=sum+c%10;
        c=c/10;

    }
    return sum;

}
int b=aaa(a);
Console.WriteLine(b);