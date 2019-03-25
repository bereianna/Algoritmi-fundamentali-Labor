using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190304
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            Graphics grp;
            Bitmap bmp;
            bmp = new Bitmap(pB.Width,pB.Height);
            grp = Graphics.FromImage(bmp);
            pB.Image = bmp;
            Pen p = new Pen(Color.Red,5);
            grp.DrawLine(p,0,0,60,60);

            Pen p2 = new Pen(Color.Green, 2);
            grp.DrawEllipse(p2, 0,60,60,40);
            Pen p3 = new Pen(Color.Blue, 3);
            PointF[] pointF = new PointF[4];
            pointF[0].X = 0;
            pointF[0].Y = 180;
            pointF[1].X = 30;
            pointF[1].Y = 130;
            pointF[2].X = 80;
            pointF[2].Y = 200;
            pointF[3].X = 60;
            pointF[3].Y = 200;
            grp.DrawPolygon(p3,pointF);

           

            //float a = x1;
            //float b=

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics grp;
            Bitmap bmp;
            bmp = new Bitmap(pB.Width, pB.Height);
            grp = Graphics.FromImage(bmp);
            Pen p4 = new Pen(Color.Black, 5);
            grp.DrawLine(p4, float.Parse(ax.Text), float.Parse(ay.Text), float.Parse(dx.Text), float.Parse(dy.Text));
            Pen p5 = new Pen(Color.DarkKhaki, 5);
            grp.DrawLine(p5, float.Parse(bx.Text), float.Parse(by.Text), float.Parse(cx.Text), float.Parse(cy.Text));
            
            pB.Image = bmp;
        }

        private void ay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
