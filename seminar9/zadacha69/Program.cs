Console.WriteLine("Введите число которое возводим");
int zz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int rz=Convert.ToInt32(Console.ReadLine());

int gachi(int n1, int n2){
    if(n2==0){
        return 1;
    }
    return gachi(n1,n2-1)*n1;
    
}
int b=gachi(zz,rz);
Console.WriteLine(b);