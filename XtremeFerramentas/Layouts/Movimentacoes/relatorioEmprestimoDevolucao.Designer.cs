namespace XtremeFerramentas
{
    partial class relatorioEmprestimoDevolucao
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
            this.rbn_emp = new System.Windows.Forms.RadioButton();
            this.rdn_dev = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_set = new System.Windows.Forms.ComboBox();
            this.cbb_tip = new System.Windows.Forms.ComboBox();
            this.cbb_est = new System.Windows.Forms.ComboBox();
            this.btn_bus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_vol = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbn_emp
            // 
            this.rbn_emp.AutoSize = true;
            this.rbn_emp.Location = new System.Drawing.Point(12, 12);
            this.rbn_emp.Name = "rbn_emp";
            this.rbn_emp.Size = new System.Drawing.Size(79, 17);
            this.rbn_emp.TabIndex = 2;
            this.rbn_emp.TabStop = true;
            this.rbn_emp.Text = "Emprestimo";
            this.rbn_emp.UseVisualStyleBackColor = true;
            // 
            // rdn_dev
            // 
            this.rdn_dev.AutoSize = true;
            this.rdn_dev.Location = new System.Drawing.Point(152, 12);
            this.rdn_dev.Name = "rdn_dev";
            this.rdn_dev.Size = new System.Drawing.Size(77, 17);
            this.rdn_dev.TabIndex = 3;
            this.rdn_dev.TabStop = true;
            this.rdn_dev.Text = "Devolução";
            this.rdn_dev.UseVisualStyleBackColor = true;
            this.rdn_dev.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Setor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado:";
            // 
            // cbb_set
            // 
            this.cbb_set.FormattingEnabled = true;
            this.cbb_set.Location = new System.Drawing.Point(62, 57);
            this.cbb_set.Name = "cbb_set";
            this.cbb_set.Size = new System.Drawing.Size(373, 21);
            this.cbb_set.TabIndex = 7;
            // 
            // cbb_tip
            // 
            this.cbb_tip.FormattingEnabled = true;
            this.cbb_tip.Location = new System.Drawing.Point(62, 89);
            this.cbb_tip.Name = "cbb_tip";
            this.cbb_tip.Size = new System.Drawing.Size(373, 21);
            this.cbb_tip.TabIndex = 8;
            // 
            // cbb_est
            // 
            this.cbb_est.FormattingEnabled = true;
            this.cbb_est.Location = new System.Drawing.Point(62, 119);
            this.cbb_est.Name = "cbb_est";
            this.cbb_est.Size = new System.Drawing.Size(373, 21);
            this.cbb_est.TabIndex = 9;
            // 
            // btn_bus
            // 
            this.btn_bus.Location = new System.Drawing.Point(441, 73);
            this.btn_bus.Name = "btn_bus";
            this.btn_bus.Size = new System.Drawing.Size(103, 50);
            this.btn_bus.TabIndex = 10;
            this.btn_bus.Text = "Buscar";
            this.btn_bus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Resultado da busca:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 105);
            this.dataGridView1.TabIndex = 12;
            // 
            // btn_vol
            // 
            this.btn_vol.Location = new System.Drawing.Point(12, 287);
            this.btn_vol.Name = "btn_vol";
            this.btn_vol.Size = new System.Drawing.Size(75, 23);
            this.btn_vol.TabIndex = 13;
            this.btn_vol.Text = "Voltar";
            this.btn_vol.UseVisualStyleBackColor = true;
            // 
            // btn_exp
            // 
            this.btn_exp.Location = new System.Drawing.Point(469, 287);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(75, 23);
            this.btn_exp.TabIndex = 14;
            this.btn_exp.Text = "Exportar";
            this.btn_exp.UseVisualStyleBackColor = true;
            // 
            // relatorioEmprestimoDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 316);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_vol);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_bus);
            this.Controls.Add(this.cbb_est);
            this.Controls.Add(this.cbb_tip);
            this.Controls.Add(this.cbb_set);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdn_dev);
            this.Controls.Add(this.rbn_emp);
            this.Name = "relatorioEmprestimoDevolucao";
            this.Text = "Relatório de emprestimo e devolução";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbn_emp;
        private System.Windows.Forms.RadioButton rdn_dev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_set;
        private System.Windows.Forms.ComboBox cbb_tip;
        private System.Windows.Forms.ComboBox cbb_est;
        private System.Windows.Forms.Button btn_bus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_vol;
        private System.Windows.Forms.Button btn_exp;
    }
}