using System;
using System.Windows.Forms;
using System.Threading;
using Electrical_Circuit_Simulator.Forms;
using Electrical_Circuit_Simulator.Forms.Physics;
using System.Drawing;
namespace Electrical_Circuit_Simulator
{
    public partial class CCS : Form
    {
        private Bitmap Bmp;
        private Point BmpLoc;
        string ComponentNameLabel;
        Circuit circut;

        //true if point1 must be updated
        //false if point2 must be updated
        //update point1 or point2
        public CCS(string InputName)
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            Paint += new PaintEventHandler(panel1_Paint);
            //Circuit Symbols
            //this.bulbToolStripMenuItem.Click += new System.EventHandler(this.bulbToolStripMenuItem_Click);
            ComponentNameLabel = InputName;
            circut = new Circuit();
        }


        private void Form1_SizeChanged(object sender, EventArgs e)  
        {

            Invalidate();
        }
        //Buttons, for closing and back...
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread theThread = new Thread(StartGame);
            theThread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            var SIUnits = new SI();
            SIUnits.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var CircuitSymbols = new Symbols();
            CircuitSymbols.Show();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            circut.caclucate();
        }
        public void StartGame()
        {
            Game1 game = new Game1();
            game.Run();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Back = new PS();
            Back.Show();
            Visible = false;

        }
        PictureBox Component = null;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Checker = false;
            if (Bmp != null)

            {
                Label ComponentName = new Label();
                ComponentName.Location = new Point(23, 50);
                ComponentName.Text = ComponentNameLabel;
                PictureBox Component = new PictureBox();
                Component.SizeMode = PictureBoxSizeMode.AutoSize;
                Component.Image = Image.FromFile(FileLocation);
                Component.Location = new Point(CX, CY);
                this.panel1.Controls.Add(Component);
                Component.Controls.Add(ComponentName);
                Component.BackColor = Color.Transparent;
                Bmp = null;
                this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);

            }
        }
        Graphics g;
        bool canPaint = false;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            canPaint = true;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            canPaint = false;
            prevX = null;
            prevY = null;
        }
        private void toolStripButton10_Click(object sender, EventArgs e)
        {

        }
        private void CCS_Load(object sender, EventArgs e)
        {
        }

        int? prevX = null;
        string FileLocation = "";
        private void resistorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputResistors = new Input_Resistors(circut);
            InputResistors.Show();
            FileLocation = "C:\\Users\\Ali Najafi\\Desktop\\Electrical Circuit Simulator\\Electrical Circuit Simulator\\Electrical_Circuit_Simulator\\Resources\\ResistorCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }

        private void variableResistorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputResistors = new Input_Resistors(circut);
            InputResistors.Show();
            FileLocation = "C:\\Users\\Ali Najafi\\Desktop\\Electrical Circuit Simulator\\Electrical Circuit Simulator\\Electrical_Circuit_Simulator\\Resources\\VRCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }

        private void cellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputPower = new Input_Power_Supply();
            InputPower.Show();
            FileLocation = "C:\\Users\\Ali Najafi\\Desktop\\Electrical Circuit Simulator\\Electrical Circuit Simulator\\Electrical_Circuit_Simulator\\Resources\\CellCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }

        private void batteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputPower = new Input_Power_Supply();
            InputPower.Show();
            FileLocation = "C:\\Users\\Ali Najafi\\Desktop\\Electrical Circuit Simulator\\Electrical Circuit Simulator\\Electrical_Circuit_Simulator\\Resources\\BatteryCS.png";
            Bmp = new Bitmap(FileLocation);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }


        int? prevY = null;
        int CprevX = 0;
        int CprevY = 0;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Pen!!!!!
            if (canPaint)
            {
                Pen pen = new Pen(Color.Black, 3);
                g.DrawLine(pen, new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y));
                prevX = e.X;
                prevY = e.Y;
            }
            //Components
                CprevX = e.X;
                CprevY = e.Y;

        }
        Point POINT = new Point(400, 40);

        private void bulbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var InputResistors = new Input_Resistors(circut);
            InputResistors.Show();
            BULB bulb = new BULB();
            FileLocation = "C:\\Users\\Ali Najafi\\Desktop\\Electrical Circuit Simulator\\Electrical Circuit Simulator\\Electrical_Circuit_Simulator\\Resources\\BULBCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, 80);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
            panel1.Controls.Clear();
        }

        private void voltmeterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileLocation = "C:\\Users\\Ali Najafi\\Desktop\\Electrical Circuit Simulator\\Electrical Circuit Simulator\\Electrical_Circuit_Simulator\\Resources\\VoltMeterCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }

        private void ammeterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileLocation = "C:\\Users\\Ali Najafi\\Desktop\\Electrical Circuit Simulator\\Electrical Circuit Simulator\\Electrical_Circuit_Simulator\\Resources\\AmmeterCS.png";
            Bmp = new Bitmap(FileLocation);
            BmpLoc = new Point(POINT.X, POINT.Y);
            Rectangle R = new Rectangle(BmpLoc, Bmp.Size);
            this.Invalidate(R);
        }
        int CX;
        int CY;
        bool Checker = false;
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Checker = true;
                CX = e.X;
                CY = e.Y;
        }
    }
    }
