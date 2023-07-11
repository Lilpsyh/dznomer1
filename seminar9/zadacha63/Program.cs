Console.WriteLine("Введите число");
int zz=Convert.ToInt32(Console.ReadLine());
int n=0;
void gachi(int l){
    if(l<1){
        return;

    }
    gachi(l-1);
    Console.Write($" {l}");

}
gachi(zz);
