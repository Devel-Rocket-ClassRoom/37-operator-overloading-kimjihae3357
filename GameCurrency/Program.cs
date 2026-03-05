using System;

GameCurrency wallet1 = new GameCurrency(3, 50);
GameCurrency wallet2 = new GameCurrency(1, 80);

public struct GameCurrency
{
    public int Gold;
    public int Silver;

    public GameCurrency(int gold, int silver)
    {
        Gold = gold;
        Silver = silver;
    }

    public override string ToString()
    {
        return $"{Gold}G";
    }

    public static GameCurrency operator +(GameCurrency a, GameCurrency b)
    {
        int sum = a.Gold + b.Gold;
    }
}