using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIv2.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TIv2.SubForms
{
    public partial class FormEditVia : Form
    {
        private string sentido;
        private int nro;
        private Via via;
        private Equipo e;
        public string Sentido => sentido;
        public FormEditVia(Equipo eq)
        {
            InitializeComponent();
            e = eq;
            foreach (Via v in e.vias)
            {
                comboBox1.Items.Add(v.NumeroCarril);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nro = Int32.Parse(comboBox1.Text);
            via = this.e.GetVia(nro);
            textBox1.Text = via.SentidoCirculacion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.e.ModificarSentidoVia(nro, textBox1.Text);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.e.QuitarVia(via);
            this.Close();
        }
    }
}
