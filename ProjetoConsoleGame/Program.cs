string texto = "________                __      __      __                 .___      \r\n\\______ \\ _____ _______|  | __ /  \\    /  \\____   ____   __| _/______\r\n |    |  \\\\__  \\\\_  __ \\  |/ / \\   \\/\\/   /  _ \\ /  _ \\ / __ |/  ___/\r\n |    `   \\/ __ \\|  | \\/    <   \\        (  <_> |  <_> ) /_/ |\\___ \\ \r\n/_______  (____  /__|  |__|_ \\   \\__/\\  / \\____/ \\____/\\____ /____  >\r\n        \\/     \\/           \\/        \\/                    \\/    \\/ ";
string texto1 = "Digite 1 para começar.";
string texto2 = "Digite 2 para sair.";
string direcaoN = "norte";
string direcaoS = "sul";
string direcaoL = "leste";
string direcaoO = "oeste";
Console.WriteLine(texto);
Console.WriteLine(texto1);
Console.WriteLine(texto2);

int resposta = int.Parse(Console.ReadLine());
if (resposta == 1)
{
    texto = "VOCÊ ESTÁ NUMA FLORESTA. HÁ 3 DIREÇÕES: NORTE, LESTE E OESTE. DIREÇÃO?";
    Console.WriteLine(texto);
    string respostaJogo = Console.ReadLine();
    if (respostaJogo.ToLower().Equals(direcaoN))
    {
        Console.WriteLine("VOCÊ FOI AO NORTE E TROPEÇOU EM ESPINHOS. FIM DE JOGO.");
    }
    if (respostaJogo.ToLower().Equals(direcaoL))
    {
        texto = "VOCÊ FOI AO LESTE E CONTINUA NA FLORESTA. HÁ 3 DIREÇÕES: NORTE, LESTE E OESTE. DIREÇÃO?";
        Console.WriteLine(texto);
        respostaJogo = Console.ReadLine();
        if (respostaJogo.Equals("NORTE"))
        {

        }
    }
    if (respostaJogo.ToLower().Equals(direcaoO))
    {
        Console.WriteLine("VOCÊ FOI AO OESTE E SE DEPAROU COM UMA MATILHA DE LOBOS. ELES AVANÇARAM EM VOCÊ E TE DEVORARAM. FIM DE JOGO.");
    }
    
}
else
{
    Console.WriteLine("FIM DE JOGO");
}
