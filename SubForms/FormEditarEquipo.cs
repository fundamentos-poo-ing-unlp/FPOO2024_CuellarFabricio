using TIv2.Clases;

namespace TIv2.SubForms
{
    public partial class FormEditarEquipo : Form
    {
        private int modo;
        public FormEditarEquipo(int modo = 0)
        {
            InitializeComponent();
            this.modo = modo;
            if (modo != 0)
            {
                label1.Text = "Ingrese nuevo sentido de circualción:";
            }
        }
        public string descripcion;
        public string Descripcion => descripcion;

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción");
            }
            else
            {
                descripcion = this.textBox1.Text;
                this.Close();
            }
        }
    }
}
