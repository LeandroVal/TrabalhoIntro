using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtremeFerramentas.Entities;

namespace XtremeFerramentas.Data
{
    class clsRetorno
    {
        //class para retorno

        public int idRetorno { get; set; }
        public string Mensagem { get; set; }
        public Boolean Sucesso { get; set; }
        public ArrayList ListaAux { get; set; }

        public static implicit operator clsRetorno(ferramentas v)
        {
            throw new NotImplementedException();
        }
    }
}
