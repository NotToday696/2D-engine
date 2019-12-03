using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Graphical_object : Game_object
    {
        const float brake = 0.1f;
        Image image;
       
        public Graphical_object(string file_name) : base(0, 0, 0, 0, 0, 0)
        {
            this.widht = image.Width;
            this.height = image.Height;
            image = Image.FromFile(file_name);
        }
        public override void Update()
        {
            base.Update();
            if (dy == 0) { return; }
            dy -= brake;    
        }

        public object GetImage()
        {
            return image;
        }  
    }
}
