Console.WriteLine("введите число:");
int a;
Int32.TryParse(Console.ReadLine(), out a);
for(int i=1;i<=a;i++){
    Console.WriteLine(i*i*i);
    
}