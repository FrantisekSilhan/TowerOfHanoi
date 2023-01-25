using TowerOfHanoi;

int discs = 31;
Game toh = new Game(discs);
bool mnau = false;

if (discs % 2 == 0)
{
    while (!mnau)
    {
        try { mnau = toh.Move(0, 1); } catch { try { mnau = toh.Move(1, 0); } catch { } }
        Console.WriteLine(toh.ToString());
        try { mnau = toh.Move(0, 2); } catch { try { mnau = toh.Move(2, 0); } catch { } }
        Console.WriteLine(toh.ToString());
        try { mnau = toh.Move(1, 2); } catch { try { mnau = toh.Move(2, 1); } catch { } }
        Console.WriteLine(toh.ToString());
    }
}
else
{
    try { mnau = toh.Move(0, 2); } catch { try { mnau = toh.Move(2, 0); } catch { } }
    Console.WriteLine(toh.ToString());
    while (!mnau)
    {
        try { mnau = toh.Move(0, 1); } catch { try { mnau = toh.Move(1, 0); } catch { } }
        Console.WriteLine(toh.ToString());
        try { mnau = toh.Move(1, 2); } catch { try { mnau = toh.Move(2, 1); } catch { } }
        Console.WriteLine(toh.ToString());
        try { mnau = toh.Move(0, 2); } catch { try { mnau = toh.Move(2, 0); } catch { } }
        Console.WriteLine(toh.ToString());
    }
}

Console.WriteLine(toh.Moves);