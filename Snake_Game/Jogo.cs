using System;

class Jogo
{

    Cobra cobra;

    Tabuleiro tabuleiro;

    Jogador jogador;

    bool jogando = true;


    public void Iniciar()

    {

        Console.CursorVisible = false;

        Console.Write("Nome do jogador: ");

        string nome = Console.ReadLine();


        jogador = new Jogador(nome);

        cobra = new Cobra();

        tabuleiro = new Tabuleiro();

        tabuleiro.GerarAlimento(cobra);


        while (jogando)

        {

            Entrada();

            Atualizar();

            tabuleiro.Desenhar(cobra, jogador);

            Thread.Sleep(150);

        }


        jogador.RegistrarPontuacao();

        Console.Clear();

        Console.WriteLine("Fim de jogo!");

        Console.WriteLine("Pontuação: " + jogador.Pontuacao);

        Console.ReadKey();

    }


    private void Entrada()

    {

        if (!Console.KeyAvailable) return;


        var tecla = Console.ReadKey(true).Key;


        if (tecla == ConsoleKey.UpArrow) cobra.Direcao = "cima";

        if (tecla == ConsoleKey.DownArrow) cobra.Direcao = "baixo";

        if (tecla == ConsoleKey.LeftArrow) cobra.Direcao = "esquerda";

        if (tecla == ConsoleKey.RightArrow) cobra.Direcao = "direita";

    }


    private void Atualizar()

    {

        cobra.Mover();


        if (cobra.CabecaY() == 0 || cobra.CabecaY() == 19 || cobra.CabecaX() == 0 || cobra.CabecaX() == 29)

        {

            jogando = false;

            return;

        }


        if (cobra.BateuCorpo())

        {

            jogando = false;

            return;

        }


        if (cobra.CabecaY() == tabuleiro.AlimentoY && cobra.CabecaX() == tabuleiro.AlimentoX)

        {

            cobra.Crescer();

            jogador.AdicionarPontos();

            tabuleiro.GerarAlimento(cobra);

        }

    }
