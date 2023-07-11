//перевести десятичное число в двоичное
int a=13;
void printbinary(int decnumber){
    if(decnumber==0){
        return;

    }
    printbinary(decnumber/2);
    Console.Write(decnumber%2);

}
printbinary(a); 