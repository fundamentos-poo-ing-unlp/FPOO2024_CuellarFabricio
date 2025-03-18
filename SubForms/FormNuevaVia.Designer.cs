namespace TIv2.SubForms
{
    partial class FormNuevaVia
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
            label1 = new Label();
            textBox_sentido = new TextBox();
            label2 = new Label();
            textBox_nroVia = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox_idequipo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Sentido de circulación";
            // 
            // textBox_sentido
            // 
            textBox_sentido.Location = new Point(174, 33);
            textBox_sentido.Name = "textBox_sentido";
            textBox_sentido.Size = new Size(182, 27);
            textBox_sentido.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 66);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Número de vía";
            // 
            // textBox_nroVia
            // 
            textBox_nroVia.Location = new Point(174, 66);
            textBox_nroVia.Name = "textBox_nroVia";
            textBox_nroVia.Size = new Size(32, 27);
            textBox_nroVia.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(253, 66);
            button1.Name = "button1";
            button1.Size = new Size(103, 74);
            button1.TabIndex = 4;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 102);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 5;
            label3.Text = "ID equipo asociado";
            // 
            // textBox_idequipo
            // 
            textBox_idequipo.Location = new Point(174, 99);
            textBox_idequipo.Name = "textBox_idequipo";
            textBox_idequipo.Size = new Size(53, 27);
            textBox_idequipo.TabIndex = 6;
            // 
            // FormNuevaVia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 185);
            Controls.Add(textBox_idequipo);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox_nroVia);
            Controls.Add(label2);
            Controls.Add(textBox_sentido);
            Controls.Add(label1);
            Name = "FormNuevaVia";
            Text = "FormNuevaVia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_sentido;
        private Label label2;
        private TextBox textBox_nroVia;
        private Button button1;
        private Label label3;
        private TextBox textBox_idequipo;
    }
}