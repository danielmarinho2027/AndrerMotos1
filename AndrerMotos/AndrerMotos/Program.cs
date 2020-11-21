using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AndreMotos.Application.Interface;
using AndreMotos.Application.Notificacoes;
using AndreMotos.Application.Services;
using AndreMotos.Data.Context;
using AndreMotos.Data.Interfaces;
using AndreMotos.Data.Repositorios;
using SimpleInjector;

namespace AndrerMotos
{
    static class Program
    {
        public static Container container;

        public static void Bootstrap()
        {
            container = new Container();
            container.Register<IProdutoRepositorio, ProdutoRepositorio>();
            container.Register<EstoqueContext>(Lifestyle.Singleton);

            container.Register<INotificador, Notificador>();
            container.Register<IProdutoService, ProdutoService>();

            container.Verify();
        }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(new Frm_Estoque());
        }
    }
}
