namespace DinningRoom
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
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            progressBar5 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Title = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(207, 80);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(541, 35);
            progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(207, 144);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(541, 35);
            progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(207, 208);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(541, 35);
            progressBar3.TabIndex = 2;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(207, 336);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(541, 35);
            progressBar4.TabIndex = 3;
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(207, 272);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(541, 35);
            progressBar5.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 80);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 4;
            label1.Text = "F1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 144);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 5;
            label2.Text = "F2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 208);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 6;
            label3.Text = "F3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 272);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 7;
            label4.Text = "F4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 336);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 8;
            label5.Text = "F5";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(73, 25);
            Title.Name = "Title";
            Title.Size = new Size(106, 15);
            Title.TabIndex = 9;
            Title.Text = "The Dinning Room";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Title);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar5);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private ProgressBar progressBar5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Title;
    }
}
