namespace Bored_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(12, 13);
            button1.Name = "button1";
            button1.Size = new Size(490, 35);
            button1.TabIndex = 0;
            button1.Text = "Learn some Mandarin";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Gadugi", 9.75F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(12, 54);
            button2.Name = "button2";
            button2.Size = new Size(490, 35);
            button2.TabIndex = 1;
            button2.Text = "Learn some Japanese";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Gadugi", 9.75F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Location = new Point(12, 96);
            button3.Name = "button3";
            button3.Size = new Size(490, 35);
            button3.TabIndex = 2;
            button3.Text = "Learn some German";
            button3.UseVisualStyleBackColor = false;
            button3.UseWaitCursor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Gadugi", 9.75F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ActiveCaption;
            button4.Location = new Point(12, 221);
            button4.Name = "button4";
            button4.Size = new Size(490, 35);
            button4.TabIndex = 5;
            button4.Text = "Do some C++ Programming for Github";
            button4.UseVisualStyleBackColor = false;
            button4.UseWaitCursor = true;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.Font = new Font("Gadugi", 9.75F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ActiveCaption;
            button5.Location = new Point(12, 179);
            button5.Name = "button5";
            button5.Size = new Size(490, 35);
            button5.TabIndex = 4;
            button5.Text = "Do some Python Programming for Github";
            button5.UseVisualStyleBackColor = false;
            button5.UseWaitCursor = true;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.Font = new Font("Gadugi", 9.75F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ActiveCaption;
            button6.Location = new Point(12, 138);
            button6.Name = "button6";
            button6.Size = new Size(490, 35);
            button6.TabIndex = 3;
            button6.Text = "Do some C# Programming for Github";
            button6.UseVisualStyleBackColor = false;
            button6.UseWaitCursor = true;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveCaptionText;
            button9.Font = new Font("Gadugi", 9.75F, FontStyle.Bold);
            button9.ForeColor = SystemColors.ActiveCaption;
            button9.Location = new Point(12, 262);
            button9.Name = "button9";
            button9.Size = new Size(490, 35);
            button9.TabIndex = 6;
            button9.Text = "Do some Front-Web Development for Github";
            button9.UseVisualStyleBackColor = false;
            button9.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1465, 932);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Bored App";
            UseWaitCursor = true;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button9;
    }
}
