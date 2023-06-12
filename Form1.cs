using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CrudePaint
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;
        private Point startPoint;
        private int penWidth = 1;
        private string currentFilePath = string.Empty;
        private Color mouseLB = Color.Black;
        private Color mouseRB = Color.White;
        private bool isDrawing = false;
        public Form1()
        {
            InitializeComponent();
            graphics = drawingBoard.CreateGraphics();
            drawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            colourPickerLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            colourPickerRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pen = new Pen(mouseLB, penWidth);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            lbl_PenWidth.Text = $"Pen Width: {penWidth}px";
        }

        private void drawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                drawingBoard.Capture = true;
                startPoint = e.Location;
                isDrawing = true;
            }
        }

        private void drawingBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pen.Color = mouseLB;
                graphics.DrawLine(pen, startPoint, e.Location);
                startPoint = e.Location;
            }
            if (e.Button == MouseButtons.Right)
            {
                pen.Color = mouseRB;
                graphics.DrawLine(pen, startPoint, e.Location);
                startPoint = e.Location;
            }
        }

        private void drawingBoard_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                drawingBoard.Capture = false;
                isDrawing = false;
            }
        }

        private void drawingBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by JP", "Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prompt user to confirm creating a new canvas
            DialogResult result = MessageBox.Show("Creating a new canvas will clear the current drawing. Do you want to proceed?", "New Canvas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                drawingBoard.Refresh(); // Clear the drawing board
                currentFilePath = string.Empty; // Reset the current file path
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpeg;*.jpg;*.png|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Load the selected image file
                Image image = Image.FromFile(filePath);
                drawingBoard.BackgroundImage = image;

                // Clear the drawing board and reset the current file path
                drawingBoard.Refresh();
                currentFilePath = filePath;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Image|*.jpeg|PNG Image|*.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                }
                else
                {
                    return; // User canceled the save operation
                }
            }

            string extension = Path.GetExtension(currentFilePath).ToLower();
            ImageFormat imageFormat = ImageFormat.Jpeg;

            if (extension == ".png")
            {
                imageFormat = ImageFormat.Png;
            }

            Bitmap bitmap = new Bitmap(drawingBoard.Width, drawingBoard.Height);
            drawingBoard.DrawToBitmap(bitmap, new Rectangle(0, 0, drawingBoard.Width, drawingBoard.Height));
            bitmap.Save(currentFilePath, imageFormat);
        }

        private void jPGToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void colourPickerLB_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                colourPickerLB.BackColor = colorPicker.Color;
                mouseLB = colorPicker.Color;
            }
        }

        private void colourPickerRB_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                colourPickerRB.BackColor = colorPicker.Color;
                mouseRB = colorPicker.Color;
            }
        }

        private void widthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            int trackBarValue = widthTrackBar.Value;
            penWidth = trackBarValue;
            pen.Width = penWidth;

            // Update the pen width label
            lbl_PenWidth.Text = $"Pen Width: {penWidth}px";
        }
    }
}