using System.Runtime;
using Microsoft.VisualBasic;

void message(string isso){
Console.WriteLine(isso);
}

void age(string name, int yo){
 message($"{name} tem {yo} anos");
}
void SaboMt(string name, int yo){
    int idade = 2024 - yo;
   age(name,idade);
}
Console.WriteLine("insira o nome da pessoa");
string nomePessoa = Console.ReadLine();
Console.WriteLine("agora, insira o ano de nascimento");
int dataNascimento = int.Parse(Console.ReadLine());
SaboMt(nomePessoa, dataNascimento);




int MaiorEntre(int a, int b){
    if (a>b){
        Console.WriteLine("o maior valor é "+ a);
        return a;
    }
    else if (a<b){
        Console.WriteLine("o maior valor é " + b);
        return b;
    }
    else{Console.WriteLine("ambos são iguais, logo, o maior valor é ");
    return a;}
}
Console.ReadKey();
Console.WriteLine("insira o valor de A");
int vA = int.Parse(Console.ReadLine());
Console.WriteLine("insira o valor de B");
int vB = int.Parse(Console.ReadLine());
MaiorEntre(vA,vB);