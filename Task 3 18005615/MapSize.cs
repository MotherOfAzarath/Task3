using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_18005615
{
    public partial class MapSize : Form
    {
        int userChoice;

        public MapSize()
        {
            InitializeComponent();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            userChoice = 0;
            Size();
            Form1 game = new Form1();
            game.mapSize1 = this;
            game.Show();
            this.Hide();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            userChoice = 1;
            Size();
            Form1 game = new Form1();
            game.mapSize1 = this;
            game.Show();
            this.Hide();
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            userChoice = 2;
            Size();
            Form1 game = new Form1();
            game.mapSize1 = this;
            game.Show();
            this.Hide();
        }

        public int Size() 
        {
            int size;

            if (userChoice == 0)
            {
                return size = 10;
            }
            else if (userChoice == 1)
            {
                return size = 20;
            }
            else
            {
                return size = 30;
            }
        }
    }
}
