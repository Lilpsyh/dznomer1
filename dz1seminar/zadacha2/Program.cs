Console.WriteLine("Введите число a:"); 
string? numberA=Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
Console.WriteLine("Введите число b:"); 
string? numberB=Console.ReadLine();
int numberBint = Convert.ToInt32(numberB);
if(numberAint>numberBint){
    Console.WriteLine($"max {numberAint}");

}
else if(numberBint>numberAint){
    Console.WriteLine($"max {numberBint}");

}
else{
    Console.WriteLine("равны");
}