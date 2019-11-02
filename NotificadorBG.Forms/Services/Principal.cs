using System;
using System.Threading;

namespace NotificadorBG.Forms.Services
{
    public class Principal
    {
        public bool isRunning { get; private set; }
        public int Status { get; private set; }

        public void Executar()
        {
            isRunning = true;
            try
            {
                Status = 1;// Iniciado

                SelecionaUsuarioLogado usuario = new SelecionaUsuarioLogado();
                usuario.ToString();
                Thread.Sleep(10000);

                Status = 2;// Finalizado
            }
            catch (Exception ex)
            {
                Status = 3;// Cancelado
            }
            finally
            {
                isRunning = false;
            }
        }
    }
}
