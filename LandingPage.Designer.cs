namespace CatAsAService
{
    partial class landingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landingPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarRaçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusFavoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.TextBox();
            this.Image = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarRaçasToolStripMenuItem,
            this.meusFavoritosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buscarRaçasToolStripMenuItem
            // 
            this.buscarRaçasToolStripMenuItem.Name = "buscarRaçasToolStripMenuItem";
            this.buscarRaçasToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.buscarRaçasToolStripMenuItem.Text = "Buscar Raças";
            this.buscarRaçasToolStripMenuItem.Click += new System.EventHandler(this.buscarRaçasToolStripMenuItem_Click);
            // 
            // meusFavoritosToolStripMenuItem
            // 
            this.meusFavoritosToolStripMenuItem.Name = "meusFavoritosToolStripMenuItem";
            this.meusFavoritosToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.meusFavoritosToolStripMenuItem.Text = "Meus Favoritos";
            this.meusFavoritosToolStripMenuItem.Click += new System.EventHandler(this.meusFavoritosToolStripMenuItem_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(0, 570);
            this.Title.Margin = new System.Windows.Forms.Padding(30);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(800, 30);
            this.Title.TabIndex = 2;
            this.Title.Text = "Bem vindo ao Cat as Service";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Image
            // 
            this.Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image.Image = global::CatAsAService.Properties.Resources.gato_preto__2_;
            this.Image.Location = new System.Drawing.Point(0, 33);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(800, 567);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            this.Image.Tag = "Bem vindo ao Cat as Service";
            this.Image.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // landingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "landingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem vindo ao Cat As Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarRaçasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusFavoritosToolStripMenuItem;
        private System.Windows.Forms.TextBox Title;
    }
}

