using Microsoft.VisualBasic.ApplicationServices;

namespace renta_de_peliculas
{
    public partial class Form1 : Form
    {
        // Diccionario con los precios base y porcentaje de multa por género
        private Dictionary<string, (double precio, double multa)> tarifas = new Dictionary<string, (double, double)>
        {
            {"Acción", (50, 0.10)},
            {"Comedia", (40, 0.08)},
            {"Drama", (45, 0.07)},
            {"Terror", (55, 0.12)},
            {"Ciencia Ficción", (60, 0.15)}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.AddRange(new string[] { "Acción", "Comedia", "Drama", "Terror", "Ciencia Ficción" });
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Configurar el Timer
            timer1.Interval = 1000; // Actualiza cada segundo
            timer1.Tick += new EventHandler(ActualizarHora);
            timer1.Start();
        }
        private void ActualizarHora(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss"); // Formato 24 horas
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbGenero.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un género y/o ingresa un número válido de días.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 2️⃣ Validar que el usuario haya ingresado un número válido de días
            if (!int.TryParse(txtDiasRetardo.Text, out int dias) || dias < 0)
            {
                MessageBox.Show("Por favor, ingresa un número válido de días (mayor o igual a 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 3️⃣ Obtener el género seleccionado
            string Genero = cmbGenero.SelectedItem.ToString() ?? "";
            // 4️⃣ Verificar que el género existe en el diccionario
            if (!tarifas.ContainsKey(Genero))
            {
                MessageBox.Show("El género seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 5️⃣ Obtener los valores del diccionario
            double precioBase = tarifas[Genero].precio;
            double multaPorDia = tarifas[Genero].multa;

            // 6️⃣ Calcular la multa y el total a pagar
            double multaTotal = (dias > 0) ? (dias * precioBase * multaPorDia) : 0;
            double total = precioBase + multaTotal;

            // 7️⃣ Agregar los datos a la tabla DataGridView (dgvDetalles)
            dgvDetalles.Rows.Add(Genero, precioBase.ToString("C"), multaTotal.ToString("C"), total.ToString("C"));

            // 8️⃣ Mostrar el total en txtTotal
            txtTotal.Text = total.ToString("C");

            // 9️⃣ Mostrar la imagen correspondiente al género







        }







        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
                        









