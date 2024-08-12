bool resposta()
{
iniciopergunta:
string resposta = Console.ReadLine();
if (resposta == "s"){return true;}
else if (resposta == "n"){return false;}
else {Console.WriteLine("não entendi, responda com s ou n");
goto iniciopergunta;}
}
Console.WriteLine("quer jogar um jogo? (s/n)");
if (resposta() == false){
goto finaljogo;//calma, ja arrumo
}
inicioJogo:
int menor = 1;
int maior =100;
int numTentativas = 10;
 bool jogoRodando = true;

Random rand = new Random();
int sorteio = rand.Next(menor,maior +1);
Console.WriteLine("pensei em um número entre " + menor + " e " + maior + " tente adivinhar");
while (jogoRodando){
    Console.Write("Tentativa " + numTentativas + ":");
    int digitado = int.Parse(Console.ReadLine());
    if (digitado < sorteio){
        Console.WriteLine("errado! o número digitado é muito pequeno");
        numTentativas --;}
    else if (digitado > sorteio){
        Console.WriteLine("Errado! O número digitado é grande demais");
        numTentativas --;
    }
    else { Console.WriteLine("Correto!!! você acertou");
    jogoRodando = false;}
    if (numTentativas <= 0){
        Console.WriteLine("suas tentativas acabaram. O número sorteado era " + sorteio + ". Boa sorte da próxima vez!");
        jogoRodando = false;
    }
    }
finaljogo:
Console.WriteLine("até a próxima!");