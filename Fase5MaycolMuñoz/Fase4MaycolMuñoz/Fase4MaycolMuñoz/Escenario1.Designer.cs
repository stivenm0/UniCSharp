namespace Fase4MaycolMuñoz
{
    partial class Escenario1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escenario1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gráficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preorden = new System.Windows.Forms.Label();
            this.inorden = new System.Windows.Forms.Label();
            this.postorden = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "location";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficaToolStripMenuItem,
            this.recorridoToolStripMenuItem,
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gráficaToolStripMenuItem
            // 
            this.gráficaToolStripMenuItem.Name = "gráficaToolStripMenuItem";
            this.gráficaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.gráficaToolStripMenuItem.Text = "GRÁFICA";
            this.gráficaToolStripMenuItem.Click += new System.EventHandler(this.gráficaToolStripMenuItem_Click_1);
            // 
            // recorridoToolStripMenuItem
            // 
            this.recorridoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preordenToolStripMenuItem,
            this.inordenToolStripMenuItem,
            this.posordenToolStripMenuItem});
            this.recorridoToolStripMenuItem.Name = "recorridoToolStripMenuItem";
            this.recorridoToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.recorridoToolStripMenuItem.Text = "RECORRIDOS";
            // 
            // preordenToolStripMenuItem
            // 
            this.preordenToolStripMenuItem.Name = "preordenToolStripMenuItem";
            this.preordenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.preordenToolStripMenuItem.Text = "Preorden";
            this.preordenToolStripMenuItem.Click += new System.EventHandler(this.preordenToolStripMenuItem_Click);
            // 
            // inordenToolStripMenuItem
            // 
            this.inordenToolStripMenuItem.Name = "inordenToolStripMenuItem";
            this.inordenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.inordenToolStripMenuItem.Text = "Inorden";
            this.inordenToolStripMenuItem.Click += new System.EventHandler(this.inordenToolStripMenuItem_Click);
            // 
            // posordenToolStripMenuItem
            // 
            this.posordenToolStripMenuItem.Name = "posordenToolStripMenuItem";
            this.posordenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.posordenToolStripMenuItem.Text = "PostOrden";
            this.posordenToolStripMenuItem.Click += new System.EventHandler(this.posordenToolStripMenuItem_Click);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.regresarToolStripMenuItem.Text = "REGRESAR";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click_1);
            // 
            // preorden
            // 
            this.preorden.AutoSize = true;
            this.preorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preorden.Location = new System.Drawing.Point(6, 339);
            this.preorden.Name = "preorden";
            this.preorden.Size = new System.Drawing.Size(399, 16);
            this.preorden.TabIndex = 4;
            this.preorden.Text = "Preorden: 70  20  15  10  2  59  29  69  98  77  75  91  78  86";
            this.preorden.Visible = false;
            // 
            // inorden
            // 
            this.inorden.AutoSize = true;
            this.inorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inorden.Location = new System.Drawing.Point(7, 365);
            this.inorden.Name = "inorden";
            this.inorden.Size = new System.Drawing.Size(391, 16);
            this.inorden.TabIndex = 5;
            this.inorden.Text = "Inorden:  2  10  15  20  29  59  69  70  75  77  78  86  91  98";
            this.inorden.Visible = false;
            // 
            // postorden
            // 
            this.postorden.AutoSize = true;
            this.postorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postorden.Location = new System.Drawing.Point(6, 390);
            this.postorden.Name = "postorden";
            this.postorden.Size = new System.Drawing.Size(406, 16);
            this.postorden.TabIndex = 6;
            this.postorden.Text = "Postorden: 2  10  15  20  29  69  59  75  86  78  91 77   98  70";
            this.postorden.Visible = false;
            // 
            // Escenario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(498, 415);
            this.Controls.Add(this.postorden);
            this.Controls.Add(this.inorden);
            this.Controls.Add(this.preorden);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Escenario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escenario1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Escenario1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gráficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.Label preorden;
        private System.Windows.Forms.Label inorden;
        private System.Windows.Forms.Label postorden;
    }
}