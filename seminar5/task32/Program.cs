int[] gachi(int sa )

{   int[] numX=new int[sa];
    for(int i=0;i<numX.Length;i++){
        numX[i]=Random.Shared.Next(int.MinValue,int.MaxValue);
    }
    return numX;


}
int[] replace(int[] array){
    for(int i=0;i<array.Length;i++){
        array[i]=-array[i];
    }
    return array;
}

Console.WriteLine("Введите число:"); 
int[] lol=gachi(6);
Console.WriteLine(string.Join(", ", lol));
lol=replace(lol);
Console.WriteLine(string.Join(", ", lol));