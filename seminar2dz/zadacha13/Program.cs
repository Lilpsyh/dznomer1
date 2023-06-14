Console.WriteLine("Введите число:"); 
string? numberA=Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
int b=numberAint;
int ind=0;
int c=0;
while(b!=0){
    b=b/10;
    ind++;


}
if(ind <=2){
    Console.WriteLine("третьей цифры нет");

}
else{
    for(int j=ind;j>3;j--){
        numberAint=numberAint/10;
        
    }
    
    
    
    
}
Console.WriteLine(numberAint%100%10);