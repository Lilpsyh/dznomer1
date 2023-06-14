Console.WriteLine("Введите число N:"); 
string? n=Console.ReadLine();
int b = Convert.ToInt32(n);
for(int i=-b;i<=b;i++){
    Console.WriteLine(i);
}