namespace XtremeFerramentas
{
    partial class ConFun
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
            this.c1CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3Ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4dtNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5Nat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_sex = new System.Windows.Forms.ComboBox();
            this.cbb_nat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_ida = new System.Windows.Forms.ComboBox();
            this.cbb_nom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1CPF,
            this.c2Nome,
            this.c3Ida,
            this.c4dtNasc,
            this.c5Nat,
            this.c6Sex});
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // c1CPF
            // 
            this.c1CPF.HeaderText = "CPF";
            this.c1CPF.Name = "c1CPF";
            // 
            // c2Nome
            // 
            this.c2Nome.HeaderText = "Nome";
            this.c2Nome.Name = "c2Nome";
            this.c2Nome.Width = 150;
            // 
            // c3Ida
            // 
            this.c3Ida.HeaderText = "Idade";
            this.c3Ida.Name = "c3Ida";
            // 
            // c4dtNasc
            // 
            this.c4dtNasc.HeaderText = "Data Nasc";
            this.c4dtNasc.Name = "c4dtNasc";
            // 
            // c5Nat
            // 
            this.c5Nat.HeaderText = "Naturalidade";
            this.c5Nat.Name = "c5Nat";
            this.c5Nat.Width = 120;
            // 
            // c6Sex
            // 
            this.c6Sex.HeaderText = "Sexo";
            this.c6Sex.Name = "c6Sex";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbb_sex);
            this.groupBox3.Controls.Add(this.cbb_nat);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbb_ida);
            this.groupBox3.Controls.Add(this.cbb_nom);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 86);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Naturalidade:";
            // 
            // cbb_sex
            // 
            this.cbb_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_sex.FormattingEnabled = true;
            this.cbb_sex.Location = new System.Drawing.Point(356, 52);
            this.cbb_sex.Name = "cbb_sex";
            this.cbb_sex.Size = new System.Drawing.Size(121, 23);
            this.cbb_sex.TabIndex = 12;
            // 
            // cbb_nat
            // 
            this.cbb_nat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_nat.FormattingEnabled = true;
            this.cbb_nat.Location = new System.Drawing.Point(356, 23);
            this.cbb_nat.Name = "cbb_nat";
            this.cbb_nat.Size = new System.Drawing.Size(121, 23);
            this.cbb_nat.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Idade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // cbb_ida
            // 
            this.cbb_ida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ida.FormattingEnabled = true;
            this.cbb_ida.Location = new System.Drawing.Point(104, 52);
            this.cbb_ida.Name = "cbb_ida";
            this.cbb_ida.Size = new System.Drawing.Size(121, 23);
            this.cbb_ida.TabIndex = 8;
            // 
            // cbb_nom
            // 
            this.cbb_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_nom.FormattingEnabled = true;
            this.cbb_nom.Location = new System.Drawing.Point(104, 23);
            this.cbb_nom.Name = "cbb_nom";
            this.cbb_nom.Size = new System.Drawing.Size(121, 23);
            this.cbb_nom.TabIndex = 7;
            // 
            // ConFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 488);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConFun";
            this.Text = "ConFun";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConFun_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3Ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4dtNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5Nat;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6Sex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_sex;
        private System.Windows.Forms.ComboBox cbb_nat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_ida;
        private System.Windows.Forms.ComboBox cbb_nom;
    }
}