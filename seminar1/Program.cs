// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число a:"); 
string? numberA=Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
Console.WriteLine("Введите число b:"); 
string? numberB=Console.ReadLine();
int numberBint = Convert.ToInt32(numberB);
if(numberAint * numberAint==numberBint){
    Console.WriteLine("da");
}
else{
    Console.WriteLine("net");
}