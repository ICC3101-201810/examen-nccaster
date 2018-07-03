using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(move_it_move);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void move_it_move(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyData)
            {
                case Keys.D:
                    button1.Location = new Point(button1.Left + 4, button1.Top);
                    break;
                case Keys.A:
                    button1.Location = new Point(button1.Left - 4, button1.Top);
                    break;
                case Keys.W:
                    button1.Location = new Point(button1.Left, button1.Top - 4);
                    break;
                case Keys.S:
                    button1.Location = new Point(button1.Left, button1.Top + 4);
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer tm = new Timer();

            if ((button2.Location == button1.Location) || (button3.Location == button1.Location))
            {
                Application.Exit();
            }
            button2.Location = new Point(button2.Location.X + 4 , button2.Location.Y + 4);
            button3.Location = new Point(button3.Location.X - 4, button3.Location.Y - 4);
            
        }

        private void aNumber_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button4.Visible = true;
            Random rn = new Random();
            int x = rn.Next(1, 501);
            int y = rn.Next(1, 501);
            button4.Location = new Point(x, y);
            button4.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            atextbox.Visible = false;
            //if (button4.Visible == true) { button4.Visible = false; }
        }

        private void atextbox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
