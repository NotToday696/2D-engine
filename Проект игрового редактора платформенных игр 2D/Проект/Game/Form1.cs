using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    { 
        Map map;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const float VEL = 100f;
            Graphical_object back = new Graphical_object("33.png");
            Graphical_object hero = new Graphical_object("37.png");
            hero.setX(100);
            hero.setY(200);
            map = new Map();
            map.addObject(back);
            map.addObject(hero);
            
        }

        private void KeyDown()
        {
            /*if ()
            {
            }
            else if ()
            {

            }
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            map.step();
            Update();
        }

        private void fon_Paint(object sender, PaintEventArgs e)
        {
            foreach (Game_object o in map.getobjets())
            {
                Graphical_object g1 = (Graphical_object) o;
                e.Graphics.DrawImage(g1.GetImage(), g1.getx(), g1.gety());
            }
        }
    }
}
