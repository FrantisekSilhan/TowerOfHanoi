using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    internal class Game
    {
        public Stack<int>[] Towers = {
        new Stack<int>(),
        new Stack<int>(),
        new Stack<int>()
        };
        public Game(int discs) {
            for (int i = discs; i > 0; i--) {
                Towers[0].Push(i);
            }
        }

        public void Move(int from, int where) {
            if (from < 0 || from >= Towers.Length || where < 0 || where >= Towers.Length) {
                Console.WriteLine("Jsi kkt");
                return;
            }
            if (Towers[from].Count == 0) {
                Console.WriteLine("Jsi kkt");
                return;
            }

            Towers[where].Push(Towers[from].Pop());

            Console.WriteLine($"{from} {where}");
        }

        public override string ToString()
        {
            string state = "";
            int biggest = 0;
            foreach (Stack<int> stack in Towers) if (stack.Count > biggest) biggest = stack.Count;
            for (int i = biggest-1; i >= 0; i--) {
                for (int j = 0; j < Towers.Length; j++) {
                    if (j == 0) state += "|";
                    if (i >= Towers[j].Count) state += " ";
                    else state += Towers[j].ElementAt(Towers[j].Count-1-i);
                    state += "|";
                }
                state += "\n";
            }
            return state;
        }
    }
}