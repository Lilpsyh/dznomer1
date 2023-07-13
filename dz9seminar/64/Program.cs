Console.WriteLine("Введите N");
int n=Convert.ToInt32(Console.ReadLine());
void vivod(int n){
    if(n==1){
        Console.Write(n);}
    else if(n>0){
        Console.Write(n + ", ");
        vivod(n-1);}
    

    
}


vivod(n);