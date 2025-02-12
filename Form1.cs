namespace PRACTICA02
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float cent = float.Parse(this.textBox1.Text);
            float fair = (cent * 9 / 5) + 32;
            this.Convertir.Text = fair.ToString();

        }

        private void lblIngrese_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            float cent = float.Parse(this.textBox2.Text);
            float fair = (cent - 32) * 5 / 9;
            this.Convertir1.Text = fair.ToString();
        }

        private void txtNum1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum2_Click(object sender, EventArgs e)
        {

        }

        private void txtNum4_Click(object sender, EventArgs e)
        {

        }

        private void lblingresefah_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
