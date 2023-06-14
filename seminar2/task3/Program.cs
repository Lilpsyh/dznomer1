
Console.WriteLine("Введите число a:"); 
string? numberA=Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
Console.WriteLine("Введите число b:"); 
string? numberB=Console.ReadLine();
int numberBint = Convert.ToInt32(numberB);
if(numberAint * numberAint == numberBint ){
    Console.WriteLine("да");

}
else if(numberAint  == numberBint*numberBint ){
    Console.WriteLine("да");

}
else{
    Console.WriteLine("нет");
}
