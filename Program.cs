using TowerOfHanoi;

Game toh = new Game(3);
bool mnau = false;

Random rnd = new Random();
int moves = 0;

while (!mnau) {
    try
    {
        int a = rnd.Next(0, 3);
        int b = rnd.Next(0, 3);

        while (a == b)
        {
            b = rnd.Next(0, 3);
        }

        mnau = toh.Move(a, b);
        moves++;
        Console.WriteLine(toh.ToString());
    } catch {

    }
}

Console.WriteLine("Ez win!");
Console.WriteLine(moves);