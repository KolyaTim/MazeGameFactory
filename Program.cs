using System;

namespace JIa6upuHT
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeFactory factory = new MazeFactory();
            MazeGame mazeGame = new MazeGame();
            mazeGame.CreateMaze(factory);
        }
    }
}
