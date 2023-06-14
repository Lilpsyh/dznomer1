
Console.WriteLine("Введите число :"); 
string? numberA=Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
if(numberAint % 7*23 ==0){
    Console.WriteLine("кратно"); 

}
else{
    Console.WriteLine("не кратно"); 
}