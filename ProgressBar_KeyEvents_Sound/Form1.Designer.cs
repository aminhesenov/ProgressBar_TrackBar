namespace ProgressBar_KeyEvents_Sound
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
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            trackBar1 = new TrackBar();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(295, 40);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 20;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 1;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(232, 76);
            button2.Name = "button2";
            button2.Size = new Size(75, 34);
            button2.TabIndex = 2;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 141);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(295, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(12, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 100);
            panel1.TabIndex = 4;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseEnter += panel1_MouseEnter;
            panel1.MouseLeave += panel1_MouseLeave;
            panel1.MouseHover += panel1_MouseHover;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 369);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(trackBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private TrackBar trackBar1;
        private Panel panel1;
        public Label label1;
    }
}
