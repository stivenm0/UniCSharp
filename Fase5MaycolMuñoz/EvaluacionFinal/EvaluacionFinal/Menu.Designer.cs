namespace EvaluacionFinal
{
    partial class Menu
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
            this.exit = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkRed;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.exit.Location = new System.Drawing.Point(136, 220);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(91, 33);
            this.exit.TabIndex = 5;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dos
            // 
            this.dos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.dos.Location = new System.Drawing.Point(136, 51);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(91, 33);
            this.dos.TabIndex = 6;
            this.dos.Text = "Fase 2";
            this.dos.UseVisualStyleBackColor = false;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tres.Location = new System.Drawing.Point(136, 106);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(91, 33);
            this.tres.TabIndex = 7;
            this.tres.Text = "Fase 3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // cuatro
            // 
            this.cuatro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuatro.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cuatro.Location = new System.Drawing.Point(136, 162);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(91, 33);
            this.cuatro.TabIndex = 8;
            this.cuatro.Text = "Fase 4";
            this.cuatro.UseVisualStyleBackColor = false;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(362, 311);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.exit);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button cuatro;
    }
}