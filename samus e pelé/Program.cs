Console.WriteLine("você quer testar média comum(1) ou ponderada(2)?");
int teste = int.Parse(Console.ReadLine());

if (teste == 1){
Console.WriteLine("Insira o valor da primeira nota");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor da segunda nota");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor da terceira nota");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor da quarta nota");
int nota4 = int.Parse(Console.ReadLine());
Console.WriteLine(nota4);

int média = (nota1 + nota2 + nota3 + nota4)/4;

Console.WriteLine("Aqui está a média do aluno:" + média);
if(média >=60){
  Console.ReadKey();
  Console.WriteLine("o aluno, com a nota " + média + " está aprovado!");
}
else if (média <=20){
Console.WriteLine("considerando a nota final, o aluno está reprovado...");
    
  }
  else{
   Console.ReadKey();
   Console.WriteLine("com esta média, o aluno está Em recuperação...");
   Console.WriteLine("gostaria de saber quanto precisa para passar na recuperação? (1 para sim, 2 para não)");
   int opção = int.Parse(Console.ReadLine());
   if (opção ==1){
    float previsao = 120 - média;
    Console.WriteLine("considerando as notas:" + nota1 + ", " + nota2 + ", " + nota3 + " e " + nota4 +", o aluno precisaria de " + previsao + " para passar de ano");
   }
   else{
    Console.WriteLine("ok!");
   }
   Console.WriteLine("insira o valor da nota da prova final");
   int Nota5 = int.Parse(Console.ReadLine());
   float NewMedia = ((nota1 + nota2 + nota3 + nota4 + Nota5)/5);
   if(NewMedia >=60){
    Console.WriteLine("Considerando a nota final, o aluno está Aprovado!!!");}
    else{Console.WriteLine("considerando a média " + média + ", o aluno está reprovado...");}}
}


if (teste == 2){
    Console.WriteLine("Qual o peso da nota 1?");
    int peso1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual o peso da nota 2?");
    int peso2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual o peso da nota 3?");
    int peso3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual o peso da nota 4?");
    int peso4 = int.Parse(Console.ReadLine());
    Console.WriteLine("Certo. Então, os pesos são" + peso1 + ", " + peso2 + ", " + peso3 + ", " + peso4 + ", não é?");
    Console.ReadKey();

    Console.WriteLine("Insira o valor da primeira nota");
  int nota1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Insira o valor da segunda nota");
 int nota2 = int.Parse(Console.ReadLine());

 Console.WriteLine("Insira o valor da terceira nota");
 int nota3 = int.Parse(Console.ReadLine());

 Console.WriteLine("Insira o valor da quarta nota");
 int nota4 = int.Parse(Console.ReadLine());
 Console.WriteLine(nota4);

 float média = ((nota1* peso1) + (nota2 * peso2) + (nota3 * peso3) + (nota4 * peso4)) /(peso1+peso2+peso3+peso4);
 Console.WriteLine("a sua média é " + média);
 Console.ReadKey();
 Console.WriteLine("considerando sua média, o aluno está:");
 if (média >=60){
    Console.WriteLine("aprovado!!!");}
  else if (média <20){
    Console.WriteLine("reprovado...");}
  else{
    Console.WriteLine("Em recuperação!");
    Console.WriteLine("Digite a nota da recuperação");
    int Nota5 = (int.Parse(Console.ReadLine()));
    Console.WriteLine("Logo, a média final do aluno é...");
    Console.ReadKey();
    float NewMedia = (média+Nota5)/2; 
    Console.WriteLine("Sua nota final é...");
    Console.WriteLine(NewMedia);
    Console.ReadKey();
    Console.WriteLine("logo, o aluno está...");
    Console.ReadKey();
    if (NewMedia>=60){Console.WriteLine("Aprovado!");}
    else{Console.WriteLine("reprovado!");
    }
  }
 }
