Console.WriteLine("Введите день недели"); 
string? numberA=Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
if(numberAint>=1 && numberAint <=5){
    Console.WriteLine("нет"); 

}
else if(numberAint>=6 && numberAint <=7){
    Console.WriteLine("да"); 

}
else{
    Console.WriteLine("такого дня нету"); 


}