Console.WriteLine("Введите размер массива");
int rz=Convert.ToInt32(Console.ReadLine());
int count=0;
int[] d=new int[rz];
    
for(int i=0;i<rz;i++){      
    d[i]=Random.Shared.Next(100,1000);

    }

for(int i=0;i<rz;i++){  
    if(d[i]%2==0){
        count++;
        }}
Console.WriteLine($"[{string.Join(", ", d)}] четных - {count}");
    
    
   
        


