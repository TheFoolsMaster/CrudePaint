using System.Drawing;

namespace CrudePaint
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;
        private Point startPoint;
        public Form1()
        {
            InitializeComponent();
            graphics = drawingBoard.CreateGraphics();
            pen = new Pen(Color.Black);
        }

        private void drawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawingBoard.Capture = true;
                startPoint = e.Location;
            }
        }

        private void drawingBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                graphics.DrawLine(pen, startPoint, e.Location);
                startPoint = e.Location;
            }
        }

        private void drawingBoard_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawingBoard.Capture = false;
            }
        }

        private void btn_PenColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
                btn_PenColor.BackColor = colorDialog.Color;
            }
        }
    }
}