int read( ){
    Console.WriteLine("введите число");
    int sa=Convert.ToInt32(Console.ReadLine());
    return sa;}

void gachi()

{   int[] numX=new int[] sa;
    int h=numX.Length;


    for(int i=0;i<h;i++){
        Random rnd=new Random();
        numX[i] = rnd.Next()%2; }
    
    for(int i=0;i<h;i++){
        Console.WriteLine(numX[i]);
    }
   

}

gachi(read());