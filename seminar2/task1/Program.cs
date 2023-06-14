
Console.WriteLine("Введите число a:"); 
string? numberA=Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
Console.WriteLine("Введите число b:"); 
string? numberB=Console.ReadLine();
int numberBint = Convert.ToInt32(numberB);
if(numberAint % numberBint ==0){
    Console.WriteLine("кратное");
}
else{
    Console.WriteLine("не кратное");
}

