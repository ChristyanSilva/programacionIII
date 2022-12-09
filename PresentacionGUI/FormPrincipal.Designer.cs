namespace PresentacionGUI
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.conductoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarConductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarConductoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conductoresToolStripMenuItem
            // 
            this.conductoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarConductorToolStripMenuItem,
            this.consultarConductoresToolStripMenuItem});
            this.conductoresToolStripMenuItem.Name = "conductoresToolStripMenuItem";
            this.conductoresToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.conductoresToolStripMenuItem.Text = "Registro";
            // 
            // registrarConductorToolStripMenuItem
            // 
            this.registrarConductorToolStripMenuItem.Name = "registrarConductorToolStripMenuItem";
            this.registrarConductorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarConductorToolStripMenuItem.Text = "Registrar Conductor";
            this.registrarConductorToolStripMenuItem.Click += new System.EventHandler(this.registrarConductorToolStripMenuItem_Click);
            // 
            // consultarConductoresToolStripMenuItem
            // 
            this.consultarConductoresToolStripMenuItem.Name = "consultarConductoresToolStripMenuItem";
            this.consultarConductoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarConductoresToolStripMenuItem.Text = "Registrar Vehiculo";
            this.consultarConductoresToolStripMenuItem.Click += new System.EventHandler(this.consultarConductoresToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.salirToolStripMenuItem.Text = "Salir del programa";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conductoresToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::PresentacionGUI.Properties.Resources.Tax_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(494, 421);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax-Manager";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem conductoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarConductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarConductoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}