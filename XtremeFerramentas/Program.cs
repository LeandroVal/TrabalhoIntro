using System;
using System.Windows.Forms;

namespace XtremeFerramentas
{
    public static class janelas // Classe estática para impedir que duas janelas
    {                          //  com a mesma função sejam abertas ao mesmo tempo.
        public static int ferEmp = 0, ferDevol = 0, ferConDet = 0,  ferCons = 0, ferCad = 0, ferMod = 0, ferExc = 0, ferIns = 0;
        public static int funCon = 0, funCad = 0, funMod = 0, funExc = 0, funDeb = 0;
        public static int setCon = 0, setCad = 0, setMod = 0, setExc = 0;
    }
    
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ContainerP containerPrincipal = new ContainerP();
            Application.Run(containerPrincipal);
                 
        }
    }
}
