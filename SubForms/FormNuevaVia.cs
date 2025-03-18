using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIv2.SubForms
{
    public partial class FormNuevaVia : Form
    {
        private string sentido;
        private int numero;
        private int id_equipo;
        public FormNuevaVia()
        {
            InitializeComponent();
        }
        public string Sentido => sentido;
        public int Numero => numero;   
        public int ID_equipo => id_equipo;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_nroVia.Text != "" || textBox_sentido.Text != "" || textBox_idequipo.Text != "")
            {
                if(Int32.TryParse(textBox_nroVia.Text, out numero) && Int32.TryParse(textBox_idequipo.Text, out id_equipo))
                {
                    sentido = textBox_sentido.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese valores numéricos para el número de vía y el ID del equipo.", "Advertencia");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos solicitados", "Advertencia");
            }
            
        }
    }
}
