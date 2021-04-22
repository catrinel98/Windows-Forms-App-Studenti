
namespace tests1
{
    partial class Form2
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
            this.tbCandidati = new System.Windows.Forms.TextBox();
            this.button1salvare = new System.Windows.Forms.Button();
            this.butoncitire = new System.Windows.Forms.Button();
            this.serializare = new System.Windows.Forms.Button();
            this.button1deserializare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vizualizareArboreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbprofilmaster = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vizualizareListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCandidati
            // 
            this.tbCandidati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCandidati.Location = new System.Drawing.Point(32, 61);
            this.tbCandidati.Multiline = true;
            this.tbCandidati.Name = "tbCandidati";
            this.tbCandidati.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCandidati.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCandidati.Size = new System.Drawing.Size(371, 201);
            this.tbCandidati.TabIndex = 0;
            this.tbCandidati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCandidati.TextChanged += new System.EventHandler(this.tbCandidati_TextChanged);
            // 
            // button1salvare
            // 
            this.button1salvare.Location = new System.Drawing.Point(73, 354);
            this.button1salvare.Name = "button1salvare";
            this.button1salvare.Size = new System.Drawing.Size(75, 23);
            this.button1salvare.TabIndex = 1;
            this.button1salvare.Text = "Salvare";
            this.button1salvare.UseVisualStyleBackColor = true;
            this.button1salvare.Click += new System.EventHandler(this.button1_Click);
            // 
            // butoncitire
            // 
            this.butoncitire.Location = new System.Drawing.Point(207, 354);
            this.butoncitire.Name = "butoncitire";
            this.butoncitire.Size = new System.Drawing.Size(75, 23);
            this.butoncitire.TabIndex = 2;
            this.butoncitire.Text = "Citire";
            this.butoncitire.UseVisualStyleBackColor = true;
            this.butoncitire.Click += new System.EventHandler(this.butoncitire_Click);
            // 
            // serializare
            // 
            this.serializare.Location = new System.Drawing.Point(344, 354);
            this.serializare.Name = "serializare";
            this.serializare.Size = new System.Drawing.Size(102, 38);
            this.serializare.TabIndex = 3;
            this.serializare.Text = "serializare";
            this.serializare.UseVisualStyleBackColor = true;
            this.serializare.Click += new System.EventHandler(this.serializare_Click);
            // 
            // button1deserializare
            // 
            this.button1deserializare.Location = new System.Drawing.Point(484, 354);
            this.button1deserializare.Name = "button1deserializare";
            this.button1deserializare.Size = new System.Drawing.Size(101, 30);
            this.button1deserializare.TabIndex = 4;
            this.button1deserializare.Text = "deserializare";
            this.button1deserializare.UseVisualStyleBackColor = true;
            this.button1deserializare.Click += new System.EventHandler(this.button1deserializare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Varsta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareArboreToolStripMenuItem,
            this.vizualizareListaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vizualizareArboreToolStripMenuItem
            // 
            this.vizualizareArboreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licentaToolStripMenuItem,
            this.masterToolStripMenuItem});
            this.vizualizareArboreToolStripMenuItem.Name = "vizualizareArboreToolStripMenuItem";
            this.vizualizareArboreToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.vizualizareArboreToolStripMenuItem.Text = "Vizualizare Arbore";
            this.vizualizareArboreToolStripMenuItem.Click += new System.EventHandler(this.vizualizareArboreToolStripMenuItem_Click);
            // 
            // licentaToolStripMenuItem
            // 
            this.licentaToolStripMenuItem.Name = "licentaToolStripMenuItem";
            this.licentaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.licentaToolStripMenuItem.Text = "Licenta";
            this.licentaToolStripMenuItem.Click += new System.EventHandler(this.licentaToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.masterToolStripMenuItem.Text = "Master";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.masterToolStripMenuItem_Click);
            // 
            // tbprofilmaster
            // 
            this.tbprofilmaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbprofilmaster.Location = new System.Drawing.Point(417, 61);
            this.tbprofilmaster.Multiline = true;
            this.tbprofilmaster.Name = "tbprofilmaster";
            this.tbprofilmaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbprofilmaster.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbprofilmaster.Size = new System.Drawing.Size(371, 201);
            this.tbprofilmaster.TabIndex = 9;
            this.tbprofilmaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Varsta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Profil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(723, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Profil";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // vizualizareListaToolStripMenuItem
            // 
            this.vizualizareListaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licentaToolStripMenuItem1,
            this.masterToolStripMenuItem1});
            this.vizualizareListaToolStripMenuItem.Name = "vizualizareListaToolStripMenuItem";
            this.vizualizareListaToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.vizualizareListaToolStripMenuItem.Text = "Vizualizare lista";
            // 
            // licentaToolStripMenuItem1
            // 
            this.licentaToolStripMenuItem1.Name = "licentaToolStripMenuItem1";
            this.licentaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.licentaToolStripMenuItem1.Text = "Licenta";
            this.licentaToolStripMenuItem1.Click += new System.EventHandler(this.licentaToolStripMenuItem1_Click);
            // 
            // masterToolStripMenuItem1
            // 
            this.masterToolStripMenuItem1.Name = "masterToolStripMenuItem1";
            this.masterToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.masterToolStripMenuItem1.Text = "Master";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbprofilmaster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1deserializare);
            this.Controls.Add(this.serializare);
            this.Controls.Add(this.butoncitire);
            this.Controls.Add(this.button1salvare);
            this.Controls.Add(this.tbCandidati);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCandidati;
        private System.Windows.Forms.Button button1salvare;
        private System.Windows.Forms.Button butoncitire;
        private System.Windows.Forms.Button serializare;
        private System.Windows.Forms.Button button1deserializare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizualizareArboreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.TextBox tbprofilmaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem vizualizareListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem1;
    }
}