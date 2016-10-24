namespace XtremeFerramentas
{
    partial class cefEmprestimo
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
            this.rtb_inf = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tsp_emp = new System.Windows.Forms.ToolStrip();
            this.tsp_vol = new System.Windows.Forms.ToolStripButton();
            this.tsb_con = new System.Windows.Forms.ToolStripButton();
            this.tsb_exc = new System.Windows.Forms.ToolStripButton();
            this.btn_car = new System.Windows.Forms.Button();
            this.cbb_fer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_cod = new System.Windows.Forms.ComboBox();
            this.cbb_fun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsp_emp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 154);
            this.dataGridView1.TabIndex = 7;
            // 
            // rtb_inf
            // 
            this.rtb_inf.Location = new System.Drawing.Point(63, 78);
            this.rtb_inf.Name = "rtb_inf";
            this.rtb_inf.Size = new System.Drawing.Size(499, 40);
            this.rtb_inf.TabIndex = 8;
            this.rtb_inf.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Informações da ferramenta selecionada:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Carinho de ferramentas:";
            // 
            // tsp_emp
            // 
            this.tsp_emp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsp_emp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_vol,
            this.tsb_con,
            this.tsb_exc});
            this.tsp_emp.Location = new System.Drawing.Point(0, 0);
            this.tsp_emp.Name = "tsp_emp";
            this.tsp_emp.Size = new System.Drawing.Size(524, 27);
            this.tsp_emp.TabIndex = 43;
            this.tsp_emp.Text = "tsp_emp";
            // 
            // tsp_vol
            // 
            this.tsp_vol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsp_vol.Image = global::XtremeFerramentas.Properties.Resources.Voltar;
            this.tsp_vol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsp_vol.Name = "tsp_vol";
            this.tsp_vol.Size = new System.Drawing.Size(24, 24);
            this.tsp_vol.Text = "toolStripButton4";
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
            // btn_car
            // 
            this.btn_car.BackgroundImage = global::XtremeFerramentas.Properties.Resources.AddCarrinho;
            this.btn_car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_car.Location = new System.Drawing.Point(427, 43);
            this.btn_car.Name = "btn_car";
            this.btn_car.Size = new System.Drawing.Size(75, 75);
            this.btn_car.TabIndex = 6;
            this.btn_car.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_car.UseVisualStyleBackColor = true;
            // 
            // cbb_fer
            // 
            this.cbb_fer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_fer.FormattingEnabled = true;
            this.cbb_fer.Location = new System.Drawing.Point(156, 63);
            this.cbb_fer.Name = "cbb_fer";
            this.cbb_fer.Size = new System.Drawing.Size(256, 28);
            this.cbb_fer.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Ferramenta:";
            // 
            // cbb_cod
            // 
            this.cbb_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_cod.FormattingEnabled = true;
            this.cbb_cod.Location = new System.Drawing.Point(156, 97);
            this.cbb_cod.Name = "cbb_cod";
            this.cbb_cod.Size = new System.Drawing.Size(256, 28);
            this.cbb_cod.TabIndex = 57;
            // 
            // cbb_fun
            // 
            this.cbb_fun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_fun.FormattingEnabled = true;
            this.cbb_fun.Location = new System.Drawing.Point(156, 30);
            this.cbb_fun.Name = "cbb_fun";
            this.cbb_fun.Size = new System.Drawing.Size(256, 28);
            this.cbb_fun.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Código Ferramenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Funcionário:";
            // 
            // cefEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 381);
            this.Controls.Add(this.cbb_fer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_cod);
            this.Controls.Add(this.cbb_fun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tsp_emp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb_inf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_car);
            this.Name = "cefEmprestimo";
            this.Text = "Controle de emprestimo de ferramentas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cefEmprestimo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tsp_emp.ResumeLayout(false);
            this.tsp_emp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_car;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rtb_inf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip tsp_emp;
        private System.Windows.Forms.ToolStripButton tsb_con;
        private System.Windows.Forms.ToolStripButton tsb_exc;
        private System.Windows.Forms.ToolStripButton tsp_vol;
        private System.Windows.Forms.ComboBox cbb_fer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_cod;
        private System.Windows.Forms.ComboBox cbb_fun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}