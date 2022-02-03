using System;
using Raylib_cs;

namespace DoodleJump2
{
    public class Player : GameObjekt
    {
        private bool jump = false;
        private int speed = 0;

        public Player()
        {
            rec = new Rectangle(200, 200, 40, 40);
        }
        public override void Update()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                rec.x -= 15;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                rec.x += 15;
            }
            Jump();
        }
        public override void Draw()
        {
            Raylib.DrawRectangleRec(rec, Color.RED);
        }
        public bool IsDead()
        {
            if (rec.y > 1000)
            {
                return true;
            }
            return false;
        }
        private void Jump()
        {
            foreach (var item in GameObjekt.gameObjekts)
            {
                if (item != this)
                {
                    if (Raylib.CheckCollisionRecs(rec, item.rec))
                    {
                        jump = true;
                    }
                }
            }
            if (jump)
            {
                speed = -20;
                jump = false;

            }
            else
            {
                speed += 1;
            }
            rec.y += speed;
        }
    }
}