int[] gachi()

{   int[] numX=new int[12];

    for(int i=0;i<numX.Length;i++){
    numX[i]=Random.Shared.Next(-9,10);
    }
    return numX;


}
int sumpos(int[] massive)
{   int sum=0;
    for(int i=0;i<massive.Length;i++){
        if(massive[i]>0){
            sum=sum+massive[i];
        }
    }
    return sum;


}
int sumneg(int[] massive)
{
    int sum=0;
    for(int i=0;i<massive.Length;i++){
        if(massive[i]<0){
            sum=sum+=massive[i];

        }
    }
    return sum;
}

int[] array=gachi();
int i=sumpos(array);
int b=sumneg(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"сумма положительных {i}");
Console.WriteLine($"сумма отрицателных {b}");