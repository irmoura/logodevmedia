using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devmedialogo
{
    public partial class Form1 : Form
    {

        private Graphics graphics = null;
        private int centralHorizontalLine;
        private int centralVerticalLine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centralHorizontalLine = (this.Width / 2) - 8;
            centralVerticalLine = (this.Height / 2) - 7;
            //
            graphics = this.CreateGraphics();
            //
            FillEllipse(Color.FromArgb(123, 172, 59), centralHorizontalLine, centralVerticalLine - (945 / 2), 945);
            //
            GraphicsPath graphicsPath = new GraphicsPath();
            //
            graphicsPath.AddPolygon(new PointF[] {
                new PointF(centralHorizontalLine - 250, centralVerticalLine + 407),
                new PointF(centralHorizontalLine - 34,  centralVerticalLine + 192),
                new PointF(centralHorizontalLine - 430,  centralVerticalLine - 204),
                new PointF(centralHorizontalLine - 430,  centralVerticalLine - 273),
                new PointF(centralHorizontalLine - 191,  centralVerticalLine - 34),
                new PointF(centralHorizontalLine + 250,  centralVerticalLine - 474),
                new PointF(centralHorizontalLine + 250,  centralVerticalLine - 406),
                new PointF(centralHorizontalLine + 34,  centralVerticalLine - 190),
                new PointF(centralHorizontalLine + 430,  centralVerticalLine + 206),
                new PointF(centralHorizontalLine + 430,  centralVerticalLine + 273),
                new PointF(centralHorizontalLine + 190,  centralVerticalLine + 34),
                new PointF(centralHorizontalLine - 250, centralVerticalLine + 477)
            });
            //
            graphics.FillPath(Brushes.Black, graphicsPath);
        }

        private void FillEllipse(Color color, int x, int y, int size)
        {
            Rectangle rectangle = new Rectangle((x - (size / 2)), y, size, size);
            graphics.FillEllipse(new SolidBrush(color), rectangle);
        }
    }
}
