using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CrudePaint
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen penLB;
        private Pen penRB;
        private Point startPoint;
        private int penWidth = 1;
        private string currentFilePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
            graphics = drawingBoard.CreateGraphics();
            drawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            colourPickerLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            colourPickerRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            penLB = new Pen(Color.Black);
            penRB = new Pen(Color.White);
        }

        private void drawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawingBoard.Capture = true;
                startPoint = e.Location;
            }
            if (e.Button == MouseButtons.Right)
            {
                drawingBoard.Capture = true;
                startPoint = e.Location;
            }
        }

        private void drawingBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                graphics.DrawLine(penLB, startPoint, e.Location);
                startPoint = e.Location;
            }
            if (e.Button == MouseButtons.Right)
            {
                graphics.DrawLine(penRB, startPoint, e.Location);
                startPoint = e.Location;
            }
        }

        private void drawingBoard_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawingBoard.Capture = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                drawingBoard.Capture = false;
            }
        }

        private void btn_PenColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                penLB.Color = colorDialog.Color;
                btn_PenColor.BackColor = colorDialog.Color;
            }
        }

        private void btn_PenWidth_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter penLB width:", "Pen Width", penWidth.ToString());
            if (int.TryParse(input, out int width))
            {
                penWidth = width;
                penLB.Width = penWidth;
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
                penLB.Color = colorPicker.Color;
            }
        }

        private void colourPickerRB_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                colourPickerRB.BackColor = colorPicker.Color;
                penRB.Color = colorPicker.Color;
            }
        }
    }
}