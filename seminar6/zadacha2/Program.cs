

Console.WriteLine("введите число");
int a=Convert.ToInt32(Console.ReadLine());

int[] b=new int[a];
b[0]=0;
b[1]=1;
for(int i=2;i<a;i++){
    b[i]=b[i-1]+b[i-2];
    




}

Console.WriteLine(string.Join(", ", b));