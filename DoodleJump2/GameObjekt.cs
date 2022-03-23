using System;
using Raylib_cs;

namespace DoodleJump2
{
    public abstract class GameObjekt
    {
        static protected Random generator = new Random();
        static public List<GameObjekt> gameObjekts = new List<GameObjekt>();
        public Rectangle rec = new Rectangle();
        public bool remove = false;

        public GameObjekt()
        {
            gameObjekts.Add(this);
        }

        public virtual void Update()
        {

        }
        public virtual void Draw()
        {

        }
        public virtual void Collided()
        {

        }
    }
}