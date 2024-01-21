using System;
using System.Windows.Forms;

namespace MyWindowsApp
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeUI();
            this.Size = new System.Drawing.Size(1600, 900);
        }

        private void InitializeUI() {
            // Create and configure Button 1
            Button button1 = new Button();
            button1.Text = "Button 1";
            button1.Location = new System.Drawing.Point(50, 50);
            button1.Click += Button1_Click;

            // Create and configure Button 2
            Button button2 = new Button();
            button2.Text = "Button 2";
            button2.Location = new System.Drawing.Point(150, 50);
            button2.Click += Button2_Click;

            // Add buttons to the form
            Controls.Add(button1);
            Controls.Add(button2);
        }

        private void Button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Button 1 clicked!");
        }

        private void Button2_Click(object sender, EventArgs e) {
            MessageBox.Show("Button 2 clicked!");
        }

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
