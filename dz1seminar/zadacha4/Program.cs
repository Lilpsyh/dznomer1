Console.WriteLine("Введите число:"); 
string? al=Console.ReadLine();
int a = Convert.ToInt32(al);
Console.WriteLine("Введите число:"); 
string? bl=Console.ReadLine();
int b = Convert.ToInt32(bl);
Console.WriteLine("Введите число:"); 
string? cl=Console.ReadLine();
int c = Convert.ToInt32(cl);
if((a>=b) && (a>=c)){
    Console.WriteLine($"max {a}"); 

}
if((b>=a) && (b>=c)){
    Console.WriteLine($"max {b}"); 

}
if((c>=b) && (c>=a)){
    Console.WriteLine($"max {c}"); 

}