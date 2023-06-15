namespace CrudePaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            widthTrackBar = new TrackBar();
            btnEraser = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            jPGToolStripMenuItem = new ToolStripMenuItem();
            pNGToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            authorToolStripMenuItem = new ToolStripMenuItem();
            colourPickerLB = new PictureBox();
            colourPickerRB = new PictureBox();
            lbl_PenWidth = new Label();
            drawingBoard = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)widthTrackBar).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)colourPickerLB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colourPickerRB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drawingBoard).BeginInit();
            SuspendLayout();
            // 
            // widthTrackBar
            // 
            widthTrackBar.Location = new Point(99, 69);
            widthTrackBar.Name = "widthTrackBar";
            widthTrackBar.RightToLeft = RightToLeft.No;
            widthTrackBar.Size = new Size(104, 45);
            widthTrackBar.TabIndex = 5;
            widthTrackBar.ValueChanged += widthTrackBar_ValueChanged;
            // 
            // btnEraser
            // 
            btnEraser.Location = new Point(700, 51);
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(76, 52);
            btnEraser.TabIndex = 6;
            btnEraser.Text = "Eraser";
            btnEraser.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, saveToolStripMenuItem1, authorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(112, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(112, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(112, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jPGToolStripMenuItem, pNGToolStripMenuItem });
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(112, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            // 
            // jPGToolStripMenuItem
            // 
            jPGToolStripMenuItem.Name = "jPGToolStripMenuItem";
            jPGToolStripMenuItem.Size = new Size(98, 22);
            jPGToolStripMenuItem.Text = "JPG";
            jPGToolStripMenuItem.Click += jPGToolStripMenuItem_Click;
            // 
            // pNGToolStripMenuItem
            // 
            pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            pNGToolStripMenuItem.Size = new Size(98, 22);
            pNGToolStripMenuItem.Text = "PNG";
            pNGToolStripMenuItem.Click += pNGToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(43, 20);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem_Click;
            // 
            // authorToolStripMenuItem
            // 
            authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            authorToolStripMenuItem.Size = new Size(56, 20);
            authorToolStripMenuItem.Text = "Author";
            authorToolStripMenuItem.Click += authorToolStripMenuItem_Click;
            // 
            // colourPickerLB
            // 
            colourPickerLB.BackColor = Color.Black;
            colourPickerLB.Location = new Point(20, 69);
            colourPickerLB.Name = "colourPickerLB";
            colourPickerLB.Size = new Size(25, 25);
            colourPickerLB.TabIndex = 8;
            colourPickerLB.TabStop = false;
            colourPickerLB.Click += colourPickerLB_Click;
            // 
            // colourPickerRB
            // 
            colourPickerRB.BackColor = Color.White;
            colourPickerRB.Location = new Point(55, 69);
            colourPickerRB.Name = "colourPickerRB";
            colourPickerRB.Size = new Size(25, 25);
            colourPickerRB.TabIndex = 9;
            colourPickerRB.TabStop = false;
            colourPickerRB.Click += colourPickerRB_Click;
            // 
            // lbl_PenWidth
            // 
            lbl_PenWidth.AutoSize = true;
            lbl_PenWidth.Location = new Point(99, 44);
            lbl_PenWidth.Name = "lbl_PenWidth";
            lbl_PenWidth.Size = new Size(65, 15);
            lbl_PenWidth.TabIndex = 10;
            lbl_PenWidth.Text = "Pen Width:";
            // 
            // drawingBoard
            // 
            drawingBoard.BackColor = Color.White;
            drawingBoard.Location = new Point(12, 109);
            drawingBoard.Name = "drawingBoard";
            drawingBoard.Size = new Size(776, 338);
            drawingBoard.TabIndex = 11;
            drawingBoard.TabStop = false;
            drawingBoard.Paint += drawingBoard_Paint;
            drawingBoard.MouseDown += drawingBoard_MouseDown;
            drawingBoard.MouseMove += drawingBoard_MouseMove;
            drawingBoard.MouseUp += drawingBoard_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(drawingBoard);
            Controls.Add(lbl_PenWidth);
            Controls.Add(colourPickerRB);
            Controls.Add(colourPickerLB);
            Controls.Add(btnEraser);
            Controls.Add(widthTrackBar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)widthTrackBar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)colourPickerLB).EndInit();
            ((System.ComponentModel.ISupportInitialize)colourPickerRB).EndInit();
            ((System.ComponentModel.ISupportInitialize)drawingBoard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar widthTrackBar;
        private Button btnEraser;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem jPGToolStripMenuItem;
        private ToolStripMenuItem pNGToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem authorToolStripMenuItem;
        private PictureBox colourPickerLB;
        private PictureBox colourPickerRB;
        private Label lbl_PenWidth;
        private PictureBox drawingBoard;
    }
}