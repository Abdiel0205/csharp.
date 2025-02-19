namespace Actividad2
{
    public partial class Form1 : Form
    {
        int vIndice = -1;
        string vSeleccion;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Mexico");
            comboBox1.Items.Add("USA");
            comboBox1.Items.Add("Canada");
            comboBox1.Items.Add("China");
               
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            vSeleccion = Convert.ToString(comboBox1.Text);
            int vIndice = dataGridView1.Rows.Add();

            dataGridView1.Rows[vIndice].Cells[0].Value = txtNAME.Text;
            dataGridView1.Rows[vIndice].Cells[1].Value = txtLASTNAME.Text;
            dataGridView1.Rows[vIndice].Cells[2].Value = vSeleccion;

            txtNAME.Text = "";
            txtLASTNAME.Text = "";
            comboBox1.Text = "";
        }

        private void txtNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vIndice = e.RowIndex;
        }

        private void btnREMOVE_Click(object sender, EventArgs e)
        {
            if(vIndice != -1)
            {
                dataGridView1.Rows.RemoveAt(vIndice);
            }
        
            else
            {
                MessageBox.Show("Select a ITEM to delete");

            }
        }
    }
}


