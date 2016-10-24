namespace XtremeFerramentas
{
    partial class ConFer
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_tip = new System.Windows.Forms.CheckBox();
            this.cbx_fer = new System.Windows.Forms.CheckBox();
            this.grb_opc = new System.Windows.Forms.GroupBox();
            this.grb_aca = new System.Windows.Forms.GroupBox();
            this.rbn_exp = new System.Windows.Forms.RadioButton();
            this.rbn_tra = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_loc = new System.Windows.Forms.ComboBox();
            this.cbb_est = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_fab = new System.Windows.Forms.ComboBox();
            this.cbb_tip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_opc.SuspendLayout();
            this.grb_aca.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a ferramenta desejada e pressione F2:";
            // 
            // cbx_tip
            // 
            this.cbx_tip.AutoSize = true;
            this.cbx_tip.Checked = true;
            this.cbx_tip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tip.Location = new System.Drawing.Point(18, 28);
            this.cbx_tip.Name = "cbx_tip";
            this.cbx_tip.Size = new System.Drawing.Size(58, 24);
            this.cbx_tip.TabIndex = 2;
            this.cbx_tip.Text = "Tipo";
            this.cbx_tip.UseVisualStyleBackColor = true;
            this.cbx_tip.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbx_fer
            // 
            this.cbx_fer.AutoSize = true;
            this.cbx_fer.Checked = true;
            this.cbx_fer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_fer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fer.Location = new System.Drawing.Point(18, 47);
            this.cbx_fer.Name = "cbx_fer";
            this.cbx_fer.Size = new System.Drawing.Size(111, 24);
            this.cbx_fer.TabIndex = 3;
            this.cbx_fer.Text = "Ferramenta";
            this.cbx_fer.UseVisualStyleBackColor = true;
            // 
            // grb_opc
            // 
            this.grb_opc.Controls.Add(this.cbx_tip);
            this.grb_opc.Controls.Add(this.cbx_fer);
            this.grb_opc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_opc.Location = new System.Drawing.Point(545, 32);
            this.grb_opc.Name = "grb_opc";
            this.grb_opc.Size = new System.Drawing.Size(208, 86);
            this.grb_opc.TabIndex = 4;
            this.grb_opc.TabStop = false;
            this.grb_opc.Text = "Opções de Seleção";
            // 
            // grb_aca
            // 
            this.grb_aca.Controls.Add(this.rbn_exp);
            this.grb_aca.Controls.Add(this.rbn_tra);
            this.grb_aca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grb_aca.Location = new System.Drawing.Point(771, 32);
            this.grb_aca.Name = "grb_aca";
            this.grb_aca.Size = new System.Drawing.Size(200, 86);
            this.grb_aca.TabIndex = 5;
            this.grb_aca.TabStop = false;
            this.grb_aca.Text = "Ação";
            // 
            // rbn_exp
            // 
            this.rbn_exp.AutoSize = true;
            this.rbn_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_exp.Location = new System.Drawing.Point(10, 47);
            this.rbn_exp.Name = "rbn_exp";
            this.rbn_exp.Size = new System.Drawing.Size(157, 24);
            this.rbn_exp.TabIndex = 1;
            this.rbn_exp.TabStop = true;
            this.rbn_exp.Text = "Expandir Detalhes";
            this.rbn_exp.UseVisualStyleBackColor = true;
            // 
            // rbn_tra
            // 
            this.rbn_tra.AutoSize = true;
            this.rbn_tra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_tra.Location = new System.Drawing.Point(10, 26);
            this.rbn_tra.Name = "rbn_tra";
            this.rbn_tra.Size = new System.Drawing.Size(189, 24);
            this.rbn_tra.TabIndex = 0;
            this.rbn_tra.TabStop = true;
            this.rbn_tra.Text = "Transpassar Conteúdo";
            this.rbn_tra.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbb_loc);
            this.groupBox3.Controls.Add(this.cbb_est);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbb_fab);
            this.groupBox3.Controls.Add(this.cbb_tip);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 86);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Localização:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado:";
            // 
            // cbb_loc
            // 
            this.cbb_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_loc.FormattingEnabled = true;
            this.cbb_loc.Location = new System.Drawing.Point(356, 52);
            this.cbb_loc.Name = "cbb_loc";
            this.cbb_loc.Size = new System.Drawing.Size(121, 23);
            this.cbb_loc.TabIndex = 12;
            // 
            // cbb_est
            // 
            this.cbb_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_est.FormattingEnabled = true;
            this.cbb_est.Location = new System.Drawing.Point(356, 23);
            this.cbb_est.Name = "cbb_est";
            this.cbb_est.Size = new System.Drawing.Size(121, 23);
            this.cbb_est.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fabricante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo:";
            // 
            // cbb_fab
            // 
            this.cbb_fab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_fab.FormattingEnabled = true;
            this.cbb_fab.Location = new System.Drawing.Point(104, 52);
            this.cbb_fab.Name = "cbb_fab";
            this.cbb_fab.Size = new System.Drawing.Size(121, 23);
            this.cbb_fab.TabIndex = 8;
            // 
            // cbb_tip
            // 
            this.cbb_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tip.FormattingEnabled = true;
            this.cbb_tip.Location = new System.Drawing.Point(104, 23);
            this.cbb_tip.Name = "cbb_tip";
            this.cbb_tip.Size = new System.Drawing.Size(121, 23);
            this.cbb_tip.TabIndex = 7;
            // 
            // ConFer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grb_aca);
            this.Controls.Add(this.grb_opc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "ConFer";
            this.Text = "ConFer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConFer_FormClosed);
            this.Load += new System.EventHandler(this.ConFer_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConFer_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb_opc.ResumeLayout(false);
            this.grb_opc.PerformLayout();
            this.grb_aca.ResumeLayout(false);
            this.grb_aca.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbx_tip;
        private System.Windows.Forms.CheckBox cbx_fer;
        private System.Windows.Forms.GroupBox grb_opc;
        private System.Windows.Forms.GroupBox grb_aca;
        private System.Windows.Forms.RadioButton rbn_exp;
        private System.Windows.Forms.RadioButton rbn_tra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_fab;
        private System.Windows.Forms.ComboBox cbb_tip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_loc;
        private System.Windows.Forms.ComboBox cbb_est;
        private System.Windows.Forms.Label label3;
    }
}