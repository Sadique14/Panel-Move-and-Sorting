using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;

namespace FormSnapping
{
    public partial class PanelSwap : Form
    {
        
        public PanelSwap()
        {
            InitializeComponent();
        }
        int temp, x1, x2, x3, x4, y1, y2, y3, y4;
        BOLayer b = new BOLayer();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 1;
            x1 = panel0.Location.X;
            y1 = panel0.Location.Y;

        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            b.panelMovement(panel0, panel1, panel2, panel3, x1, y1);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 2;
            x2 = panel1.Location.X;
            y2 = panel1.Location.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            b.panelMovement(panel1, panel0, panel2, panel3, x2, y2);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 3;
            x3 = panel2.Location.X;
            y3 = panel2.Location.Y;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            b.panelMovement(panel2, panel0, panel1, panel3, x3, y3);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 4;
            x4 = panel3.Location.X;
            y4 = panel3.Location.Y;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            b.panelMovement(panel3, panel0, panel1, panel2, x4, y4);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(temp==1)
            {
                panel0.Location = new Point(Cursor.Position.X-200, Cursor.Position.Y-200);
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 2)
            {
                panel1.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 3)
            {
                panel2.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 4)
            {
                panel3.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
