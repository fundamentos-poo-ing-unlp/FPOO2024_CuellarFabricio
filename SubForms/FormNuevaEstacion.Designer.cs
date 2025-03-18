namespace TIv2
{
    partial class FormNuevaEstacion
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            textBox1_localidad = new TextBox();
            label2 = new Label();
            textBox2_longitud = new TextBox();
            label3 = new Label();
            textBox3_latitud = new TextBox();
            button1_ok = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1_localidad, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox2_longitud, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox3_latitud, 1, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.88889F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.11111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(370, 122);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 17);
            label1.TabIndex = 0;
            label1.Text = "Ingresar localidad:";
            // 
            // textBox1_localidad
            // 
            textBox1_localidad.Location = new Point(3, 20);
            textBox1_localidad.Name = "textBox1_localidad";
            textBox1_localidad.Size = new Size(177, 27);
            textBox1_localidad.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 1;
            label2.Text = "Ingresar longitud:";
            // 
            // textBox2_longitud
            // 
            textBox2_longitud.Location = new Point(3, 66);
            textBox2_longitud.Name = "textBox2_longitud";
            textBox2_longitud.Size = new Size(155, 27);
            textBox2_longitud.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 44);
            label3.Name = "label3";
            label3.Size = new Size(112, 19);
            label3.TabIndex = 4;
            label3.Text = "Ingresar latitud:";
            // 
            // textBox3_latitud
            // 
            textBox3_latitud.Location = new Point(186, 66);
            textBox3_latitud.Name = "textBox3_latitud";
            textBox3_latitud.Size = new Size(152, 27);
            textBox3_latitud.TabIndex = 5;
            // 
            // button1_ok
            // 
            button1_ok.Location = new Point(80, 136);
            button1_ok.Name = "button1_ok";
            button1_ok.Size = new Size(235, 45);
            button1_ok.TabIndex = 1;
            button1_ok.Text = "OK";
            button1_ok.UseVisualStyleBackColor = true;
            button1_ok.Click += button1_ok_Click;
            // 
            // FormNuevaEstacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 185);
            Controls.Add(button1_ok);
            Controls.Add(tableLayoutPanel1);
            Name = "FormNuevaEstacion";
            Text = "NuevaEstacion";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox1_localidad;
        private Label label2;
        private TextBox textBox2_longitud;
        private Button button1_ok;
        private Label label3;
        private TextBox textBox3_latitud;
    }
}