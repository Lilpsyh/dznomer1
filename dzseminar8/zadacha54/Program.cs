Console.WriteLine("Введите количество столбцов");
int zz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int rz=Convert.ToInt32(Console.ReadLine());
int[,] array=new int[rz,zz];
int rows = array.GetLength(0);
int cols = array.GetLength(1);
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        array[i,j]=Random.Shared.Next(0, 10);
        
    }
}
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols - 1; j++)
        {
            for (int k = 0; k < cols- 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
                }
            }
        }
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    

