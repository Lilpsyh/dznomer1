int  numb= Random.Shared.Next(100, 1000);   // генерируес число

int  first = numb / 100;                     // берем сотни
int  second= numb % 10;                     // берем единицы

int newNum = first * 10 + second;            // тут сотни в десятки и складываем единицы

Console.WriteLine("число число = " + numb);
Console.WriteLine("новое число = " + newNum);
/// ГОТОВО))

