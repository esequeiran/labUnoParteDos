using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoDosShape
{
    public partial class UserControl1: UserControl
    {

        public event System.Windows.Forms.PaintEventHandler Paint;

        public UserControl1()
        {
            InitializeComponent();
         
            
            
        }

        private void DrawEllipse()
        {
            Pen myPen = new Pen(Color.LightBlue);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(myPen, new Rectangle((this.Width/2)-100, (this.Height/2)-150, 200, 300));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void DrawRectangle()
        {
            Pen myPen = new Pen(Color.Yellow);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle((this.Width / 2) - 100, (this.Height / 2) - 150, 200, 300));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
            shape.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(shape);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawEllipse();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            DrawRectangle();
        }
    }
}
