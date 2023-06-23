int read( ){
    Console.WriteLine("введите число");
    int sa=Convert.ToInt32(Console.ReadLine());
    return sa;
}


int symma(int a ){
    int d=0;

    while (a!=0){
        a=a/10;
        d=d+1;
    }
    return d;


    }
int value1=read();
Console.WriteLine(symma(value1));