using System;
using Raylib_cs;

namespace DoodleJump2
{
    public class Plate : GameObjekt
    {
        public Color plateGreen = new Color(0, 207, 21, 255);


        public Plate()
        {
            rec.width = 100;
            rec.height = 20;
            rec.x = generator.Next(100, 700);
            rec.y = generator.Next(-20, -10);
        }

        public override void Update()
        {
            rec.y += 1;
        }
        public override void Draw()
        {
            Raylib.DrawRectangleRec(rec, plateGreen);
        }
    }
}
