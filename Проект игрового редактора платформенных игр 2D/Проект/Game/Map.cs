using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Map
    {
        List<Game_object> objects = new List<Game_object>();

        public void addObject(Game_object o)
        {
            //добавить в список
            objects.Add(o);
            //вызвать Start
            o.Start();
            
        }
        void delObject(Game_object o)
        {
            objects.Remove(o);
            o.Stop();
        }
        public void step()
        {
            //Здесь у каждого элемента должеен вызываться метод "Update".
            //o.Update();
            // Два цикла for по объектам, чтобы проверить столконовение. 
            // Нужны ссылки на объекты списка. 
            for(int i = 0; i<objects.Count; i++)
            {
                objects[i].Update();
                for (int j = 1; j < objects.Count; j++)
                {
                    Game_object o = objects[j];
                    if (i != j && objects[i].checkCollision(o.getx(), o.gety(), o.getW(), o.getH()))
                    {
                        objects[i].onCollision(o);
                        o.onCollision(objects[i]);
                    }
                }
            }           
        }
    }
}
