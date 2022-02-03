using System;
using Raylib_cs;

namespace DoodleJump2
{
    public class GameLogic
    {
        private string state = "Menu";
        private Color background = new Color(236, 250, 235, 255);
        Menu m = new Menu();
        Game g;
        public void Update()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(background);

            if (state == "Menu")
            {
                state = m.ShowMenu();
                if (state == "Game")
                {
                    GameObjekt.gameObjekts.Clear();
                    g = new Game();
                }
            }
            else if (state == "Game")
            {
                state = g.Update();
                g.DrawGame();
            }
            Raylib.EndDrawing();
        }
    }
}