namespace XtremeFerramentas
{
    partial class cefDevolucao
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsp_dev = new System.Windows.Forms.ToolStrip();
            this.tsb_vol = new System.Windows.Forms.ToolStripButton();
            this.tsb_con = new System.Windows.Forms.ToolStripButton();
            this.tsb_exc = new System.Windows.Forms.ToolStripButton();
            this.btn_car = new System.Windows.Forms.Button();
            this.cbb_cod = new System.Windows.Forms.ComboBox();
            this.cbb_est = new System.Windows.Forms.ComboBox();
            this.cbb_fun = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_fer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsp_dev.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carrinho de ferramentas que serão devolvidas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 178);
            this.dataGridView1.TabIndex = 9;
            // 
            // tsp_dev
            // 
            this.tsp_dev.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsp_dev.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_vol,
            this.tsb_con,
            this.tsb_exc});
            this.tsp_dev.Location = new System.Drawing.Point(0, 0);
            this.tsp_dev.Name = "tsp_dev";
            this.tsp_dev.Size = new System.Drawing.Size(524, 27);
            this.tsp_dev.TabIndex = 51;
            this.tsp_dev.Text = "toolStrip1";
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
            // btn_car
            // 
            this.btn_car.BackgroundImage = global::XtremeFerramentas.Properties.Resources.AddCarrinho;
            this.btn_car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_car.Location = new System.Drawing.Point(427, 59);
            this.btn_car.Name = "btn_car";
            this.btn_car.Size = new System.Drawing.Size(75, 75);
            this.btn_car.TabIndex = 50;
            this.btn_car.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_car.UseVisualStyleBackColor = true;
            // 
            // cbb_cod
            // 
            this.cbb_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_cod.FormattingEnabled = true;
            this.cbb_cod.Location = new System.Drawing.Point(156, 97);
            this.cbb_cod.Name = "cbb_cod";
            this.cbb_cod.Size = new System.Drawing.Size(256, 28);
            this.cbb_cod.TabIndex = 49;
            // 
            // cbb_est
            // 
            this.cbb_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_est.FormattingEnabled = true;
            this.cbb_est.Location = new System.Drawing.Point(156, 131);
            this.cbb_est.Name = "cbb_est";
            this.cbb_est.Size = new System.Drawing.Size(256, 28);
            this.cbb_est.TabIndex = 48;
            // 
            // cbb_fun
            // 
            this.cbb_fun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_fun.FormattingEnabled = true;
            this.cbb_fun.Location = new System.Drawing.Point(156, 30);
            this.cbb_fun.Name = "cbb_fun";
            this.cbb_fun.Size = new System.Drawing.Size(256, 28);
            this.cbb_fun.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Estado Ferramenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Código Ferramenta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Funcionário:";
            // 
            // cbb_fer
            // 
            this.cbb_fer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_fer.FormattingEnabled = true;
            this.cbb_fer.Location = new System.Drawing.Point(156, 63);
            this.cbb_fer.Name = "cbb_fer";
            this.cbb_fer.Size = new System.Drawing.Size(256, 28);
            this.cbb_fer.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Ferramenta:";
            // 
            // cefDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 381);
            this.Controls.Add(this.cbb_fer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tsp_dev);
            this.Controls.Add(this.btn_car);
            this.Controls.Add(this.cbb_cod);
            this.Controls.Add(this.cbb_est);
            this.Controls.Add(this.cbb_fun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Name = "cefDevolucao";
            this.Text = "Devolução de ferramenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cefDevolucao_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tsp_dev.ResumeLayout(false);
            this.tsp_dev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip tsp_dev;
        private System.Windows.Forms.ToolStripButton tsb_vol;
        private System.Windows.Forms.ToolStripButton tsb_con;
        private System.Windows.Forms.ToolStripButton tsb_exc;
        private System.Windows.Forms.Button btn_car;
        private System.Windows.Forms.ComboBox cbb_cod;
        private System.Windows.Forms.ComboBox cbb_est;
        private System.Windows.Forms.ComboBox cbb_fun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_fer;
        private System.Windows.Forms.Label label5;
    }
}