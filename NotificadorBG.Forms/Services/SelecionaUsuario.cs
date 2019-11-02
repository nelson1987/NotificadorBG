using NotificadorBG.Forms.Exceptions;
using System;

namespace NotificadorBG.Forms.Services
{
    public class SelecionaUsuarioLogado
    {
        public  override string ToString()
        {
            var usuarioLogado = Environment.UserName;

            //if(string.IsNullOrEmpty(usuarioLogado))
            //    throw new LoginDomainException("Usuário logado fora do domínio necessário");
            //
            //if (!usuarioLogado.Contains("BCOGUAN"))
            //    throw new LoginDomainException("Usuário logado fora do domínio necessário");

            return usuarioLogado;
        }
    }
}
