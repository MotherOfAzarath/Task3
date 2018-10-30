using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Task_3_18005615
{
    public partial class Form1 : Form
    {
        Map map;
        public MapSize mapSize1;
        int Turn = 0;
        Random r = new Random();

        int SIZE = 45;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Map(mapSize1.Size(), mapSize1.Size(), 30, 10);
        }

        private void DisplayMap() 
        {

            groupDisplay.Controls.Clear();
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(MeeleeUnit))
                {
                    int start_x = 20;
                    int start_Y = 20;
                    start_x = groupDisplay.Location.X;
                    start_Y = groupDisplay.Location.Y;
                    MeeleeUnit m = (MeeleeUnit)u;
                    Button But = new Button();

                    But.Size = new Size(SIZE, SIZE);
                    But.Location = new Point(start_x + (m.PosX * SIZE), start_Y + (m.PosY * SIZE));
                    But.Text = m.symbol;
                    if (m.faction == 1)
                    {
                        But.ForeColor = Color.Red;
                    }
                    else if (m.faction == 0)
                    {
                        But.ForeColor = Color.Blue;
                    }
                    else
                    {
                        But.ForeColor = Color.Gray;
                    }
                    if (m.isDead())
                    {
                        m.symbol = "X";
                        But.Text = "X";
                    }
                    groupDisplay.Controls.Add(But);
                    But.Click += new EventHandler(Button_Click);
                }

            }
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(RangedUnit))
                {
                    int start_x = 20;
                    int start_Y = 20;
                    start_x = groupDisplay.Location.X;
                    start_Y = groupDisplay.Location.Y;
                    RangedUnit m = (RangedUnit)u;
                    Button But = new Button();

                    But.Size = new Size(SIZE, SIZE);
                    But.Location = new Point(start_x + (m.PosX * SIZE), start_Y + (m.PosY * SIZE));
                    But.Text = m.symbol;

                    if (m.faction == 1)
                    {
                        But.ForeColor = Color.Red;
                    }
                    else if (m.faction == 0)
                    {
                        But.ForeColor = Color.Blue;
                    }
                    else
                    {
                        But.ForeColor = Color.Gray;
                    }
                    if (m.isDead())
                    {
                        m.symbol = "X";
                        But.Text = "X";
                    }
                    groupDisplay.Controls.Add(But);
                    But.Click += new EventHandler(Button_Click);
                }

            }

            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(WarlockUnit))
                {
                    int start_x = 20;
                    int start_Y = 20;
                    start_x = groupDisplay.Location.X;
                    start_Y = groupDisplay.Location.Y;
                    WarlockUnit w = (WarlockUnit)u;
                    Button But = new Button();

                    But.Size = new Size(SIZE, SIZE);
                    But.Location = new Point(start_x + (w.PosX * SIZE), start_Y + (w.PosY * SIZE));
                    But.Text = w.symbol;
                    if (w.faction == 1)
                    {
                        But.ForeColor = Color.Red;
                    }
                    else
                    {
                        But.ForeColor = Color.Blue;
                    }
                    if (w.isDead())
                    {
                        w.symbol = "X";
                        But.Text = "X";
                    }
                    groupDisplay.Controls.Add(But);
                    But.Click += new EventHandler(Button_Click);
                }

            }

            foreach (Building b in map.Buildings)
            {
                if (b.GetType() == typeof(FactoryBuilding))
                {
                    int start_x = 20;
                    int start_Y = 20;
                    start_x = groupDisplay.Location.X;
                    start_Y = groupDisplay.Location.Y;
                    FactoryBuilding m = (FactoryBuilding)b;
                    Button But = new Button();

                    But.Size = new Size(SIZE, SIZE);
                    But.Location = new Point(start_x + (m.PosX * SIZE), start_Y + (m.PosY * SIZE));
                    But.Text = m.symbol;

                    if (m.faction == 1)
                    {
                        But.ForeColor = Color.Red;
                    }
                    else
                    {
                        But.ForeColor = Color.Blue;
                    }
                    if (m.isDead())
                    {
                        m.symbol = "X";
                        But.Text = "X";
                    }
                    groupDisplay.Controls.Add(But);
                    But.Click += new EventHandler(Button_Click);
                }
            }

            foreach (Building b in map.Buildings)
            {
                if (b.GetType() == typeof(ResourceBuilding))
                {
                    int start_x = 20;
                    int start_Y = 20;
                    start_x = groupDisplay.Location.X;
                    start_Y = groupDisplay.Location.Y;
                    ResourceBuilding m = (ResourceBuilding)b;
                    Button But = new Button();

                    But.Size = new Size(SIZE, SIZE);
                    But.Location = new Point(start_x + (m.PosX * SIZE), start_Y + (m.PosY * SIZE));
                    But.Text = m.symbol;

                    if (m.faction == 1)
                    {
                        But.ForeColor = Color.Red;
                    }
                    else
                    {
                        But.ForeColor = Color.Blue;
                    }
                    if (m.isDead())
                    {
                        m.symbol = "X";
                        But.Text = "X";
                    }
                    groupDisplay.Controls.Add(But);
                    But.Click += new EventHandler(Button_Click);
                }
            }
        }

        private void UpdateMap() 
        {
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(MeeleeUnit))
                {
                    MeeleeUnit m = (MeeleeUnit)u;
                    if (m.health > 1)
                    {
                        if (m.health < 25)
                        {
                            switch (r.Next(0, 4))
                            {
                                case 0: ((MeeleeUnit)u).NewPos(Direction.North); break;
                                case 1: ((MeeleeUnit)u).NewPos(Direction.East); break;
                                case 2: ((MeeleeUnit)u).NewPos(Direction.South); break;
                                case 3: ((MeeleeUnit)u).NewPos(Direction.West); break;
                            }
                        }
                        else if (m.health < 10) 
                        {
                            int teamChange = r.Next(0, 2);
                            if (teamChange == 0)
                            {
                                if (m.faction == 1)
                                {
                                    m.faction = 0;
                                    m.health = m.health + 5;
                                }
                                else
                                {
                                    m.faction = 1;
                                    m.health = m.health + 5;
                                }
                            }
                        }
                        else
                        {
                            bool inCombat = false;
                            foreach (Unit e in map.Units)
                            {
                                if (u.withinRange(e))
                                {
                                    u.combat(e);
                                    inCombat = true;
                                }
                            }
                            if (!inCombat)
                            {
                                Unit c = u.distance(map.Units);
                                m.NewPos(m.Directionto(c));
                            }
                        }
                    }
                    else
                    {
                        m.symbol = "X";
                    }
                }


            }
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(RangedUnit))
                {
                    RangedUnit m = (RangedUnit)u;
                    if (m.health > 1)
                    {
                        if (m.health < 25)
                        {
                            switch (r.Next(0, 4))
                            {
                                case 0: ((RangedUnit)u).NewPos(Direction.North); break;
                                case 1: ((RangedUnit)u).NewPos(Direction.East); break;
                                case 2: ((RangedUnit)u).NewPos(Direction.South); break;
                                case 3: ((RangedUnit)u).NewPos(Direction.West); break;
                            }
                        }
                        else if (m.health < 10)  
                        {
                            int teamChange = r.Next(0, 2);
                            if (teamChange == 0)
                            {
                                if (m.faction == 1)
                                {
                                    m.faction = 0;
                                    m.health = m.health + 5;
                                }
                                else
                                {
                                    m.faction = 1;
                                    m.health = m.health + 5;
                                }
                            }
                        }
                        else
                        {
                            bool inCombat = false;
                            foreach (Unit e in map.Units)
                            {
                                if (u.withinRange(e))
                                {
                                    u.combat(e);
                                    inCombat = true;
                                }
                            }
                            if (!inCombat)
                            {
                                Unit c = u.distance(map.Units);
                                m.NewPos(m.Directionto(c));
                            }
                        }
                    }
                    else
                    {
                        m.symbol = "X";
                    }
                }
            }

            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(WarlockUnit))
                {
                    WarlockUnit w = (WarlockUnit)u;
                    if (w.health > 1)
                    {
                        if (w.health < 25)
                        {
                            switch (r.Next(0, 4))
                            {
                                case 0: ((WarlockUnit)u).NewPos(Direction.North); break;
                                case 1: ((WarlockUnit)u).NewPos(Direction.East); break;
                                case 2: ((WarlockUnit)u).NewPos(Direction.South); break;
                                case 3: ((WarlockUnit)u).NewPos(Direction.West); break;
                            }
                        }

                        else
                        {
                            bool inCombat = false;
                            foreach (Unit e in map.Units)
                            {
                                if (u.withinRange(e))
                                {
                                    u.combat(e);
                                    inCombat = true;
                                }
                            }
                            if (!inCombat)
                            {
                                Unit c = u.distance(map.Units);
                                w.NewPos(w.Directionto(c));
                            }
                        }
                    }
                    else
                    {
                        w.symbol = "X";
                    }
                }
            }

            foreach (Building b in map.Buildings)
            {
                if (b.GetType() == typeof(ResourceBuilding))
                {
                    ResourceBuilding rb = (ResourceBuilding)b;
                    rb.ResourceGenerate();
                }
            }

            foreach (Building b in map.Buildings)
            {
                if (b.GetType() == typeof(FactoryBuilding))
                {
                    FactoryBuilding fb = (FactoryBuilding)b;
                }
            }

            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(MeeleeUnit))
                {
                    MeeleeUnit mu = (MeeleeUnit)u;
                    if (mu.symbol == "X")
                    {
                        int faction = mu.faction;
                        int rand = r.Next(0, 5);
                        FactoryBuilding fb = (FactoryBuilding)map.Buildings[rand];
                        fb.Spawner(20, 20, faction);
                    }
                }
            }

            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(RangedUnit))
                {
                    RangedUnit mu = (RangedUnit)u;
                    if (mu.symbol == "X")
                    {
                        int faction = mu.faction;
                        int rand = r.Next(0, 5);
                        FactoryBuilding fb = (FactoryBuilding)map.Buildings[rand];
                        fb.Spawner(20, 20, faction);
                    }
                }
            }
        }

        public void Button_Click(object sender, EventArgs args) 
        {
            int x = (((Button)sender).Location.X - groupDisplay.Location.X) / SIZE;
            int Y = (((Button)sender).Location.Y - groupDisplay.Location.Y) / SIZE;

            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(RangedUnit))
                {
                    RangedUnit r = (RangedUnit)u;

                    if (r.PosX == x && r.PosY == Y)
                    {
                        rtbxOutput2.Text = "" + r.toString();
                    }
                }

                else if (u.GetType() == typeof(MeeleeUnit))
                {
                    MeeleeUnit m = (MeeleeUnit)u;

                    if (m.PosX == x && m.PosY == Y)
                    {
                        rtbxOutput2.Text = "" + m.toString();
                    }
                }

                else if (u.GetType() == typeof(WarlockUnit))
                {
                    WarlockUnit m = (WarlockUnit)u;

                    if (m.PosX == x && m.PosY == Y)
                    {
                        rtbxOutput2.Text = "" + m.toString();
                    }
                }
            }

            foreach (Building b in map.Buildings)
            {
                if (b.GetType() == typeof(FactoryBuilding))
                {
                    FactoryBuilding fb = (FactoryBuilding)b;

                    if (fb.PosX == x && fb.PosY == Y)
                    {
                        rtbxOutput2.Text = "" + fb.toString();
                    }
                }

                else if (b.GetType() == typeof(ResourceBuilding))
                {
                    ResourceBuilding rb = (ResourceBuilding)b;

                    if (rb.PosX == x && rb.PosY == Y)
                    {
                        rtbxOutput2.Text = "" + rb.toString();
                    }
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnUnpause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream("GameSave.bat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, map);
                    MessageBox.Show("Game Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream("GameSave.bat", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fsin)
                {
                    map = (Map)bf.Deserialize(fsin);
                    MessageBox.Show("Game Successfully Loaded");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            UpdateMap();
            DisplayMap();
        }
    }
}
