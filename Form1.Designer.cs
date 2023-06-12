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
            drawingBoard = new Panel();
            btn_PenColor = new Button();
            btn_PenWidth = new Button();
            btnSaveAsJPEG = new Button();
            btnSaveAsPNG = new Button();
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
            ((System.ComponentModel.ISupportInitialize)widthTrackBar).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // drawingBoard
            // 
            drawingBoard.Location = new Point(26, 120);
            drawingBoard.Name = "drawingBoard";
            drawingBoard.Size = new Size(762, 318);
            drawingBoard.TabIndex = 0;
            drawingBoard.Paint += drawingBoard_Paint;
            drawingBoard.MouseDown += drawingBoard_MouseDown;
            drawingBoard.MouseMove += drawingBoard_MouseMove;
            drawingBoard.MouseUp += drawingBoard_MouseUp;
            // 
            // btn_PenColor
            // 
            btn_PenColor.Location = new Point(26, 58);
            btn_PenColor.Name = "btn_PenColor";
            btn_PenColor.Size = new Size(138, 45);
            btn_PenColor.TabIndex = 1;
            btn_PenColor.Text = "Colour";
            btn_PenColor.UseVisualStyleBackColor = true;
            btn_PenColor.Click += btn_PenColor_Click;
            // 
            // btn_PenWidth
            // 
            btn_PenWidth.Location = new Point(212, 40);
            btn_PenWidth.Name = "btn_PenWidth";
            btn_PenWidth.Size = new Size(75, 23);
            btn_PenWidth.TabIndex = 2;
            btn_PenWidth.Text = "Width";
            btn_PenWidth.UseVisualStyleBackColor = true;
            btn_PenWidth.Click += btn_PenWidth_Click;
            // 
            // btnSaveAsJPEG
            // 
            btnSaveAsJPEG.Location = new Point(320, 51);
            btnSaveAsJPEG.Name = "btnSaveAsJPEG";
            btnSaveAsJPEG.Size = new Size(75, 23);
            btnSaveAsJPEG.TabIndex = 3;
            btnSaveAsJPEG.Text = "Save JPEG";
            btnSaveAsJPEG.UseVisualStyleBackColor = true;
            btnSaveAsJPEG.Click += btnSaveAsJPEG_Click;
            // 
            // btnSaveAsPNG
            // 
            btnSaveAsPNG.Location = new Point(320, 80);
            btnSaveAsPNG.Name = "btnSaveAsPNG";
            btnSaveAsPNG.Size = new Size(75, 23);
            btnSaveAsPNG.TabIndex = 4;
            btnSaveAsPNG.Text = "Save PNG";
            btnSaveAsPNG.UseVisualStyleBackColor = true;
            btnSaveAsPNG.Click += btnSaveAsPNG_Click;
            // 
            // widthTrackBar
            // 
            widthTrackBar.Location = new Point(198, 69);
            widthTrackBar.Name = "widthTrackBar";
            widthTrackBar.Size = new Size(104, 45);
            widthTrackBar.TabIndex = 5;
            // 
            // btnEraser
            // 
            btnEraser.Location = new Point(401, 51);
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(76, 52);
            btnEraser.TabIndex = 6;
            btnEraser.Text = "Eraser";
            btnEraser.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, saveToolStripMenuItem1 });
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
            fileToolStripMenuItem.Text = "FIle";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(112, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(112, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(112, 22);
            saveToolStripMenuItem.Text = "Save";
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
            // 
            // pNGToolStripMenuItem
            // 
            pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            pNGToolStripMenuItem.Size = new Size(98, 22);
            pNGToolStripMenuItem.Text = "PNG";
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(43, 20);
            saveToolStripMenuItem1.Text = "Save";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEraser);
            Controls.Add(widthTrackBar);
            Controls.Add(btnSaveAsPNG);
            Controls.Add(btnSaveAsJPEG);
            Controls.Add(btn_PenWidth);
            Controls.Add(btn_PenColor);
            Controls.Add(drawingBoard);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)widthTrackBar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel drawingBoard;
        private Button btn_PenColor;
        private Button btn_PenWidth;
        private Button btnSaveAsJPEG;
        private Button btnSaveAsPNG;
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
    }
}