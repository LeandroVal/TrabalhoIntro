using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtremeFerramentas
{
    public partial class ContainerP : Form
    {
        public ContainerP()
        {
            InitializeComponent();
        }

        
        private void ContainerP_Load(object sender, EventArgs e)
        {

             //////////////// Propriedades do MDIContainer
            /////////////////////////////////////////////////////////////////////////////
            MdiClient ctlMDI = (MdiClient)this.Controls[this.Controls.Count - 1];    ///
            ctlMDI.BackColor = Color.WhiteSmoke;                                    ///
            ctlMDI.BackgroundImage = Properties.Resources.fundo4;                  ///
            /////////////////////////////////////////////////////////////////////////
        }

        

        private void ms_princ_fer_emp_Click(object sender, EventArgs e)
        {
            
            if (janelas.ferEmp == 0)
            {
                cefEmprestimo CefEmprestimo = new cefEmprestimo();              
                CefEmprestimo.MdiParent = this;
                CefEmprestimo.Show();
                janelas.ferEmp++;
            }

            
        }

        private void ms_princ_fer_cad_Click(object sender, EventArgs e)
        {
            if (janelas.ferCad == 0)
            {
                cadFerramentas CadFerramentas = new cadFerramentas();
                CadFerramentas.MdiParent = this;
                CadFerramentas.Show();
                janelas.ferCad++;
            }
        }

        private void ms_princ_fer_dev_Click(object sender, EventArgs e)
        {
            if (janelas.ferDevol == 0)
            {
                cefDevolucao CefDevolucao = new cefDevolucao();
                CefDevolucao.MdiParent = this;
                CefDevolucao.Show();
                janelas.ferDevol++;
            }
        }

        private void ms_princ_fer_con_Click(object sender, EventArgs e)
        {
            if (janelas.ferCons == 0)
            {
                ConFer ConFerramenta = new ConFer();
                ConFerramenta.MdiParent = this;
                ConFerramenta.Show();
                janelas.ferCons++;
            }
        }

        private void ms_princ_fer_mod_Click(object sender, EventArgs e)
        {
            if (janelas.ferMod == 0)
            {
                ferMod FerMod = new ferMod();
                FerMod.MdiParent = this;
                FerMod.Show();
                janelas.ferMod++;
            }
        }

        private void ms_princ_fer_exc_Click(object sender, EventArgs e)
        {
            if (janelas.ferExc == 0)
            {
                ferExc FerExc = new ferExc();
                FerExc.MdiParent = this;
                FerExc.Show();
                janelas.ferExc++;
            }
            
        }

        private void ms_princ_fer_ins_Click(object sender, EventArgs e)
        {
            if (janelas.ferIns == 0)
            {
                ferrInserir FerrInserir = new ferrInserir();
                FerrInserir.MdiParent = this;
                FerrInserir.Show();
                janelas.ferIns++;
            }
        }

        private void ms_princ_fun_con_Click(object sender, EventArgs e)
        {
            if (janelas.funCon == 0)
            {
                ConFun ConFuncionario = new ConFun();
                ConFuncionario.MdiParent = this;
                ConFuncionario.Show();
                janelas.funCon++;
            }
        }

        private void ms_princ_fun_cad_Click(object sender, EventArgs e)
        {
            if (janelas.funCad == 0)
            {
                cadfunc CadFuncionario = new cadfunc();
                CadFuncionario.MdiParent = this;
                CadFuncionario.Show();
                janelas.funCad++;
            }
        }

        private void ms_princ_fun_mod_Click(object sender, EventArgs e)
        {
            if (janelas.funMod == 0)
            {
                funcMod ModFuncionario = new funcMod();
                ModFuncionario.MdiParent = this;
                ModFuncionario.Show();
                janelas.funMod++;
            }
        }

        private void ms_princ_fun_exc_Click(object sender, EventArgs e)
        {
            if (janelas.funExc == 0)
            {
                FuncExcluir ExcFuncionario = new FuncExcluir();
                ExcFuncionario.MdiParent = this;
                ExcFuncionario.Show();
                janelas.funExc++;
            }
        }

        private void ms_princ_set_con_Click(object sender, EventArgs e)
        {
            if (janelas.setCon == 0)
            {
                conset Consetor = new conset();
                Consetor.MdiParent = this;
                Consetor.Show();
                janelas.setCon++;
            }
        }

        private void ms_princ_set_cad_Click(object sender, EventArgs e)
        {
            if (janelas.setCad == 0)
            {
                cadSetor CadSetor = new cadSetor();
                CadSetor.MdiParent = this;
                CadSetor.Show();
                janelas.setCad++;
            }
        }

        private void ms_princ_set_mod_Click(object sender, EventArgs e)
        {
            if (janelas.setMod == 0)
            {
                modSet ModSetor = new modSet();
                ModSetor.MdiParent = this;
                ModSetor.Show();
                janelas.setMod++;
            }
        }

        private void ms_princ_set_rem_Click(object sender, EventArgs e)
        {
            if (janelas.setExc == 0)
            {
                ExcSet ExcSetor = new ExcSet();
                ExcSetor.MdiParent = this;
                ExcSetor.Show();
                janelas.setExc++;
            }
        }

        private void ms_princ_fun_deb_Click(object sender, EventArgs e)
        {
            if (janelas.funDeb == 0)
            {
                funcConsDeb ConsDeb = new funcConsDeb();
                ConsDeb.MdiParent = this;
                ConsDeb.Show();
                janelas.funDeb++;
            }
        }
    }
}
