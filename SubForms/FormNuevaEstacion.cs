using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIv2
{
    public partial class FormNuevaEstacion : Form
    {
        private string localidad;
        private double longitud;
        private double latitud;
        public FormNuevaEstacion()
        {
            InitializeComponent();
        }

        public string Localidad => localidad;
        public double Longitud => longitud;
        public double Latitud => latitud;
        private void button1_ok_Click(object sender, EventArgs e)
        {
            if (this.textBox1_localidad.Text == "" || this.textBox2_longitud.Text == "")
            {
                MessageBox.Show("Debe ingresar una localidad y sus coordenadas");
            }
            else
            {
                localidad = this.textBox1_localidad.Text;
                latitud = Double.Parse(this.textBox3_latitud.Text);
                longitud = Double.Parse(this.textBox2_longitud.Text);
                this.Close();
            }
        }
    }
}
