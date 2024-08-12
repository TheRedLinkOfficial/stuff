using System.Collections;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("insira o nome do usuário");

var usuário = Console.ReadLine();

Console.WriteLine("olá, " + usuário);

Console.WriteLine("deseja calcular (A) ou contar (B)?");

var operação = Console.ReadLine();

if (operação == "A"){ 
Console.WriteLine("insira um valor para A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("agora, insira um valor para B");
int b = int.Parse(Console.ReadLine());
int c;

c = (a + b);
Console.WriteLine("soma:" + c);
Console.ReadKey();

c = (a - b);
Console.WriteLine("subtração:" + c);
Console.ReadKey();

c = (a * b);
Console.WriteLine("multiplicação:" + c);
Console.ReadKey();

c = (a/b);
Console.WriteLine("divisão: " + c);

}
else{
    Console.WriteLine("insira o valor de X");
    int X = int.Parse(Console.ReadLine());
    Console.WriteLine("agora, escreva o valor de Y");
    int Y = int.Parse(Console.ReadLine());
    for(int c = X; c < Y; c++){
        Console.WriteLine(c);
        Console.ReadKey();
    }
}
/*
Console.WriteLine("insira um número");
int t = int.Parse(Console.ReadLine());
bool par = t % 2 == 0;

if(par){
    Console.ReadKey();
    Console.WriteLine("é par");
}
else{
    Console.ReadKey();
    Console.WriteLine("é ímpar");
}
*/