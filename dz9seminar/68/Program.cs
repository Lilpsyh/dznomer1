Console.WriteLine("Введите M");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());
int vivod(int m,int n){
    if(m==0){
        return n+1;
    }
    if((m>0) && (n==0)){
        return vivod(m-1,1);
    }
    if(( m > 0) && (n > 0)){
        return vivod(m-1,vivod(m,n-1));
    }
    else{ return 0;}
}
int a=vivod(m,n);
Console.WriteLine(a);