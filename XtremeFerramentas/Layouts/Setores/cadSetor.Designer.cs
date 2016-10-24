namespace XtremeFerramentas
{
    partial class cadSetor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_cod = new System.Windows.Forms.TextBox();
            this.txb_nom = new System.Windows.Forms.TextBox();
            this.cbb_sup = new System.Windows.Forms.ComboBox();
            this.tsp_cad = new System.Windows.Forms.ToolStrip();
            this.tsb_vol = new System.Windows.Forms.ToolStripButton();
            this.tsb_con = new System.Windows.Forms.ToolStripButton();
            this.tsb_exc = new System.Windows.Forms.ToolStripButton();
            this.tsp_cad.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do setor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supervisor:";
            // 
            // txb_cod
            // 
            this.txb_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cod.Location = new System.Drawing.Point(201, 99);
            this.txb_cod.Name = "txb_cod";
            this.txb_cod.Size = new System.Drawing.Size(189, 26);
            this.txb_cod.TabIndex = 4;
            // 
            // txb_nom
            // 
            this.txb_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nom.Location = new System.Drawing.Point(201, 138);
            this.txb_nom.Name = "txb_nom";
            this.txb_nom.Size = new System.Drawing.Size(189, 26);
            this.txb_nom.TabIndex = 5;
            // 
            // cbb_sup
            // 
            this.cbb_sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_sup.FormattingEnabled = true;
            this.cbb_sup.Location = new System.Drawing.Point(201, 174);
            this.cbb_sup.Name = "cbb_sup";
            this.cbb_sup.Size = new System.Drawing.Size(189, 28);
            this.cbb_sup.TabIndex = 10;
            // 
            // tsp_cad
            // 
            this.tsp_cad.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsp_cad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_vol,
            this.tsb_con,
            this.tsb_exc});
            this.tsp_cad.Location = new System.Drawing.Point(0, 0);
            this.tsp_cad.Name = "tsp_cad";
            this.tsp_cad.Size = new System.Drawing.Size(524, 27);
            this.tsp_cad.TabIndex = 55;
            this.tsp_cad.Text = "toolStrip1";
            // 
            // tsb_vol
            // 
            this.tsb_vol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_vol.Image = global::XtremeFerramentas.Properties.Resources.Voltar;
            this.tsb_vol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_vol.Name = "tsb_vol";
            this.tsb_vol.Size = new System.Drawing.Size(24, 24);
            this.tsb_vol.Text = "toolStripButton4";
            // 
            // tsb_con
            // 
            this.tsb_con.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_con.Image = global::XtremeFerramentas.Properties.Resources.Concluir;
            this.tsb_con.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_con.Name = "tsb_con";
            this.tsb_con.Size = new System.Drawing.Size(24, 24);
            this.tsb_con.Text = "toolStripButton1";
            // 
            // tsb_exc
            // 
            this.tsb_exc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_exc.Image = global::XtremeFerramentas.Properties.Resources.Cancelar;
            this.tsb_exc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_exc.Name = "tsb_exc";
            this.tsb_exc.Size = new System.Drawing.Size(24, 24);
            this.tsb_exc.Text = "toolStripButton2";
            // 
            // cadSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 381);
            this.Controls.Add(this.tsp_cad);
            this.Controls.Add(this.cbb_sup);
            this.Controls.Add(this.txb_nom);
            this.Controls.Add(this.txb_cod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cadSetor";
            this.Text = "Cadastrar um novo setor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cadSetor_FormClosed);
            this.tsp_cad.ResumeLayout(false);
            this.tsp_cad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_cod;
        private System.Windows.Forms.TextBox txb_nom;
        private System.Windows.Forms.ComboBox cbb_sup;
        private System.Windows.Forms.ToolStrip tsp_cad;
        private System.Windows.Forms.ToolStripButton tsb_vol;
        private System.Windows.Forms.ToolStripButton tsb_con;
        private System.Windows.Forms.ToolStripButton tsb_exc;
    }
}