using System;

class Cobra
{

    public int[,] Corpo = new int[2, 600];

    public int Tamanho = 1;

    public string Direcao = "direita";


    public Cobra()

    {

        Corpo[0, 0] = 10;

        Corpo[1, 0] = 15;

    }


    public int CabecaY() { return Corpo[0, 0]; }

    public int CabecaX() { return Corpo[1, 0]; }


    public void Mover()

    {

        for (int i = Tamanho; i > 0; i--)

        {

            Corpo[0, i] = Corpo[0, i - 1];

            Corpo[1, i] = Corpo[1, i - 1];

        }


        if (Direcao == "cima") Corpo[0, 0]--;

        if (Direcao == "baixo") Corpo[0, 0]++;

        if (Direcao == "esquerda") Corpo[1, 0]--;

        if (Direcao == "direita") Corpo[1, 0]++;

    }


    public void Crescer()

    {

        Corpo[0, Tamanho] = Corpo[0, Tamanho - 1];

        Corpo[1, Tamanho] = Corpo[1, Tamanho - 1];

        Tamanho++;

    }


    public bool BateuCorpo()

    {

        int y = CabecaY();

        int x = CabecaX();


        for (int i = 1; i < Tamanho; i++)

        {

            if (Corpo[0, i] == y && Corpo[1, i] == x)

                return true;

        }

        return false;

    }


    public bool Ocupa(int y, int x)

    {

        for (int i = 0; i < Tamanho; i++)

        {

            if (Corpo[0, i] == y && Corpo[1, i] == x)

                return true;

        }

        return false;

    }

}
