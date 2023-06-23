Console.WriteLine("Введите число:"); 
string? ad=Console.ReadLine();
int a = Convert.ToInt32(ad);
if((a<=9999)||(a>=100000)){
    Console.WriteLine("нужно ввести пятизначное число!"); 
}
else if((a/10000==a%10)&&(a/1000%10==a%100/10)){
    Console.WriteLine("палиндром"); 

}
else{
      Console.WriteLine("не палиндром"); 


}
