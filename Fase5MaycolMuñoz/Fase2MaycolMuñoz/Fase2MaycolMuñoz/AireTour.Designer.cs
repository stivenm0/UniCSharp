namespace Fase2MaycolMuñoz
{
    partial class AireTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AireTour));
            this.panel1 = new System.Windows.Forms.Panel();
            this.precio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.genero = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.Button();
            this.destino = new System.Windows.Forms.ComboBox();
            this.dia = new System.Windows.Forms.ComboBox();
            this.clase = new System.Windows.Forms.ComboBox();
            this.estrato = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.precio);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.genero);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.r);
            this.panel1.Controls.Add(this.destino);
            this.panel1.Controls.Add(this.dia);
            this.panel1.Controls.Add(this.clase);
            this.panel1.Controls.Add(this.estrato);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 426);
            this.panel1.TabIndex = 0;
            // 
            // precio
            // 
            this.precio.Enabled = false;
            this.precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(198, 328);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(208, 26);
            this.precio.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Location = new System.Drawing.Point(122, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Precio: ";
            // 
            // genero
            // 
            this.genero.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero.FormattingEnabled = true;
            this.genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "otro"});
            this.genero.Location = new System.Drawing.Point(198, 128);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(208, 25);
            this.genero.TabIndex = 12;
            this.genero.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(115, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Genero: ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(348, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 26);
            this.button3.TabIndex = 30;
            this.button3.Text = "Salir ❌";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(183, 379);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 26);
            this.btnCalcular.TabIndex = 26;
            this.btnCalcular.Text = "Calcular 🞑";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // r
            // 
            this.r.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.r.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(36, 379);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(94, 26);
            this.r.TabIndex = 24;
            this.r.Text = "Registrar !";
            this.r.UseVisualStyleBackColor = false;
            this.r.Click += new System.EventHandler(this.button1_Click);
            // 
            // destino
            // 
            this.destino.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destino.FormattingEnabled = true;
            this.destino.Items.AddRange(new object[] {
            "Bogotá",
            "Medellín",
            "Florencia ",
            "Pitalito"});
            this.destino.Location = new System.Drawing.Point(198, 207);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(208, 25);
            this.destino.TabIndex = 15;
            this.destino.Tag = "";
            // 
            // dia
            // 
            this.dia.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dia.FormattingEnabled = true;
            this.dia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.dia.Location = new System.Drawing.Point(198, 286);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(208, 25);
            this.dia.TabIndex = 20;
            this.dia.Tag = "";
            // 
            // clase
            // 
            this.clase.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clase.FormattingEnabled = true;
            this.clase.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.clase.Location = new System.Drawing.Point(198, 245);
            this.clase.Name = "clase";
            this.clase.Size = new System.Drawing.Size(208, 25);
            this.clase.TabIndex = 18;
            this.clase.Tag = "";
            // 
            // estrato
            // 
            this.estrato.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estrato.FormattingEnabled = true;
            this.estrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.estrato.Location = new System.Drawing.Point(198, 167);
            this.estrato.Name = "estrato";
            this.estrato.Size = new System.Drawing.Size(208, 25);
            this.estrato.TabIndex = 14;
            this.estrato.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Location = new System.Drawing.Point(142, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Día: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(125, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Clase: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(108, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Destino: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(115, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estrato: ";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(198, 91);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(208, 20);
            this.nombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(31, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Completo: ";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(198, 56);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(208, 20);
            this.id.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(55, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Identificación: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bienvenid@ al Sistema";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // AireTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 417);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AireTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AireTour";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox estrato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button r;
        private System.Windows.Forms.ComboBox destino;
        private System.Windows.Forms.ComboBox dia;
        private System.Windows.Forms.ComboBox clase;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox genero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label9;
    }
}