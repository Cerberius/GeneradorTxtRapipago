namespace GeneradorTxtRapipago
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarFormulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.credito_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vencimiento_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vencimiento_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuota_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuota_cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarFormulariosToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.inicioToolStripMenuItem.Text = "Archivo";
            // 
            // limpiarFormulariosToolStripMenuItem
            // 
            this.limpiarFormulariosToolStripMenuItem.Name = "limpiarFormulariosToolStripMenuItem";
            this.limpiarFormulariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limpiarFormulariosToolStripMenuItem.Text = "Limpiar Formularios";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "LONGCRED";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.credito_nro,
            this.cliente_nro,
            this.cliente_nombre,
            this.fecha_vencimiento,
            this.importe_1,
            this.fecha_vencimiento_2,
            this.importe_2,
            this.fecha_vencimiento_3,
            this.importe_3,
            this.cuota_nro,
            this.cuota_cant});
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(918, 323);
            this.dataGridView1.TabIndex = 2;
            // 
            // credito_nro
            // 
            this.credito_nro.HeaderText = "Nro. de Crédito";
            this.credito_nro.Name = "credito_nro";
            // 
            // cliente_nro
            // 
            this.cliente_nro.HeaderText = "Nro. Cliente";
            this.cliente_nro.Name = "cliente_nro";
            // 
            // cliente_nombre
            // 
            this.cliente_nombre.HeaderText = "Nombre Cliente";
            this.cliente_nombre.Name = "cliente_nombre";
            // 
            // fecha_vencimiento
            // 
            this.fecha_vencimiento.HeaderText = "Fecha Vencimiento #1";
            this.fecha_vencimiento.Name = "fecha_vencimiento";
            // 
            // importe_1
            // 
            this.importe_1.HeaderText = "Importe #1";
            this.importe_1.Name = "importe_1";
            // 
            // fecha_vencimiento_2
            // 
            this.fecha_vencimiento_2.HeaderText = "Fecha Vencimiento #2";
            this.fecha_vencimiento_2.Name = "fecha_vencimiento_2";
            // 
            // importe_2
            // 
            this.importe_2.HeaderText = "Importe #2";
            this.importe_2.Name = "importe_2";
            // 
            // fecha_vencimiento_3
            // 
            this.fecha_vencimiento_3.HeaderText = "Fecha Vencimiento #3";
            this.fecha_vencimiento_3.Name = "fecha_vencimiento_3";
            // 
            // importe_3
            // 
            this.importe_3.HeaderText = "Importe #3";
            this.importe_3.Name = "importe_3";
            // 
            // cuota_nro
            // 
            this.cuota_nro.HeaderText = "Cuota Nro.";
            this.cuota_nro.Name = "cuota_nro";
            // 
            // cuota_cant
            // 
            this.cuota_cant.HeaderText = "Cant. Cuotas";
            this.cuota_cant.Name = "cuota_cant";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(854, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generar Txt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Generador Txt Rapipago";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarFormulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn credito_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vencimiento_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vencimiento_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuota_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuota_cant;
        private System.Windows.Forms.Button button1;
    }
}

