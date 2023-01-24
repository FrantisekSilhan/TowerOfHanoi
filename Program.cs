using TowerOfHanoi;

Game toh = new Game(3);

Console.WriteLine(toh.ToString());
toh.Move(0, 2);
Console.WriteLine(toh.ToString());
toh.Move(0, 1);
Console.WriteLine(toh.ToString());
toh.Move(2, 1);
Console.WriteLine(toh.ToString());
toh.Move(0, 2);
Console.WriteLine(toh.ToString());
toh.Move(1, 0);
Console.WriteLine(toh.ToString());
toh.Move(1, 2);
Console.WriteLine(toh.ToString());
toh.Move(0, 2);
Console.WriteLine(toh.ToString());