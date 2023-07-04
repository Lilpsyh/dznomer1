Console.WriteLine("введите колво чисел");
int a=Convert.ToInt32(Console.ReadLine());
int[] b=new int[a];
int count=0;
for(int i=0;i<a;i++){
    Console.WriteLine("введите число");
    b[i]=Convert.ToInt32(Console.ReadLine());
    if(b[i]>0){
        count++;
    }
}
Console.WriteLine(count);