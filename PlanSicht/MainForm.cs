using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanSicht
{
    public partial class MainForm : Form
    {
        private Bitmap PlanImage;
        private PointF PlanViewTranslation = Point.Empty;
        private Point MouseStartPos = Point.Empty;
        private Point MouseDelta = Point.Empty;
        private int PlanViewZoom = 0;
        private float Zoomfactor = 1f;

        public MainForm()
        {
            InitializeComponent();            
            this.Paint += pView_Paint;            
            this.MouseWheel += MainForm_MouseWheel;
        }

        private void Redraw()
        {
            this.Invalidate();
            this.Update();
            showStatus();
        }

        private void MainForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                PlanViewZoom++;
            else
                PlanViewZoom--;
            Zoomfactor = (float)Math.Pow(2d, PlanViewZoom / 5d);
            Redraw();
        }

        private void showStatus()
        {
            var b = new StringBuilder();
            if (PlanImage != null)
            {
                b.AppendLine($"W: {PlanImage.Width}");
                b.AppendLine($"W: {PlanImage.Height}");
            }
            else b.AppendLine("No Image");
            b.AppendLine($"T: {PlanViewTranslation}");
            b.AppendLine($"Z: {Zoomfactor}");
            tbStatus.Text = b.ToString();
        }

        private void pView_Paint(object sender, PaintEventArgs e)
        {
            if (PlanImage != null && ((PlanImage.Width>0 && PlanImage.Height>0)))
            {
                var g = e.Graphics;
                {
                    RectangleF source = new RectangleF(0, 0, PlanImage.Width, PlanImage.Height);
                    float wz = PlanImage.Width * Zoomfactor;
                    float hz = PlanImage.Height * Zoomfactor;
                    int mx = pSide.Left / 2;
                    int my = pSide.Height / 2;

                    RectangleF dest = new RectangleF(MouseDelta.X + PlanViewTranslation.X - wz / 2 + mx, MouseDelta.Y + PlanViewTranslation.Y - hz / 2 + my, wz, hz);
                    g.DrawImage(PlanImage, dest, source, GraphicsUnit.Pixel);
                }
            }
        }

        private void pView_MouseUp(object sender, MouseEventArgs e)
        {
            Redraw();
        }

        private void DrawonBitmap(Bitmap b)
        {
            using (var g = Graphics.FromImage(b))
            {
                g.Clear(Color.DarkGray);
                using (var p = new Pen(Brushes.Red))
                {                   
                    p.Width = 2;
                    g.DrawEllipse(p, 0, 0, b.Width-1, b.Height-1);
                }
            }
        }

        private void bOpen_Click(object sender, EventArgs e)
        {           
            PlanImage?.Dispose();
            PlanImage = new Bitmap(1000, 1000);
            DrawonBitmap(PlanImage);
            Redraw();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseStartPos = e.Location;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDelta = new Point(e.X - MouseStartPos.X, e.Y - MouseStartPos.Y);
                Redraw();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PlanViewTranslation.X += MouseDelta.X;
                PlanViewTranslation.Y += MouseDelta.Y;
                MouseDelta = Point.Empty;
                Redraw();
            }
        }

        private void bResetZoom_Click(object sender, EventArgs e)
        {
            PlanViewZoom = 0;
            Zoomfactor = 1f;
            Redraw();
        }

        private void bResetPos_Click(object sender, EventArgs e)
        {
            PlanViewTranslation = PointF.Empty;
            Redraw();
        }
    }
}
