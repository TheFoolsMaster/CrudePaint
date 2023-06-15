using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
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
        private List<SaveData> lines;
        private Bitmap drawingBitmap; // New bitmap for drawing
        private Bitmap offScreenBitmap; // Off-screen buffer

        public Form1()
        {
            InitializeComponent();
            drawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            colourPickerLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            colourPickerRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pen = new Pen(mouseLB, penWidth);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            lbl_PenWidth.Text = $"Pen Width: {penWidth}px";
            lines = new List<SaveData>();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Create the initial drawing bitmap with the same size as the picture box
            drawingBitmap = new Bitmap(drawingBoard.Width, drawingBoard.Height);
            graphics = Graphics.FromImage(drawingBitmap);
            drawingBoard.Image = drawingBitmap;

            // Initialize the off-screen buffer with the same size as the picture box
            offScreenBitmap = new Bitmap(drawingBoard.Width, drawingBoard.Height);
        }

        private void drawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                drawingBoard.Capture = true;
                startPoint = e.Location;
                isDrawing = true;
                pen = new Pen(e.Button == MouseButtons.Left ? mouseLB : mouseRB, penWidth);
                pen.StartCap = LineCap.Round; // Set the start cap to round
                pen.EndCap = LineCap.Round; // Set the end cap to round
            }
        }

        private void drawingBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pen.Color = mouseLB;
                    graphics.DrawLine(pen, startPoint, e.Location);
                    lines.Add(new SaveData { Pen = new Pen(pen.Color, pen.Width), StartPoint = startPoint, EndPoint = e.Location });
                    startPoint = e.Location;
                    drawingBoard.Invalidate(); // Invalidate the picture box to request a redraw
                }
                else if (e.Button == MouseButtons.Right)
                {
                    pen.Color = mouseRB;
                    graphics.DrawLine(pen, startPoint, e.Location);
                    lines.Add(new SaveData { Pen = new Pen(pen.Color, pen.Width), StartPoint = startPoint, EndPoint = e.Location });
                    startPoint = e.Location;
                    drawingBoard.Invalidate(); // Invalidate the picture box to request a redraw
                }
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
            // Draw the off-screen buffer onto the screen
            e.Graphics.DrawImage(offScreenBitmap, Point.Empty);
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
                // Clear the drawing bitmap and lines
                graphics.Clear(Color.Transparent);
                lines.Clear();
                drawingBoard.Invalidate();
                currentFilePath = string.Empty;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpeg;*.jpg;*.png|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Clear the lines and create a new drawing bitmap
                lines.Clear();
                drawingBitmap.Dispose();
                drawingBitmap = new Bitmap(drawingBoard.Width, drawingBoard.Height);
                graphics = Graphics.FromImage(drawingBitmap);
                drawingBoard.Image = drawingBitmap;

                // Load the image as the drawing bitmap
                using (Bitmap bitmap = new Bitmap(filePath))
                {
                    graphics.DrawImage(bitmap, Point.Empty);
                }

                drawingBoard.Invalidate();
                currentFilePath = filePath;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                SaveImage(currentFilePath);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Image|*.jpeg|PNG Image|*.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    SaveImage(currentFilePath);
                }
            }
        }

        private void SaveImage(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            ImageFormat imageFormat = ImageFormat.Jpeg;

            if (extension == ".png")
            {
                imageFormat = ImageFormat.Png;
            }

            // Create a new bitmap with the same size as the picture box
            Bitmap bitmap = new Bitmap(drawingBoard.Width, drawingBoard.Height);

            // Create a graphics object from the new bitmap
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Make the background transparent for PNG format
                if (imageFormat == ImageFormat.Png)
                {
                    bitmap.MakeTransparent();
                }

                // Draw the existing lines onto the bitmap
                foreach (SaveData line in lines)
                {
                    g.DrawLine(line.Pen, line.StartPoint, line.EndPoint);
                }

                // Draw the current drawing onto the bitmap
                g.DrawImage(drawingBitmap, Point.Empty);
            }

            // Save the bitmap using the provided file path
            bitmap.Save(filePath, imageFormat);
            bitmap.Dispose();

            MessageBox.Show("Image saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void jPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG Image|*.jpeg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                drawingBitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                drawingBitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
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
            pen.StartCap = LineCap.Round; // Set the start cap to round
            pen.EndCap = LineCap.Round; // Set the end cap to round

            // Update the pen width label
            lbl_PenWidth.Text = $"Pen Width: {penWidth}px";
        }

        private void drawingBoard_Resize(object sender, EventArgs e)
        {
            // Recreate the off-screen buffer with the new size
            if (offScreenBitmap != null)
            {
                offScreenBitmap.Dispose();
            }
            offScreenBitmap = new Bitmap(drawingBoard.Width, drawingBoard.Height);
            graphics = Graphics.FromImage(offScreenBitmap);
            graphics.DrawImage(drawingBitmap, Point.Empty);
        }
    }
}
