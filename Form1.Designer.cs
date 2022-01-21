
namespace Övning_4._3
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
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpara = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmÖppna = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStäng = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLäggTill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTaBort = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.redigeraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSpara,
            this.tsmÖppna,
            this.toolStripSeparator1,
            this.tsmStäng});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // tsmSpara
            // 
            this.tsmSpara.Name = "tsmSpara";
            this.tsmSpara.Size = new System.Drawing.Size(180, 22);
            this.tsmSpara.Text = "Spara";
            // 
            // tsmÖppna
            // 
            this.tsmÖppna.Name = "tsmÖppna";
            this.tsmÖppna.Size = new System.Drawing.Size(180, 22);
            this.tsmÖppna.Text = "Öppna";
            // 
            // tsmStäng
            // 
            this.tsmStäng.Name = "tsmStäng";
            this.tsmStäng.Size = new System.Drawing.Size(180, 22);
            this.tsmStäng.Text = "Stäng";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLäggTill,
            this.tsmTaBort});
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // tsmLäggTill
            // 
            this.tsmLäggTill.Name = "tsmLäggTill";
            this.tsmLäggTill.Size = new System.Drawing.Size(180, 22);
            this.tsmLäggTill.Text = "Lägg till";
            // 
            // tsmTaBort
            // 
            this.tsmTaBort.Name = "tsmTaBort";
            this.tsmTaBort.Size = new System.Drawing.Size(180, 22);
            this.tsmTaBort.Text = "Ta bort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSpara;
        private System.Windows.Forms.ToolStripMenuItem tsmÖppna;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmStäng;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmLäggTill;
        private System.Windows.Forms.ToolStripMenuItem tsmTaBort;
    }
}

