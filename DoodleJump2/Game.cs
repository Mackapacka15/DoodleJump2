using System;
using Raylib_cs;
using System.Numerics;
namespace DoodleJump2
{
    public class Game
    {
        Random generator = new Random();
        float timer = 0;
        Player p;

        public Game()
        {
            p = new Player();
            Plate innit = new Plate();
            innit.rec.x = 0;
            innit.rec.y = 850;
            innit.rec.width = 800;
            innit.rec.height = 50;
            for (int i = 0; i < 5; i++)
            {
                new Plate().rec.y = 150 * i;
            }
        }

        public string Update()
        {
            timer += Raylib.GetFrameTime();
            if (p.IsDead())
            {
                return "Menu";
            }
            foreach (var item in GameObjekt.gameObjekts)
            {
                item.Update();
            }

            //GameObjekt.gameObjekts.RemoveAll(t => t.rec.y > 1000 && t is not Player);
            GameObjekt.gameObjekts.RemoveAll(t => t.remove);
            // Console.WriteLine(GameObjekt.gameObjekts.Count);

            if (timer >= 2)
            {
                timer = 0;
                if (generator.Next(0, 5) == 3)
                {

                    new FragilePlate();
                }
                else
                {
                    new Plate();
                }
            }
            return "Game";
        }
        public void DrawGame()
        {
            foreach (var item in GameObjekt.gameObjekts)
            {
                item.Draw();
            }
        }

    }
}