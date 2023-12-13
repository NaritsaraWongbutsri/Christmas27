using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrismas27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();


            Pen myPen1 = new Pen(System.Drawing.Color.ForestGreen, 8);
            Pen myPen2 = new Pen(System.Drawing.Color.Brown, 5);
            Pen myPen3 = new Pen(System.Drawing.Color.Chartreuse, 5);
            Pen myPen4 = new Pen(System.Drawing.Color.Red, 5);
            Pen myPen5 = new Pen(System.Drawing.Color.Gold, 5);
            Pen myPen6 = new Pen(System.Drawing.Color.Cyan, 5);
            Pen myPen7 = new Pen(System.Drawing.Color.DeepPink, 5);
            Pen myPen8 = new Pen(System.Drawing.Color.DarkViolet, 5);

            Pen myPen9 = new Pen(System.Drawing.Color.Orange, 5);


            //ต้นคริสต์มาส
            myGraphic.DrawRectangle(myPen2, 390, 270, 50, 120);

            myGraphic.DrawEllipse(myPen9, 405, 25, 30, 30);

            myGraphic.DrawLine(myPen1, 420, 60, 520, 180);
            myGraphic.DrawLine(myPen1, 420, 60, 320, 180);
            myGraphic.DrawLine(myPen1, 420, 160, 320, 180);
            myGraphic.DrawLine(myPen1, 420, 160, 520, 180);

            myGraphic.DrawLine(myPen1, 420, 160, 520, 280);
            myGraphic.DrawLine(myPen1, 420, 160, 320, 280);
            myGraphic.DrawLine(myPen1, 420, 265, 320, 280);
            myGraphic.DrawLine(myPen1, 420, 265, 520, 280);

            //ตกแต่ง
            myGraphic.DrawRectangle(myPen8, 520, 185, 20, 20);
            myGraphic.DrawRectangle(myPen8, 300, 185, 20, 20);
            myGraphic.DrawRectangle(myPen7, 520, 285, 20, 20);
            myGraphic.DrawRectangle(myPen7, 300, 285, 20, 20);

            myGraphic.DrawEllipse(myPen3, 415, 83, 10, 10);
            myGraphic.DrawEllipse(myPen4, 405, 99, 10, 10);
            myGraphic.DrawEllipse(myPen5, 425, 100, 10, 10);
            myGraphic.DrawEllipse(myPen6, 390, 116, 10, 10);
            myGraphic.DrawEllipse(myPen7, 415, 116, 10, 10);
            myGraphic.DrawEllipse(myPen8, 440, 116, 10, 10);

            myGraphic.DrawEllipse(myPen3, 415, 185, 10, 10);
            myGraphic.DrawEllipse(myPen4, 405, 205, 10, 10);
            myGraphic.DrawEllipse(myPen5, 425, 205, 10, 10);
            myGraphic.DrawEllipse(myPen6, 390, 220, 10, 10);
            myGraphic.DrawEllipse(myPen7, 415, 220, 10, 10);
            myGraphic.DrawEllipse(myPen8, 440, 220, 10, 10);
        }
    }
}
