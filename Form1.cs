namespace practica05
{
    public partial class Form1 : Form
    {

        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Obtener las calificaciones ingresadas
            double Parcial1 = Convert.ToDouble(txtParcial1.Text);
            double Parcial2 = Convert.ToDouble(txtParcial2.Text);
            double Parcial3 = Convert.ToDouble(txtParcial3.Text);
            double Promedio = (Parcial1 + Parcial2 + Parcial3) / 3;

            // Determinar el estatus del alumno
            string Estatus;
            if (Promedio >= 95)
            {
                Estatus = "Exento";
            }
            else if (Promedio >= 70)
            {
                Estatus = "Ordinario";
            }
            else if (Promedio >= 50)
            {
                Estatus = "Extraordinario";
            }
            else
            {
                Estatus = "Especial";
            }
            int vIndice = dataGridView1.Rows.Add();
            dataGridView1.Rows[vIndice].Cells[0].Value = txtNombre.Text;
            dataGridView1.Rows[vIndice].Cells[1].Value = txtParcial1.Text;
            dataGridView1.Rows[vIndice].Cells[2].Value = txtParcial2.Text;
            dataGridView1.Rows[vIndice].Cells[3].Value = txtParcial3.Text;
            dataGridView1.Rows[vIndice].Cells[4].Value = Promedio;
            dataGridView1.Rows[vIndice].Cells[5].Value = Estatus;

            txtNombre.Text = "";
            txtParcial1.Text = "";
            txtParcial2.Text = "";
            txtParcial3.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
