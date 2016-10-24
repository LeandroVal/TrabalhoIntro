namespace XtremeFerramentas
{
    partial class conFerramenta
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.txb_tip = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c1Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_dis = new System.Windows.Forms.TextBox();
            this.txb_dan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(524, 27);
            this.toolStrip1.TabIndex = 52;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::XtremeFerramentas.Properties.Resources.Voltar;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // txb_tip
            // 
            this.txb_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tip.Location = new System.Drawing.Point(76, 44);
            this.txb_tip.Name = "txb_tip";
            this.txb_tip.Size = new System.Drawing.Size(164, 26);
            this.txb_tip.TabIndex = 53;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1Num,
            this.c2Est,
            this.c3Data,
            this.c4Loc});
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 240);
            this.dataGridView1.TabIndex = 54;
            // 
            // c1Num
            // 
            this.c1Num.HeaderText = "Numeração";
            this.c1Num.Name = "c1Num";
            // 
            // c2Est
            // 
            this.c2Est.HeaderText = "Estado";
            this.c2Est.Name = "c2Est";
            // 
            // c3Data
            // 
            this.c3Data.HeaderText = "Aquisição";
            this.c3Data.Name = "c3Data";
            // 
            // c4Loc
            // 
            this.c4Loc.HeaderText = "Localização";
            this.c4Loc.Name = "c4Loc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Total Disponível:";
            // 
            // txb_dis
            // 
            this.txb_dis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_dis.Location = new System.Drawing.Point(160, 88);
            this.txb_dis.Name = "txb_dis";
            this.txb_dis.Size = new System.Drawing.Size(45, 26);
            this.txb_dis.TabIndex = 56;
            // 
            // txb_dan
            // 
            this.txb_dan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_dan.Location = new System.Drawing.Point(380, 88);
            this.txb_dan.Name = "txb_dan";
            this.txb_dan.Size = new System.Drawing.Size(45, 26);
            this.txb_dan.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Total Danificadas:";
            // 
            // conFerramenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(524, 381);
            this.Controls.Add(this.txb_dan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_dis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txb_tip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "conFerramenta";
            this.Text = "conFerramenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.conFerramenta_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox txb_tip;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4Loc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_dis;
        private System.Windows.Forms.TextBox txb_dan;
        private System.Windows.Forms.Label label3;
    }
}