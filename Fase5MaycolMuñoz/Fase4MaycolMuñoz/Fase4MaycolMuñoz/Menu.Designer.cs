namespace Fase4MaycolMuñoz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.scn2 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.scn1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.scn2);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.scn1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 101);
            this.panel1.TabIndex = 0;
            // 
            // scn2
            // 
            this.scn2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.scn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scn2.Location = new System.Drawing.Point(199, 15);
            this.scn2.Name = "scn2";
            this.scn2.Size = new System.Drawing.Size(116, 23);
            this.scn2.TabIndex = 2;
            this.scn2.Text = "ESCENARIO 2";
            this.scn2.UseVisualStyleBackColor = false;
            this.scn2.Click += new System.EventHandler(this.scn2_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.IndianRed;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.Location = new System.Drawing.Point(106, 66);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "SALIR";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // scn1
            // 
            this.scn1.BackColor = System.Drawing.Color.OrangeRed;
            this.scn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scn1.Location = new System.Drawing.Point(12, 15);
            this.scn1.Name = "scn1";
            this.scn1.Size = new System.Drawing.Size(116, 23);
            this.scn1.TabIndex = 0;
            this.scn1.Text = "ESCENARIO 1";
            this.scn1.UseVisualStyleBackColor = false;
            this.scn1.Click += new System.EventHandler(this.scn1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 98);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button scn2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button scn1;
    }
}