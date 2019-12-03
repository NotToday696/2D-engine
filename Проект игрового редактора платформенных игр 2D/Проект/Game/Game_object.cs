using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Game_object
    {
        protected  float x, y, dx, dy;
        protected int height, widht;
        protected bool isCollision;

        public Game_object(float x, float y, int width, int height, float dx = 0, float dy = 0, bool isCollision = false)
        {
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
            this.widht = width;
            this.height = height;
            this.isCollision = false; 

        }
        public virtual void Start()
        {
        }

        public virtual void Stop()
        {
        }
        public virtual void Update()
        {
            x += dx;
            y += dy;
        }
        public float getx() { return x; }
        public float gety() { return y; }
        public float getH() { return height; }
        public float getW() { return widht; }



        public virtual void onCollision(Game_object o)
        {
        }

        public bool checkCollision(float x, float y, float width, float height)
        {
            
            if (this.x + this.widht < x) { return false; }
            if(y + height < this.y) { return false; }
            if(x + width < this.x) { return false; }
            if(y> this.y + this.height) { return false; }

            return true;
        }

        public float setX(float x)
        {
            this.x = x;
            return this.x;
        }

        public float setY(float y)
        {
            this.y = y;
            return this.y;
        }
    }
}
