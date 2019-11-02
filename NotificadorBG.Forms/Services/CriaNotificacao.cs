using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace NotificadorBG.Forms.Services
{
    public class CriaNotificacoes
    {
        public IReadOnlyList<string> Mensagem { get { return _Mensagem.ToList(); } }
        private IList<string> _Mensagem { get; set; }

        public CriaNotificacoes()
        {
            _Mensagem = new List<string>();
        }
        public void AdicionarMensagem(string mensagem)
        {
            _Mensagem.Add(mensagem);
        }

        internal void ExibirNotificacoes()
        {
            foreach (string mensagem in Mensagem)
            {
                var popupNotifier = new PopupNotifier();
                popupNotifier.AnimationInterval = 10;
                popupNotifier.ImagePadding = new Padding(10);
                popupNotifier.Image = Properties.Resources.infoIcon_32;
                popupNotifier.TitleText = "Transferência de Recurso";
                popupNotifier.ContentText = mensagem;
                popupNotifier.IsRightToLeft = false;
                popupNotifier.Popup();
            }
        }
        //public void MontaNotificacao()
        //{
        //    var popupNotifier = new PopupNotifier();
        //    popupNotifier.ImagePadding = new Padding(10);
        //    popupNotifier.Image = Properties.Resources.infoIcon_32;
        //    popupNotifier.TitleText = "Title of popup";
        //    popupNotifier.ContentText = "Content text";
        //    popupNotifier.IsRightToLeft = false;
        //}
    }
}
