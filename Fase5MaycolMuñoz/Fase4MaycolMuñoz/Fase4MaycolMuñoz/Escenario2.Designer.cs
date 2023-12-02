namespace Fase4MaycolMuñoz
{
    partial class Escenario2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escenario2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gráficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.postorden = new System.Windows.Forms.Label();
            this.inorden = new System.Windows.Forms.Label();
            this.preorden = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficaToolStripMenuItem,
            this.recorridoToolStripMenuItem,
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gráficaToolStripMenuItem
            // 
            this.gráficaToolStripMenuItem.Name = "gráficaToolStripMenuItem";
            this.gráficaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.gráficaToolStripMenuItem.Text = "GRÁFICA";
            this.gráficaToolStripMenuItem.Click += new System.EventHandler(this.gráficaToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "location";
            // 
            // postorden
            // 
            this.postorden.AutoSize = true;
            this.postorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postorden.Location = new System.Drawing.Point(12, 364);
            this.postorden.Name = "postorden";
            this.postorden.Size = new System.Drawing.Size(342, 16);
            this.postorden.TabIndex = 9;
            this.postorden.Text = "Postorden:   9  14  12  19  23  17  67  54  76  72  50";
            this.postorden.Visible = false;
            // 
            // inorden
            // 
            this.inorden.AutoSize = true;
            this.inorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inorden.Location = new System.Drawing.Point(13, 339);
            this.inorden.Name = "inorden";
            this.inorden.Size = new System.Drawing.Size(319, 16);
            this.inorden.TabIndex = 8;
            this.inorden.Text = "Inorden:  9  12  14  17  19  23  50  54  67  72  76";
            this.inorden.Visible = false;
            // 
            // preorden
            // 
            this.preorden.AutoSize = true;
            this.preorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preorden.Location = new System.Drawing.Point(12, 313);
            this.preorden.Name = "preorden";
            this.preorden.Size = new System.Drawing.Size(331, 16);
            this.preorden.TabIndex = 7;
            this.preorden.Text = "Preorden:  50  17  12  9  14  23  19  72  54  67  76";
            this.preorden.Visible = false;
            // 
            // Escenario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 389);
            this.Controls.Add(this.postorden);
            this.Controls.Add(this.inorden);
            this.Controls.Add(this.preorden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Escenario2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escenario2";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Escenario2_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gráficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label postorden;
        private System.Windows.Forms.Label inorden;
        private System.Windows.Forms.Label preorden;
    }
}