//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9
Console.WriteLine("Введите число M");
int zz=222;
int Symmachisel(int a){
    if(a<=0){
        return 0;

    }
    return Symmachisel(a/10)+a%10;
   


    
    
    
    
}   
int a=Symmachisel(222);
Console.WriteLine(a);