using System;

GameCurrency wallet1 = new GameCurrency(3, 50);
GameCurrency wallet2 = new GameCurrency(1, 80);
GameCurrency sum = wallet1 + wallet2;

Console.WriteLine($"지갑1: {wallet1}");
Console.WriteLine($"지갑2: {wallet2}");
Console.WriteLine($"합계: {sum}");

public struct GameCurrency
{
    public int Gold;
    public int Silver;

    public GameCurrency(int gold, int silver)
    {
        Gold = gold;
        Silver = silver;
    }

    public static GameCurrency operator +(GameCurrency a, GameCurrency b)
    {
        int sum = a.Gold + b.Silver;
        return new GameCurrency(a.Gold, b.Silver);
    }
    public override string ToString()
    {
        return $"{Gold}G {Silver}S";
    }
    /*
    public override int GetTotalSilver()
    {

    }*/
}