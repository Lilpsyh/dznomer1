Console.WriteLine("введите число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int c=Convert.ToInt32(Console.ReadLine());
if((a<b+c)&&(b<a+c)&&(c<a+b)){
    Console.WriteLine("может существовать");
}
else{
    Console.WriteLine("не может");

}