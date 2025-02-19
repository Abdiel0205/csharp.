namespace Practica_04_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUser.Text=="Admin" && txtPass.Text=="admin")
            {
                //mostrar el segundo formulario//
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");

            }
        }
    }
}