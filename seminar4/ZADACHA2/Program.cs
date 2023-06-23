int read( ){
    Console.WriteLine("введите число");
    int sa=Convert.ToInt32(Console.ReadLine());
    return sa;
}


int chislo(int a ){
    int d=1;

    for(int i=1;i<=a;i++){
        d=d*i;

    }
    return d;


    }
int value1=read();
Console.WriteLine(chislo(value1));
//ГАЧИ СКВАД РУЛИТ