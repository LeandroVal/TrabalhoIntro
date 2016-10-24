namespace XtremeFerramentas
{
    partial class ferrRemover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ferrRemover));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_set = new System.Windows.Forms.ComboBox();
            this.txb_cod = new System.Windows.Forms.TextBox();
            this.btn_rem = new System.Windows.Forms.Button();
            this.btn_vol = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // cbb_set
            // 
            this.cbb_set.FormattingEnabled = true;
            this.cbb_set.Location = new System.Drawing.Point(87, 39);
            this.cbb_set.Name = "cbb_set";
            this.cbb_set.Size = new System.Drawing.Size(479, 21);
            this.cbb_set.TabIndex = 3;
            // 
            // txb_cod
            // 
            this.txb_cod.Location = new System.Drawing.Point(87, 66);
            this.txb_cod.Name = "txb_cod";
            this.txb_cod.Size = new System.Drawing.Size(479, 20);
            this.txb_cod.TabIndex = 4;
            // 
            // btn_rem
            // 
            this.btn_rem.Location = new System.Drawing.Point(415, 108);
            this.btn_rem.Name = "btn_rem";
            this.btn_rem.Size = new System.Drawing.Size(151, 29);
            this.btn_rem.TabIndex = 5;
            this.btn_rem.Text = "Remover ferramenta";
            this.btn_rem.UseVisualStyleBackColor = true;
            // 
            // btn_vol
            // 
            this.btn_vol.Location = new System.Drawing.Point(15, 108);
            this.btn_vol.Name = "btn_vol";
            this.btn_vol.Size = new System.Drawing.Size(151, 29);
            this.btn_vol.TabIndex = 6;
            this.btn_vol.Text = "Voltar";
            this.btn_vol.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton1.Text = "Pesquisar";
            this.toolStripButton1.ToolTipText = "Pesquisar por uma  ferramenta específica.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ferrRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 149);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_vol);
            this.Controls.Add(this.btn_rem);
            this.Controls.Add(this.txb_cod);
            this.Controls.Add(this.cbb_set);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ferrRemover";
            this.Text = "ferrRemover";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_set;
        private System.Windows.Forms.TextBox txb_cod;
        private System.Windows.Forms.Button btn_rem;
        private System.Windows.Forms.Button btn_vol;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}