using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            panel1.Controls.Clear();
            int a;
            a = trackBar1.Value;
            if (a >= 1)
            {
                double a2 = 0;
                for (int i = 1; i < a + 1; i++)
                {
                    a2 += Math.Pow(i, 4);
                    Label lbl = new Label();
                    lbl.Text = $"{i} ^ 4";
                    lbl.Location = new Point(10, 30 * i);
                    panel1.Controls.Add(lbl);
                }
                label1.Text = Convert.ToString(a2);
                label2.Text = Convert.ToString(a * (a + 1) * (2 * a + 1) * (3 * Math.Pow(a, 2) + 3 * a - 1) / 30);
                label4.Text = "";
            }
        }
    }
}
