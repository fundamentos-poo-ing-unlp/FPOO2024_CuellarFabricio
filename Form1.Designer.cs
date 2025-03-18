using GMap.NET.MapProviders;

namespace TIv2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            menuStrip1 = new MenuStrip();
            administraciónToolStripMenuItem = new ToolStripMenuItem();
            nuevaEstaciónToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label3 = new Label();
            button_agregarVia = new Button();
            label2 = new Label();
            button_eliminarEquipo = new Button();
            button_editarEquipo = new Button();
            button_agregarEquipo = new Button();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            label4 = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(10, 266);
            gMapControl1.Margin = new Padding(3, 2, 3, 2);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(288, 176);
            gMapControl1.TabIndex = 1;
            gMapControl1.Zoom = 0D;
            gMapControl1.OnMarkerClick += ClickEnMarcador;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { administraciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1098, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaEstaciónToolStripMenuItem });
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(100, 20);
            administraciónToolStripMenuItem.Text = "Administración";
            // 
            // nuevaEstaciónToolStripMenuItem
            // 
            nuevaEstaciónToolStripMenuItem.Name = "nuevaEstaciónToolStripMenuItem";
            nuevaEstaciónToolStripMenuItem.Size = new Size(180, 22);
            nuevaEstaciónToolStripMenuItem.Text = "Nueva estación";
            nuevaEstaciónToolStripMenuItem.Click += nuevaEstaciónToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(318, 266);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(196, 176);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button_agregarVia);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_eliminarEquipo);
            panel1.Controls.Add(button_editarEquipo);
            panel1.Controls.Add(button_agregarEquipo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(962, 23);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 430);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(-2, 170);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 11;
            button2.Text = "Histograma x fecha";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(-2, 211);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(136, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(-2, 191);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(136, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(-2, 146);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 7;
            button1.Text = "Histograma x vía";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 129);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "Gráficos";
            // 
            // button_agregarVia
            // 
            button_agregarVia.FlatAppearance.BorderColor = Color.Black;
            button_agregarVia.Location = new Point(-2, 104);
            button_agregarVia.Margin = new Padding(3, 2, 3, 2);
            button_agregarVia.Name = "button_agregarVia";
            button_agregarVia.Size = new Size(136, 23);
            button_agregarVia.TabIndex = 5;
            button_agregarVia.Text = "Agregar vía";
            button_agregarVia.UseVisualStyleBackColor = true;
            button_agregarVia.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 86);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "Vías";
            // 
            // button_eliminarEquipo
            // 
            button_eliminarEquipo.Location = new Point(-2, 60);
            button_eliminarEquipo.Margin = new Padding(3, 2, 3, 2);
            button_eliminarEquipo.Name = "button_eliminarEquipo";
            button_eliminarEquipo.Size = new Size(136, 24);
            button_eliminarEquipo.TabIndex = 3;
            button_eliminarEquipo.Text = "Eliminar equipo";
            button_eliminarEquipo.UseVisualStyleBackColor = true;
            button_eliminarEquipo.Click += button_eliminarEquipo_Click;
            // 
            // button_editarEquipo
            // 
            button_editarEquipo.Location = new Point(-2, 38);
            button_editarEquipo.Margin = new Padding(3, 2, 3, 2);
            button_editarEquipo.Name = "button_editarEquipo";
            button_editarEquipo.Size = new Size(136, 24);
            button_editarEquipo.TabIndex = 2;
            button_editarEquipo.Text = "Editar equipo";
            button_editarEquipo.UseVisualStyleBackColor = true;
            button_editarEquipo.Click += button_editarEquipo_Click;
            // 
            // button_agregarEquipo
            // 
            button_agregarEquipo.FlatAppearance.BorderColor = Color.Black;
            button_agregarEquipo.Location = new Point(-2, 17);
            button_agregarEquipo.Margin = new Padding(3, 2, 3, 2);
            button_agregarEquipo.Name = "button_agregarEquipo";
            button_agregarEquipo.Size = new Size(136, 23);
            button_agregarEquipo.TabIndex = 1;
            button_agregarEquipo.Text = "Agregar equipo";
            button_agregarEquipo.UseVisualStyleBackColor = true;
            button_agregarEquipo.Click += button_agregarEquipo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Equipos";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(520, 265);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView2.Size = new Size(424, 176);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(10, 42);
            formsPlot1.Margin = new Padding(3, 2, 3, 2);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(934, 176);
            formsPlot1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 249);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Equipos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(503, 242);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 8;
            label5.Text = "Vías";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 452);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(formsPlot1);
            Controls.Add(dataGridView2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(gMapControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Equipment Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem administraciónToolStripMenuItem;
        private ToolStripMenuItem nuevaEstaciónToolStripMenuItem;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button_agregarEquipo;
        private Label label1;
        private Button button_agregarVia;
        private Label label2;
        private Button button_eliminarEquipo;
        private Button button_editarEquipo;
        private DataGridView dataGridView2;
        private Label label3;
        private Button button1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
    }
}
