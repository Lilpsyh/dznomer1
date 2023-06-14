string? numberA=Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
if(numberAint==1){Console.WriteLine("Понедельник");}
if(numberAint==2){Console.WriteLine("Вторник");}
if(numberAint==3){Console.WriteLine("Среда");}
if(numberAint==4){Console.WriteLine("Четверг");}
if(numberAint==5){Console.WriteLine("Пятница");}
if(numberAint==6){Console.WriteLine("Суббота");}
if(numberAint==7){Console.WriteLine("Воскресенье");}
if(numberAint>=8){Console.WriteLine("ошибка");}
if(numberAint<=0){Console.WriteLine("ошибка");}
