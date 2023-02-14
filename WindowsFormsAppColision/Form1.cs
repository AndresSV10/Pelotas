using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsAppColision
{
    public partial class Form1 : Form
    {
        int count;
        private Bitmap bitmap;
        static  Graphics graphics;
        ball b;
        public int boundY = 0, boundX = 0, boundX0, boundY0;
        Boolean left;
        Boolean right;
        Boolean up;
        Boolean down;
        public Form1()
        {
            InitializeComponent();

            count = 0;
            bitmap      = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics    = Graphics.FromImage(bitmap);

            pictureBox1.Image = bitmap;
            
            b = new ball();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            graphics.Clear(Color.Black);
            SolidBrush brush = new SolidBrush(b.color);
            graphics.FillEllipse(brush, b.x, b.y, 50, 50);
            b.update(pictureBox1.Width - 50, pictureBox1.Height - 50, 0, 0);
            pictureBox1.Invalidate();
            count++;
        }
    }
}
