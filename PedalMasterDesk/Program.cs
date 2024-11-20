using PedalMasterLib;
using SysPecNSLib;

namespace PedalMasterDesk
{
    internal static class Program
    {
        public static Funcionarios frmDgvFuncionario = new();
        public static Cliente frmDgvCliente = new();
        public static Estoque frmdgvEstoque = new();
        public static Estoque frmpregui�a = new();
        public static Funcionarios UsuarioLogado = new();
        public static Email EmailUsuarioLogado = new();
        public static Cliente frmGdvBuscarCliente = new();
        public static Pedidos VARFinalizarpedidoNovo = new();
        public static Pedidos PedidoemAberto = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Principal());
        }
    }
}