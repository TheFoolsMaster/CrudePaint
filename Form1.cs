using System.Drawing;
using System.Drawing.Imaging;

namespace CrudePaint
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;
        private Point startPoint;
        private int penWidth = 1;
        public Form1()
        {
            InitializeComponent();
            graphics = drawingBoard.CreateGraphics();
            drawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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

        private void btn_PenWidth_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter pen width:", "Pen Width", penWidth.ToString());
            if (int.TryParse(input, out int width))
            {
                penWidth = width;
                pen.Width = penWidth;
            }
        }
        private void btnSaveAsPNG_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(drawingBoard.Width, drawingBoard.Height);
                drawingBoard.DrawToBitmap(bitmap, new Rectangle(0, 0, drawingBoard.Width, drawingBoard.Height));
                bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }
        private void btnSaveAsJPEG_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG Image|*.jpeg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(drawingBoard.Width, drawingBoard.Height);
                drawingBoard.DrawToBitmap(bitmap, new Rectangle(0, 0, drawingBoard.Width, drawingBoard.Height));
                bitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void drawingBoard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}