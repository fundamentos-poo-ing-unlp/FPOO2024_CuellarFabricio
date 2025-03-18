namespace TIv2.SubForms
{
    partial class FormNuevoEquipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1_tipoDeEquipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox1_Ruta = new TextBox();
            label3 = new Label();
            textBox2_Descripcion = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1_tipoDeEquipo
            // 
            comboBox1_tipoDeEquipo.FormattingEnabled = true;
            comboBox1_tipoDeEquipo.Items.AddRange(new object[] { "Equipo VC", "Equipo VR" });
            comboBox1_tipoDeEquipo.Location = new Point(149, 15);
            comboBox1_tipoDeEquipo.Name = "comboBox1_tipoDeEquipo";
            comboBox1_tipoDeEquipo.Size = new Size(97, 28);
            comboBox1_tipoDeEquipo.TabIndex = 0;
            comboBox1_tipoDeEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Tipo de equipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 55);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Ruta (.txt o .db)";
            // 
            // textBox1_Ruta
            // 
            textBox1_Ruta.Location = new Point(149, 52);
            textBox1_Ruta.Name = "textBox1_Ruta";
            textBox1_Ruta.Size = new Size(208, 27);
            textBox1_Ruta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 95);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Descripción";
            // 
            // textBox2_Descripcion
            // 
            textBox2_Descripcion.Location = new Point(149, 92);
            textBox2_Descripcion.Name = "textBox2_Descripcion";
            textBox2_Descripcion.Size = new Size(208, 27);
            textBox2_Descripcion.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(112, 132);
            button1.Name = "button1";
            button1.Size = new Size(163, 41);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormNuevoEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 185);
            Controls.Add(button1);
            Controls.Add(textBox2_Descripcion);
            Controls.Add(label3);
            Controls.Add(textBox1_Ruta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1_tipoDeEquipo);
            Name = "FormNuevoEquipo";
            Text = "Nuevo Equipo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1_tipoDeEquipo;
        private Label label1;
        private Label label2;
        private TextBox textBox1_Ruta;
        private Label label3;
        private TextBox textBox2_Descripcion;
        private Button button1;
    }
}