using TowerOfHanoi;

Game toh = new Game(6);

Console.WriteLine(toh.ToString());
toh.Move(0, 1);
Console.WriteLine(toh.ToString());