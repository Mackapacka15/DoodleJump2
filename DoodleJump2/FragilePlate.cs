using System;
using Raylib_cs;

namespace DoodleJump2
{
    public class FragilePlate : Plate
    {
        public FragilePlate()
        {
            plateGreen = new Color(117, 45, 8, 255);
            Console.WriteLine($"x:{rec.x} y: {rec.y} w: {rec.width} h: {rec.height}");
        }

        public override void Update()
        {
            rec.y += 1;
            Console.WriteLine("Test");
        }
        public override void Draw()
        {
            Raylib.DrawRectangleRec(rec, plateGreen);
        }
        public override void Collided()
        {
            remove = true;
        }
    }
}