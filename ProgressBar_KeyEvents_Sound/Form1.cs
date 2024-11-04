namespace ProgressBar_KeyEvents_Sound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Bildiris");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                MessageBox.Show("Proqres barın dəyərini aşdınız!",
                    "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 0)
            {
                progressBar1.Value -= 10;
            }
            else
            {
                MessageBox.Show("Proqres barın dəyərini aşdınız!",
                    "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            //MessageBox.Show("Panelden çıxdınız!");
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Paneneli buraxdiniz!");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Paneneli basdiniz!");
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("Paneneli uzerinde!");
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("Paneneli uzerinde!");
        }

   
    }
}
