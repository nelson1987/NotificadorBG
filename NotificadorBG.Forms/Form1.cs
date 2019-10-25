using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace NotificadorBG.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            //Validar o usuário

            //Conectar com HUB
            //exibir mensagem
            //Dar intervalo
            var popupNotifier = new PopupNotifier();
            popupNotifier.ImagePadding = new Padding(10);
            popupNotifier.Image = Properties.Resources.infoIcon_32;
            popupNotifier.TitleText = "Title of popup";
            popupNotifier.ContentText = "Content text";
            popupNotifier.IsRightToLeft = false;
            popupNotifier.Popup();
            base.OnLoad(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //var popupNotifier = new PopupNotifier();
            //popupNotifier.ImagePadding = new Padding(10);
            //popupNotifier.Image = Properties.Resources.infoIcon_32;
            //popupNotifier.TitleText = "Title of popup";
            //popupNotifier.ContentText = "Content text";
            //popupNotifier.IsRightToLeft = false;
            //popupNotifier.Popup();
        }
    }
}
