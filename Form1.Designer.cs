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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // drawingBoard
            // 
            drawingBoard.Location = new Point(320, 103);
            drawingBoard.Name = "drawingBoard";
            drawingBoard.Size = new Size(374, 208);
            drawingBoard.TabIndex = 0;
            drawingBoard.MouseDown += drawingBoard_MouseDown;
            drawingBoard.MouseMove += drawingBoard_MouseMove;
            drawingBoard.MouseUp += drawingBoard_MouseUp;
            // 
            // btn_PenColor
            // 
            btn_PenColor.Location = new Point(35, 58);
            btn_PenColor.Name = "btn_PenColor";
            btn_PenColor.Size = new Size(75, 23);
            btn_PenColor.TabIndex = 1;
            btn_PenColor.Text = "Colour";
            btn_PenColor.UseVisualStyleBackColor = true;
            btn_PenColor.Click += btn_PenColor_Click;
            // 
            // button1
            // 
            button1.Location = new Point(35, 103);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Width";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_PenWidth_Click;
            // 
            // button2
            // 
            button2.Location = new Point(35, 152);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "save jpg";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSaveAsJPEG_Click;
            // 
            // button3
            // 
            button3.Location = new Point(35, 200);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "save png";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnSaveAsPNG_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_PenColor);
            Controls.Add(drawingBoard);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel drawingBoard;
        private Button btn_PenColor;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}