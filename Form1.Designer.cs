
namespace Övning_4._3
{
    partial class Form
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmStäng = new System.Windows.Forms.ToolStripMenuItem();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLäggTill = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTaBort = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxKontakter = new System.Windows.Forms.ListBox();
            this.dlgÖppnaFil = new System.Windows.Forms.OpenFileDialog();
            this.dlgSparaFil = new System.Windows.Forms.SaveFileDialog();
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
            this.menuStrip1.Size = new System.Drawing.Size(311, 24);
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
            this.tsmSpara.Size = new System.Drawing.Size(110, 22);
            this.tsmSpara.Text = "Spara";
            this.tsmSpara.Click += new System.EventHandler(this.tsmSpara_Click);
            // 
            // tsmÖppna
            // 
            this.tsmÖppna.Name = "tsmÖppna";
            this.tsmÖppna.Size = new System.Drawing.Size(110, 22);
            this.tsmÖppna.Text = "Öppna";
            this.tsmÖppna.Click += new System.EventHandler(this.tsmÖppna_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
            // 
            // tsmStäng
            // 
            this.tsmStäng.Name = "tsmStäng";
            this.tsmStäng.Size = new System.Drawing.Size(110, 22);
            this.tsmStäng.Text = "Stäng";
            this.tsmStäng.Click += new System.EventHandler(this.tsmStäng_Click);
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
            this.tsmLäggTill.Click += new System.EventHandler(this.tsmLäggTill_Click);
            // 
            // tsmTaBort
            // 
            this.tsmTaBort.Name = "tsmTaBort";
            this.tsmTaBort.Size = new System.Drawing.Size(180, 22);
            this.tsmTaBort.Text = "Ta bort";
            this.tsmTaBort.Click += new System.EventHandler(this.tsmTaBort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Förnamn";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(99, 43);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(201, 20);
            this.tbxFörnamn.TabIndex = 2;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(99, 69);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(201, 20);
            this.tbxEfternamn.TabIndex = 3;
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(99, 95);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(201, 20);
            this.tbxMail.TabIndex = 4;
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(99, 121);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(201, 20);
            this.tbxTelefon.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon";
            // 
            // lbxKontakter
            // 
            this.lbxKontakter.FormattingEnabled = true;
            this.lbxKontakter.Location = new System.Drawing.Point(12, 162);
            this.lbxKontakter.Name = "lbxKontakter";
            this.lbxKontakter.Size = new System.Drawing.Size(288, 108);
            this.lbxKontakter.TabIndex = 9;
            this.lbxKontakter.SelectedIndexChanged += new System.EventHandler(this.lbxKontakter_SelectedIndexChanged);
            // 
            // dlgÖppnaFil
            // 
            this.dlgÖppnaFil.FileName = "openFileDialog1";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 280);
            this.Controls.Add(this.lbxKontakter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "En kontakt";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxKontakter;
        private System.Windows.Forms.OpenFileDialog dlgÖppnaFil;
        private System.Windows.Forms.SaveFileDialog dlgSparaFil;
    }
}

