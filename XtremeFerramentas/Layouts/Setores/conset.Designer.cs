namespace XtremeFerramentas
{
    partial class conset
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c1Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2Nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3Nfunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4Sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1Cod,
            this.c2Nm,
            this.c3Nfunc,
            this.c4Sup});
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // c1Cod
            // 
            this.c1Cod.HeaderText = "Código";
            this.c1Cod.Name = "c1Cod";
            // 
            // c2Nm
            // 
            this.c2Nm.HeaderText = "Nome";
            this.c2Nm.Name = "c2Nm";
            this.c2Nm.Width = 125;
            // 
            // c3Nfunc
            // 
            this.c3Nfunc.HeaderText = "Nº Funcionarios";
            this.c3Nfunc.Name = "c3Nfunc";
            // 
            // c4Sup
            // 
            this.c4Sup.HeaderText = "Supervisor";
            this.c4Sup.Name = "c4Sup";
            this.c4Sup.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o setor desejada e pressione F2:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(524, 27);
            this.toolStrip1.TabIndex = 55;
            this.toolStrip1.Text = "tsp_con";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::XtremeFerramentas.Properties.Resources.Voltar;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "tsb_vol";
            // 
            // conset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 381);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "conset";
            this.Text = "conset";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.conset_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2Nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3Nfunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4Sup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}