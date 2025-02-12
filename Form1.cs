using static System.Windows.Forms.MonthCalendar;

namespace practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Double.TryParse(TextBox1.Text, out double radio))
            {
                double area = Math.PI * Math.Pow(radio, 2);
                Calcular1.Text = area.ToString("F2");
            }
            else
            {
                MessageBox.Show("ingrese un valor válido para el radio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular2_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(TextBox1.Text, out double radio))
            {
                double perimetro = 2 * Math.PI * radio;
                Calcular2.Text = perimetro.ToString("F2");
            }
            else
            {
                MessageBox.Show("ingrese un valor válido para el radio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
