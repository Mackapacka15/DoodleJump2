using System;
using Raylib_cs;
using System.Numerics;

namespace DoodleJump2
{
    public class Menu
    {
        private Vector2 mousepos = Raylib.GetMousePosition();
        private Rectangle button1 = new Rectangle(200, 250, 400, 170);
        private Rectangle button2 = new Rectangle(200, 550, 400, 170);
        private Rectangle button3 = new Rectangle(200, 150, 400, 170);
        private Color background = new Color(236, 250, 235, 255);

        public string ShowMenu()
        {
            mousepos = Raylib.GetMousePosition();
            Raylib.DrawText("Welcome To Doodle Jump", 100, 150, 50, Color.BLUE);
            Raylib.DrawRectangleRec(button1, Color.DARKBLUE);
            Raylib.DrawRectangleRec(button2, Color.DARKBLUE);
            Raylib.DrawText("Play", 350, 300, 50, background);
            Raylib.DrawText("Highscore", 275, 600, 50, background);
            if (Raylib.CheckCollisionPointRec(mousepos, button1) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
            {
                return "Game";
            }
            if (Raylib.CheckCollisionPointRec(mousepos, button2) && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
            {
                return "Scores";
            }
            return "Menu";
        }
    }
}