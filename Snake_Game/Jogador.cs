using System;

class Jogador
{

    public string Nome;

    private int pontuacao;


    public Jogador(string nome)

    {

        Nome = nome;

        pontuacao = 0;

    }


    public int Pontuacao

    {

        get { return pontuacao; }

        set { pontuacao = value; }

    }


    public void AdicionarPontos()

    {

        pontuacao += 10;

    }


    public void RegistrarPontuacao()

    {

        using (StreamWriter sw = new StreamWriter("scores.txt", true))

        {

            sw.WriteLine(Nome + ";" + pontuacao);

        }

    }

}
