namespace Fase3MaycolMuñoz
{
    partial class LosMillenials
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LosMillenials));
            this.panel1 = new System.Windows.Forms.Panel();
            this.regresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eliminar = new System.Windows.Forms.Button();
            this.consutar = new System.Windows.Forms.Button();
            this.CTerapia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CCondicion = new System.Windows.Forms.ComboBox();
            this.guardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CEstrato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.CFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.regresar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 508);
            this.panel1.TabIndex = 0;
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.DarkGray;
            this.regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regresar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.regresar.Location = new System.Drawing.Point(76, 8);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(100, 29);
            this.regresar.TabIndex = 30;
            this.regresar.Text = "<-Regresar";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 171);
            this.dataGridView1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Navy;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(219, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Registrar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.eliminar);
            this.panel2.Controls.Add(this.consutar);
            this.panel2.Controls.Add(this.CTerapia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CCondicion);
            this.panel2.Controls.Add(this.guardar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CEstrato);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.CFecha);
            this.panel2.Location = new System.Drawing.Point(41, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 245);
            this.panel2.TabIndex = 13;
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.DarkGray;
            this.eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar.Enabled = false;
            this.eliminar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.eliminar.Location = new System.Drawing.Point(166, 213);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(100, 29);
            this.eliminar.TabIndex = 29;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // consutar
            // 
            this.consutar.BackColor = System.Drawing.Color.DarkGray;
            this.consutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consutar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consutar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.consutar.Location = new System.Drawing.Point(204, 42);
            this.consutar.Name = "consutar";
            this.consutar.Size = new System.Drawing.Size(89, 24);
            this.consutar.TabIndex = 28;
            this.consutar.Text = "Consultar";
            this.consutar.UseVisualStyleBackColor = false;
            this.consutar.Click += new System.EventHandler(this.consutar_Click);
            // 
            // CTerapia
            // 
            this.CTerapia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CTerapia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTerapia.FormattingEnabled = true;
            this.CTerapia.Items.AddRange(new object[] {
            "sí",
            "no"});
            this.CTerapia.Location = new System.Drawing.Point(308, 168);
            this.CTerapia.Name = "CTerapia";
            this.CTerapia.Size = new System.Drawing.Size(121, 23);
            this.CTerapia.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Necesita Terapia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Condición:";
            // 
            // CCondicion
            // 
            this.CCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCondicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCondicion.FormattingEnabled = true;
            this.CCondicion.Items.AddRange(new object[] {
            "autismo",
            "hyperactividad",
            "discapacidad"});
            this.CCondicion.Location = new System.Drawing.Point(308, 105);
            this.CCondicion.Name = "CCondicion";
            this.CCondicion.Size = new System.Drawing.Size(121, 23);
            this.CCondicion.TabIndex = 24;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.DarkGray;
            this.guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.guardar.Location = new System.Drawing.Point(311, 213);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(100, 29);
            this.guardar.TabIndex = 23;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Fecha de Nacimiento:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(20, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 21);
            this.txtNombre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre Completo:";
            // 
            // CEstrato
            // 
            this.CEstrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CEstrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEstrato.FormattingEnabled = true;
            this.CEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CEstrato.Location = new System.Drawing.Point(308, 38);
            this.CEstrato.Name = "CEstrato";
            this.CEstrato.Size = new System.Drawing.Size(121, 23);
            this.CEstrato.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registro Civil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estrato:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(20, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(182, 21);
            this.txtId.TabIndex = 5;
            // 
            // CFecha
            // 
            this.CFecha.Location = new System.Drawing.Point(23, 171);
            this.CFecha.Name = "CFecha";
            this.CFecha.Size = new System.Drawing.Size(222, 20);
            this.CFecha.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(177, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Los Millenials";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LosMillenials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 503);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LosMillenials";
            this.Text = "LosMillenials";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CEstrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker CFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CCondicion;
        private System.Windows.Forms.ComboBox CTerapia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button consutar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button regresar;
    }
}