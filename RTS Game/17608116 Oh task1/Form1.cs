using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _17608116_Oh_task1
{
    public partial class RTSGame : Form
    {
        //bool team1 = false;
        Timer t = new Timer();
        int T = 0;
        public Map RTSmap = new Map();
        public RangedUnit Runit = new RangedUnit();
        public MeleeUnit Munit = new MeleeUnit();
        ResourceBuilding RBuilding = new ResourceBuilding();
        FactoryBuilding FBuilding;
        

        public RTSGame()
        {
            InitializeComponent();
        }

        private void RTSGame_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;          //1000 interval = 1sec in real life
            t.Tick += new EventHandler(this.t_Tick);
            createMap();
            FBuilding = new FactoryBuilding(this);
        }     //When the game load create randomized map
        public void updatemap()
        {
            Mapgrid.Controls.Clear();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button BTU = new Button();
                    if (RTSmap.arrMap[i, j] == "E")
                    {
                        BTU.Text = "o";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.button_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "FB1")
                    {
                        BTU.Text = "FB1";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonFB1_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "FB2")
                    {
                        BTU.Text = "FB2";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonFB2_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "RB1")
                    {
                        BTU.Text = "RB1";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonRB1_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "RB2")
                    {
                        BTU.Text = "RB2";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonRB2_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "M1")
                    {
                        BTU.Text = "M1";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonM1_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "M2")
                    {
                        BTU.Text = "M2";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonM2_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "R1")
                    {
                        BTU.Text = "R1";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonR1_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "R2")
                    {
                        BTU.Text = "R2";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonR2_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "A1")
                    {
                        BTU.Text = "A1";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonA1_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "A2")
                    {
                        BTU.Text = "A2";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonA2_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "T1")
                    {
                        BTU.Text = "T1";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonT1_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                    if (RTSmap.arrMap[i, j] == "T2")
                    {
                        BTU.Text = "T2";
                        BTU.Width = 40;
                        BTU.Height = 40;
                        BTU.Click += new EventHandler(this.buttonT2_Click);
                        Mapgrid.Controls.Add(BTU);
                    }
                }
            }
        }      //When i update map it spown new unit next to the factory buildings but it delete 1st array 
        public void createMap()
        {
            Mapgrid.Controls.Clear();
            RTSmap.createU();



            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Button BT = new Button();
                    if (RTSmap.arrMap[i, j] == "E")   //check if the spot on the array has same name
                    {
                        BT.Text = "o";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.button_Click);
                        Mapgrid.Controls.Add(BT);   //add button to the array
                    }
                    if (RTSmap.arrMap[i, j] == "FB1")
                    {
                        BT.Text = "FB1";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonFB1_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "FB2")
                    {
                        BT.Text = "FB2";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonFB2_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "RB1")
                    {
                        BT.Text = "RB1";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonRB1_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "RB2")
                    {
                        BT.Text = "RB2";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonRB2_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "M1")
                    {
                        BT.Text = "M1";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonM1_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "M2")
                    {
                        BT.Text = "M2";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonM2_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "R1")
                    {
                        BT.Text = "R1";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonR1_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "R2")
                    {
                        BT.Text = "R2";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonR2_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "A1")
                    {
                        BT.Text = "A1";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonA1_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "A2")
                    {
                        BT.Text = "A2";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonA2_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "T1")
                    {
                        BT.Text = "T1";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonT1_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                    if (RTSmap.arrMap[i, j] == "T2")
                    {
                        BT.Text = "T2";
                        BT.Width = 40;
                        BT.Height = 40;
                        BT.Click += new EventHandler(this.buttonT2_Click);
                        Mapgrid.Controls.Add(BT);
                    }
                }
            }
        }      //Create button on the grid
        public void loadfile()
        {
            string Filename = @"D:\Map array.txt";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Filename, FileMode.Open, FileAccess.Write);
            formatter.Serialize(stream, RTSmap.arrMap);
            stream.Close();
            createMap();
        }       //load serialized map array from D drive to the map grid
        public void savefile()
        {
            string Filename = @"D:\Map array.txt";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Filename, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, RTSmap.arrMap);
            stream.Close();
            //StreamWriter streamWriter = new StreamWriter(@"D:\Doc.txt");
            //string output = "";
            //for (int i = 0; i < RTSmap.arrMap.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j < RTSmap.arrMap.GetUpperBound(1); j++)
            //    {
            //        output += RTSmap.arrMap[i, j].ToString();
            //    }
            //    streamWriter.WriteLine(output);
            //    output = "";
            //}
            //streamWriter.Close();
        }       //serialize the map array and save in D drive

        
        private void t_Tick(object sender, EventArgs e)
        {
            timerL.Text = "";        //delet all the text on the timer every tick so it doesn't have multiple numbers

            T++;
            RBuilding.GenerateR();
            FBuilding.SpawnNewUnit();
            timerL.Text += T.ToString();        //T increase every tick and showing on the timer label
            ResourceL.Text = RBuilding.ResType + ": " + RBuilding.ResRemainingT1;     //showing the resource type and remaining on the label
            ResourceL2.Text = RBuilding.ResType + ": " + RBuilding.ResRemainingT2;
            Resource2L.Text = RBuilding.ResType2 + ": " + RBuilding.ResRemainingT1S;
            Resource2L2.Text = RBuilding.ResType2 + ": " + RBuilding.ResRemainingT2S;
            if (T % 6 == 0)
            {
                updatemap();                                               //use the function to update whole map
                RBuilding.ResRemainingT1 = RBuilding.ResRemainingT1 - 4;   //when the unit spawn the gold decrease by 3 and silver decrease by 15
                RBuilding.ResRemainingT2 = RBuilding.ResRemainingT2 - 4;
                RBuilding.ResRemainingT1S = RBuilding.ResRemainingT1S - 15;
                RBuilding.ResRemainingT2S = RBuilding.ResRemainingT2S - 15;
            }
        }    //tick event to update every unit, resource and timer
        private void button_Click(object sender, EventArgs e)
        {
            unitStats.Text = "empty";
        }    //empty button
        private void buttonFB1_Click(object sender, EventArgs e)
        {
            unitStats.Text = "Factory Building" + Environment.NewLine + "Team1";
        } //team1 Factory building button
        private void buttonFB2_Click(object sender, EventArgs e)
        {
            unitStats.Text = "Factory Building" + Environment.NewLine + "Team2";
        } //team2 Factory building button
        private void buttonRB1_Click(object sender, EventArgs e)
        {
            unitStats.Text = "Resource Building" + Environment.NewLine + "Team1";
        } //team1 Resource building button
        private void buttonRB2_Click(object sender, EventArgs e)
           
        {
            unitStats.Text = "Resource Building" + Environment.NewLine + "Team2";
        } //team2 Resource building button
        private void buttonM1_Click(object sender, EventArgs e)
        {
            unitStats.Text = "MeleeUnit" + Environment.NewLine + "Team1";
        } //team1 Melee unit button
        private void buttonM2_Click(object sender, EventArgs e)
        {
            unitStats.Text = "MeleeUnit" + Environment.NewLine + "Team2";
        } //team2 Melee unit button
        private void buttonR1_Click(object sender, EventArgs e)
        {
            unitStats.Text = "RangedUnit" + Environment.NewLine + "Team1";
        } //team1 Range unit button
        private void buttonR2_Click(object sender, EventArgs e)
        {
            unitStats.Text = "RangedUnit" + Environment.NewLine + "Team2";
        } //team2 Range unit button
        private void buttonA1_Click(object sender, EventArgs e)
        {
            unitStats.Text = "Assassin" + Environment.NewLine + "Team1";
        } //team1 Assassin button
        private void buttonT1_Click(object sender, EventArgs e)
        {
            unitStats.Text = "Assassin" + Environment.NewLine + "Team2";
        } //team2 Assassin button
        private void buttonT2_Click(object sender, EventArgs e)
        {
            unitStats.Text = "Turret" + Environment.NewLine + "Team1";
        } //team1 Turret button
        private void buttonA2_Click(object sender, EventArgs e)
        {
            unitStats.Text = "Turret" + Environment.NewLine + "Team2";
        } //team2 Turret button
        private void timer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            //createMap();
            

            t.Start();

        }   //when player press the start button tick event start

        private void Stop_Click(object sender, EventArgs e)
        {

            t.Stop();

        }    //when player press the stop button tick event stop

        private void Mapgrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            savefile();
        }   //when player press the save button map array file saved in D drive

        private void load_Click(object sender, EventArgs e)
        {
            loadfile();
        }   //when player press the load button map array file loaded from D drive

        private void unitStats_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            t.Stop();       //stop the tick and reset every value
            createMap();
            T = 0;
            timerL.Text = "";
            RBuilding.ResRemainingT1 = 0;
            RBuilding.ResRemainingT2 = 0;
            RBuilding.ResRemainingT1S = 0;
            RBuilding.ResRemainingT2S = 0;
            ResourceL.Text = RBuilding.ResType + ": " + RBuilding.ResRemainingT1;     
            ResourceL2.Text = RBuilding.ResType + ": " + RBuilding.ResRemainingT2;
            Resource2L.Text = RBuilding.ResType2 + ": " + RBuilding.ResRemainingT1S;
            Resource2L2.Text = RBuilding.ResType2 + ": " + RBuilding.ResRemainingT2S;
        }   //when player press the reset button new map replace the current map reset all the other values
    }

    public class Unit
    {
        protected string TypeUnit;
        private int xPostion;
        private int yPosition;
        private int health;
        private int speed;
        private int attack;
        private int attackRange;
        private int team;
        private string symbol;
        public string typeUnit  //get and set for the private variable
        {
            get { return TypeUnit; }
            set { TypeUnit = value; }
        }
        public int XPosition
        {
            get { return xPostion; }
            set { xPostion = value; }
        }
        public int YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }
        public int Team
        {
            get { return team; }
            set { team = value; }
        }
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public Unit()
        {

        }
        public virtual void NewPosition()  //virtual methods
        {

        }

        public virtual void Combet()
        {

        }

        public virtual void AttackRangeU()
        {

        }

        public virtual void Return()
        {

        }

        public virtual void Death()
        {

        }

        public virtual void Tostring()
        {

        }
    }

    public class MeleeUnit : Unit
    {
        int Runaway;
        double x, y, z;
        bool range = false;
        bool death = false;
        public override void NewPosition()
        {

        }

        public override void Combet() //the unit is not death and enemy is in range attack the enemy
        {

            Health = 20;
            Attack = 2;
            AttackRangeU();
            while (death == false)
            {
                NewPosition();
                if (range == true)
                {
                    Health = Health - Attack;
                }

            }
        }

        public override void AttackRangeU()
        {
            AttackRange = 1;

            z = Math.Sqrt(x * x + y * y); //calculate the range using pyrhagiras

            if (z == AttackRange)
            {
                range = true;
            }
        }

        public override void Return() //run away when the health is under 1/4
        {
            int Runaway = Health / 4;
            if (Health <= Runaway)
            {

            }
        }

        public override void Death() //when the health reach 0 the unit die
        {
            if (Health <= 0)
            {
                death = true;
            }
        }


        public override void Tostring()
        {
            TypeUnit = "melee soldier";
        }
        

    }
    public class Assassin : Unit
    {
        int Runaway;
        double x, y, z;
        bool range = false;
        bool death = false;
        public override void NewPosition()
        {

        }

        public override void Combet()
        {

            Health = 10;
            Attack = 6;
            AttackRangeU();
            while (death == false)
            {
                NewPosition();
                if (range == true)
                {
                    Health = Health - Attack;
                }

            }
        }

        public override void AttackRangeU()
        {
            AttackRange = 1;

            z = Math.Sqrt(x * x + y * y);

            if (z == AttackRange)
            {
                range = true;
            }
        }

        public override void Return()
        {
            int Runaway = Health / 4;
            if (Health <= Runaway)
            {

            }
        }

        public override void Death()
        {
            if (Health <= 0)
            {
                death = true;
            }
        }


        public override void Tostring()
        {
            TypeUnit = "Assassin";
        }


    }
    public class RangedUnit : Unit
    {

        
        int Runaway;
        double x, y, z;
        bool range = false;
        bool death = false;
        public override void NewPosition()
        {

        }

        public override void Combet()
        {

            Health = 10;
            Attack = 4;
            AttackRangeU();
            while (death == false)
            {
                NewPosition();
                if (range == true)
                {
                    Health = Health - Attack;
                }
            }


        }

        public override void AttackRangeU()
        {
            AttackRange = 4;

            z = Math.Sqrt(x * x + y * y);

            if (z == AttackRange)
            {
                range = true;
            }

        }

        public override void Return()
        {



            int Runaway = Health / 4;
            if (Health <= Runaway)
            {

            }

        }

        public override void Death()
        {
            if (Health <= 0)
            {
                death = true;
            }
        }


        public override void Tostring()
        {
            TypeUnit = "range soldier";
        }
    }

    public class Map
    {
        int m, n;
        public string[,] arrMap = new string[20, 20]; //map array

        public Map()
        {

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    arrMap[i, j] = "E"; // using for loops to assign the empty space as "E"
                }
            }
        }
        public void createU()
        {
            arrMap[0, 1] = "FB1";
            arrMap[19, 18] = "FB2";
            arrMap[0, 0] = "RB1";
            arrMap[19, 19] = "RB2";
            arrMap[2, 2] = "T1";
            arrMap[17, 17] = "T2";
            for (int i = 0; i < 11; i++)
            {
                Random Ran = new Random(Guid.NewGuid().GetHashCode()); //check if there are empty space on the array and place down the units
                m = Ran.Next(0, 20);
                n = Ran.Next(0, 20);
                if ( arrMap[m, n] != "RB1" && arrMap[m, n] != "RB2" && arrMap[m, n] != "FB1" && arrMap[m, n] != "FB2" && arrMap[m,n] != "T1" && arrMap[m, n] != "T2")
                {
                    arrMap[m, n] = "M1";
                }
            }
            for (int i = 0; i < 11; i++)
            {
                Random Ran = new Random(Guid.NewGuid().GetHashCode());
                m = Ran.Next(0, 20);
                n = Ran.Next(0, 20);
                if (arrMap[m, n] != "M1" && arrMap[m, n] != "RB1" && arrMap[m, n] != "RB2" && arrMap[m, n] != "FB1" && arrMap[m, n] != "FB2" && arrMap[m, n] != "T1" && arrMap[m, n] != "T2")
                {
                    arrMap[m, n] = "M2";
                }
            }
            for (int i = 0; i < 11; i++)
            {
                Random Ran = new Random(Guid.NewGuid().GetHashCode());
                m = Ran.Next(0, 20);
                n = Ran.Next(0, 20);
                if (arrMap[m, n] != "M1" && arrMap[m, n] != "M2" && arrMap[m, n] != "RB1" && arrMap[m, n] != "RB2" && arrMap[m, n] != "FB1" && arrMap[m, n] != "FB2" && arrMap[m, n] != "T1" && arrMap[m, n] != "T2")
                {
                    arrMap[m, n] = "R1";
                }
            }
            for (int i = 0; i < 11; i++)
            {
                Random Ran = new Random(Guid.NewGuid().GetHashCode());
                m = Ran.Next(0, 20);
                n = Ran.Next(0, 20);
                if (arrMap[m, n] != "M" && arrMap[m, n] != "M2" && arrMap[m, n] != "R1" && arrMap[m, n] != "RB1" && arrMap[m, n] != "RB2" && arrMap[m, n] != "FB1" && arrMap[m, n] != "FB2" && arrMap[m, n] != "T1" && arrMap[m, n] != "T2")
                {
                    arrMap[m, n] = "R2";
                }
            }
            for (int i = 0; i < 6; i++)
            {
                Random Ran = new Random(Guid.NewGuid().GetHashCode());
                m = Ran.Next(0, 20);
                n = Ran.Next(0, 20);
                if (arrMap[m, n] != "M" && arrMap[m, n] != "M2" && arrMap[m, n] != "R1" && arrMap[m, n] != "RB1" && arrMap[m, n] != "RB2" && arrMap[m, n] != "FB1" && arrMap[m, n] != "FB2" && arrMap[m, n] != "R2" && arrMap[m, n] != "T1" && arrMap[m, n] != "T2")
                {
                    arrMap[m, n] = "A1";
                }
            }
            for (int i = 0; i < 6; i++)
            {
                Random Ran = new Random(Guid.NewGuid().GetHashCode());
                m = Ran.Next(0, 20);
                n = Ran.Next(0, 20);
                if (arrMap[m, n] != "M" && arrMap[m, n] != "M2" && arrMap[m, n] != "R1" && arrMap[m, n] != "RB1" && arrMap[m, n] != "RB2" && arrMap[m, n] != "FB1" && arrMap[m, n] != "FB2" && arrMap[m, n] != "R2" && arrMap[m, n] != "A1" && arrMap[m, n] != "T1" && arrMap[m, n] != "T2")
                {
                    arrMap[m, n] = "A2";
                }
            }

        }
        

        public class GameEngine
        {


            public GameEngine()
            {
               
            }
            public void moveU()
            {

            }


        }
    }
    abstract class Building
    {
        protected int Xpositon;
        protected int Ypositon;
        protected int Health = 400;
        protected int Team;
        protected string Symbol;

        public Building()
        {

        }

        public abstract void Death();

        public abstract void toString();
    }
    class ResourceBuilding : Building
    {
        private string ResourceType = "Gold";
        private string ResourceType2 = "Silver";
        private int ResourceTick = 3;
        private int ResourceTick2 = 6;
        private int ResourceRemainingT1 = 0;
        private int ResourceRemainingT2 = 0;
        private int ResourceRemainingT1S = 0;
        private int ResourceRemainingT2S = 0;
        public bool death = false;

        public int ResTick
        {
            get { return ResourceTick; }
            set { ResourceTick = value; }
        }
        public int ResTick2
        {
            get { return ResourceTick2; }
            set { ResourceTick2 = value; }
        }
        public string ResType
        {
            get { return ResourceType; }
            set { ResourceType = value; }
        }
        public string ResType2
        {
            get { return ResourceType2; }
            set { ResourceType2 = value; }
        }

        public int ResRemainingT1
        {
            get { return ResourceRemainingT1; }
            set { ResourceRemainingT1 = value; }
        }
        public int ResRemainingT2
        {
            get { return ResourceRemainingT2; }
            set { ResourceRemainingT2 = value; }
        }
        public int ResRemainingT1S
        {
            get { return ResourceRemainingT1S; }
            set { ResourceRemainingT1S = value; }
        }
        public int ResRemainingT2S
        {
            get { return ResourceRemainingT2S; }
            set { ResourceRemainingT2S = value; }
        }
        public override void Death()
        {
            if(Health <= 0)
            {
                death = true;
            }
        }

        public override void toString()
        {
            
        }
        
        public void GenerateR()  //increase remaining resource by resource per tick
        {
            ResourceRemainingT1 += ResourceTick;
            ResourceRemainingT2 += ResourceTick;
            ResourceRemainingT1S += ResourceTick2;
            ResourceRemainingT2S += ResourceTick2;
        }

    }
    class FactoryBuilding : Building
    {
        private string UnitP1 = "M1";
        private string UnitP2 = "M2";
        private int GametickPT = 0;
        public bool team = true;
        //private int[,] SpawnP = new int[20,20];
        RTSGame rtsGame;

        public FactoryBuilding(RTSGame rtsGame)
        {
            this.rtsGame = rtsGame;
        }


        public void SpawnNewUnit()
        {
            GametickPT += 1;  //increase 1 every tick
            if (GametickPT % 6== 0) //when the GametickPT devide by 6 and small number equal to 0 it happen (so every 6 multiple number)
            {
                if(rtsGame.RTSmap.arrMap[0, 2]=="E") //check if there are unit next to the building
                {
                    rtsGame.RTSmap.arrMap[0, 2] = UnitP1; //change the empty array to meleeunit
                }
                if(rtsGame.RTSmap.arrMap[19, 17] == "E")
                {
                    rtsGame.RTSmap.arrMap[19, 17] = UnitP2;
                }
            }
        }
        public override void Death()
        {
            if(Health == 0)
            {
                //the building replace with empty array
            }
        }

        public override void toString()
        {
            if (team == true)
            {
                //unitStats.text = "Team1 MeleeUnit Factory" + Environment.NewLine + "Every 6 sec meleeunit spawn";
            }
            else
            {
                //unitStats.text = "Team2 MeleeUnit Factory" + Environment.NewLine + "Every 6 sec meleeunit spawn";
            }
        }
    }
    class Turret : Building
    {
        private int Damage = 3;
        private int Health = 200;    
        public bool team = true;
        RTSGame rtsGame;

        public Turret(RTSGame rtsGame)
        {
            this.rtsGame = rtsGame;

            rtsGame.RTSmap.arrMap[0, 0] = "";
        }


       public void attackUnit()
        {

        }
        public override void Death()
        {
            if (Health == 0)
            {
                //the building replace with empty array
            }
        }

        public override void toString()
        {
            if (team == true)
            {
                //unitStats.text = "Team1 Turret" + Environment.NewLine + "protect the buildings";
            }
            else
            {
                //unitStats.text = "Team2 Turret" + Environment.NewLine + "protect the buildigs";
            }
        }
    }
}

