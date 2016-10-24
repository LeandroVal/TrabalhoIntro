namespace XtremeFerramentas
{
    partial class ExcSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.tsp_exc = new System.Windows.Forms.ToolStrip();
            this.tsb_vol = new System.Windows.Forms.ToolStripButton();
            this.tsb_con = new System.Windows.Forms.ToolStripButton();
            this.tsb_exc = new System.Windows.Forms.ToolStripButton();
            this.tsb_pes = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tsp_exc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 107;
            this.label1.Text = "Lista de exclusão:";
            // 
            // tsp_exc
            // 
            this.tsp_exc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsp_exc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_vol,
            this.tsb_con,
            this.tsb_exc,
            this.tsb_pes});
            this.tsp_exc.Location = new System.Drawing.Point(0, 0);
            this.tsp_exc.Name = "tsp_exc";
            this.tsp_exc.Size = new System.Drawing.Size(524, 27);
            this.tsp_exc.TabIndex = 106;
            this.tsp_exc.Text = "tsp_exc";
            // 
            // tsb_vol
            // 
            this.tsb_vol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_vol.Image = global::XtremeFerramentas.Properties.Resources.Voltar;
            this.tsb_vol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_vol.Name = "tsb_vol";
            this.tsb_vol.Size = new System.Drawing.Size(24, 24);
            this.tsb_vol.Text = "tsb_vol";
            // 
            // tsb_con
            // 
            this.tsb_con.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_con.Image = global::XtremeFerramentas.Properties.Resources.Concluir;
            this.tsb_con.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_con.Name = "tsb_con";
            this.tsb_con.Size = new System.Drawing.Size(24, 24);
            this.tsb_con.Text = "tsb_con";
            // 
            // tsb_exc
            // 
            this.tsb_exc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_exc.Image = global::XtremeFerramentas.Properties.Resources.Cancelar;
            this.tsb_exc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_exc.Name = "tsb_exc";
            this.tsb_exc.Size = new System.Drawing.Size(24, 24);
            this.tsb_exc.Text = "Cancelar";
            // 
            // tsb_pes
            // 
            this.tsb_pes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_pes.Image = global::XtremeFerramentas.Properties.Resources.Buscar;
            this.tsb_pes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_pes.Name = "tsb_pes";
            this.tsb_pes.Size = new System.Drawing.Size(24, 24);
            this.tsb_pes.Text = "toolStripButton3";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(506, 243);
            this.dataGridView2.TabIndex = 105;
            // 
            // ExcSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsp_exc);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ExcSet";
            this.Text = "ExcSet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExcSet_FormClosed);
            this.tsp_exc.ResumeLayout(false);
            this.tsp_exc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsp_exc;
        private System.Windows.Forms.ToolStripButton tsb_vol;
        private System.Windows.Forms.ToolStripButton tsb_con;
        private System.Windows.Forms.ToolStripButton tsb_exc;
        private System.Windows.Forms.ToolStripButton tsb_pes;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}