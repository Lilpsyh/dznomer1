Console.WriteLine("Введите число M");
int zz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int rz=Convert.ToInt32(Console.ReadLine());

void gachi(int m, int n){
    if(n<m){
        return;
    }
    gachi(m,n-1);
    Console.Write($" {n}");

}
gachi(zz,rz);
