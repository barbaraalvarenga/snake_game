using System;

class Tabuleiro
{

    public string[,] Mat = new string[20, 30];

    public int AlimentoY;

    public int AlimentoX;


    public Tabuleiro()

    {

        Inicializar();

    }


    public void Inicializar()

    {

        for (int i = 0; i < 20; i++)

            for (int j = 0; j < 30; j++)

                Mat[i, j] = " ";

    }


    public void GerarAlimento(Cobra cobra)

    {

        Random r = new Random();

        int y, x;

        bool valido;


        do
        {

            y = r.Next(1, 19);

            x = r.Next(1, 29);

            valido = !cobra.Ocupa(y, x);

        }

        while (!valido);


        AlimentoY = y;

        AlimentoX = x;

    }


    public void Desenhar(Cobra cobra, Jogador jogador)

    {

        Console.Clear();

        Console.WriteLine("Pontos: " + jogador.Pontuacao);


        for (int i = 0; i < 20; i++)

        {

            for (int j = 0; j < 30; j++)

            {

                if (i == 0 || i == 19 || j == 0 || j == 29)

                    Console.Write("■");

                else if (i == AlimentoY && j == AlimentoX)

                    Console.Write("●");

                else if (cobra.Ocupa(i, j))

                    Console.Write("■");

                else Console.Write(" ");

            }

            Console.WriteLine();

        }

    }
