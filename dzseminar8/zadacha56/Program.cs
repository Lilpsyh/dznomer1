Console.WriteLine("Введите количество столбцов");
int zz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int rz=Convert.ToInt32(Console.ReadLine());
int[,] array=new int[rz,zz];
int rows = array.GetLength(0);
int cols = array.GetLength(1);
for(int i=0;i<rows;i++){
    for(int j=0;j<cols;j++){
        array[i,j]=Random.Shared.Next(0, 10);
        
    }
}
int[] b=new int[rows];
for(int i=0;i<rows;i++){
    for(int j=0;j<cols;j++){
        b[i]=b[i]+array[i,j];
    }
}
for(int i=0;i<rows;i++){
    for(int j=0;j<cols;j++){
        Console.Write("{0,3}", array[i, j]);
        
    }
    Console.WriteLine();
}

int min=b[0];
int minc=0;
for(int i=0;i<rows;i++){
    if(b[i]<min){
        min=b[i];
        minc=i;

    }

}
Console.WriteLine($"{minc+1} строка");
        