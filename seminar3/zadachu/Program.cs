//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B(2, 1)-> 5,09
//A(7, -5); B(1, -1)-> 7,21

double res = 0;
int sumX = 0, sumY = 0; 
int[] numX = new int[2];
int[] numY = new int[2];

for (int i = 0; i < 2; i++) { 
    Console.WriteLine("Координату X, координату Y, последовательно 2 раза");
    Int32.TryParse(Console.ReadLine(), out numX[i]);
    Int32.TryParse(Console.ReadLine(), out numY[i]);
}

sumX = numX[0] + numX[1];
sumY = numY[0] + numY[1];

Console.WriteLine(Math.Sqrt((Math.Pow(sumX, 2) + Math.Pow(sumY, 2))));
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//int num = 0;
//string str = "";
//Console.WriteLine("Введите число:");
//if (Int32.TryParse(Console.ReadLine(), out num))
//{

//    if (num == 1) { str = "X - 0 до бесконечность, Y - 0 до бесконечность"; }
//    else if (num == 2) { str = "X - 0 - минус бесконечность, Y - 0 - бесконечность"; }
//    else if (num == 3) { str = "X - 0 - минус бесконечность, Y - 0 - минус бесконечность"; }
//    else if (num == 4) { str = "X - 0 - бесконечность, Y - 0 - минус бесконечность"; }
//    Console.WriteLine(str);
//}
//else {
//    Console.WriteLine("Не число!");
//}
