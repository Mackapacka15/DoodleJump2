using System;
using Raylib_cs;

namespace DoodleJump2
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 900, "DoodleJump2");
            Raylib.SetTargetFPS(60);
            GameLogic gl = new GameLogic();

            while (!Raylib.WindowShouldClose())
            {
                gl.Update();
            }

        }
    }
}
