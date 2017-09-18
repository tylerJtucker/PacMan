using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PacMan
{
    public partial class pacmanForm : Form
    {
        public pacmanForm()
        {
            InitializeComponent();
           
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            Graphics onScreen = this.CreateGraphics();
            Bitmap bm = new Bitmap(this.Width, this.Height);
            Graphics offScreen = Graphics.FromImage(bm);

            Pen drawPen2 = new Pen(Color.Yellow, 2);
            SolidBrush drawBrush2 = new SolidBrush(Color.Yellow);

            
            offScreen.FillPie(drawBrush2, 20, 20, 50, 50, 30, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);
            Thread.Sleep(500);

            offScreen.FillPie(drawBrush2, 30, 20, 50, 50, 30, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 40, 20, 50, 50, 30, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 50, 20, 50, 50, 30, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 60, 20, 50, 50, 30, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 70, 20, 50, 50, 30, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 80, 20, 50, 50, 30, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 90, 20, 50, 50, 30, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 100, 20, 50, 50, 30, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 110, 20, 50, 50, 30, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 120, 20, 50, 50, 30, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 130, 20, 50, 50, 30, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 140, 20, 50, 50, 30, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 150, 20, 50, 50, 30, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2,160, 20, 50, 50, 30, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 170, 20, 50, 50, 30, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 180, 20, 50, 50, 30, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 190, 20, 50, 50, 30, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 200, 20, 50, 50, 30, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 20, 50, 50, 30, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 20, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 30, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 40, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 50, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 60, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 70, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 80, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 90, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 100, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 110, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 120, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 130, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 140, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 150, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 160, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 170, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 180, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 190, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 200, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 210, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 220, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 230, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 240, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 250, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 260, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 270, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 280, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 290, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 300, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 310, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 320, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 330, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 340, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 350, 50, 50, 120, 360);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);

            offScreen.FillPie(drawBrush2, 210, 360, 50, 50, 120, 300);
            offScreen.DrawLine(drawPen, 0, 10, 275, 10);
            offScreen.DrawLine(drawPen, 0, 80, 205, 80);
            offScreen.DrawLine(drawPen, 270, 10, 270, 375);
            offScreen.DrawLine(drawPen, 200, 80, 200, 375);
            Thread.Sleep(200);
            Refresh();
            onScreen.DrawImage(bm, 0, 0);
            offScreen.Clear(Color.Black);
            Refresh();

            //
           
        }

        private void pacmanForm_Load(object sender, EventArgs e)
        {
            


        }
    }
}
