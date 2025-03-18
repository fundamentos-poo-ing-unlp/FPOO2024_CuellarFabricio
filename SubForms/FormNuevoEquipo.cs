namespace TIv2.SubForms
{
    public partial class FormNuevoEquipo : Form
    {
        public string descripcion;
        public string ruta;
        public string tipoEquipo;

        public FormNuevoEquipo()
        {
            InitializeComponent();
        }
        public string Descripcion => descripcion;
        public string Ruta => ruta;
        public string TipoEquipo => tipoEquipo;
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1_tipoDeEquipo.Text == "" || this.textBox2_Descripcion.Text == "" || this.textBox1_Ruta.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos solicitados", "Advertencia");
            }
            else
            {
                descripcion = this.textBox2_Descripcion.Text;
                ruta = this.textBox1_Ruta.Text;
                tipoEquipo = this.comboBox1_tipoDeEquipo.Text;
                this.Close();
            }
        }
    }
}
