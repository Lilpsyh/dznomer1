Console.WriteLine("Введите число:"); 
string? al=Console.ReadLine();
int a = Convert.ToInt32(al);
for(int ind=1;ind<=a;ind++){
    if(ind%2==0){

        Console.WriteLine(ind); 
    }
}