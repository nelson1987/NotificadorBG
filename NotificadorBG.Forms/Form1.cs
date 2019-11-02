using NotificadorBG.Forms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        //Material de Apoio: https://wagnercaetano.wordpress.com/2017/09/27/system-security-securityexception-fonte-nao-encontrada-mas-alguns-ou-todos-os-logs-de-evento-nao-puderam-ser-pesquisados-logs-inacessiveis-security/
        protected override void OnLoad(EventArgs e)
        {
            if (!EventLog.SourceExists("NotificadorBG"))
                EventLog.CreateEventSource("NotificadorBG", "NotificadorBGLog");
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "NotificadorBG";
                eventLog.WriteEntry("Log message example", EventLogEntryType.Information);//, 101, 1);
            }
            var notificador = new PopupNotifier();
            notificador.TitleText = "Transferência de Recurso";
            notificador.ContentText = $"Mensagem no corpo do pop-up";
            notificador.ShowGrip = false;
            notificador.Delay = 5000;
            notificador.ShowCloseButton = false;
            //notificador.AnimationDuration = 1000;
            //notificador.AnimationInterval = 10;
            //notificador.BodyColor = Color.Transparent;
            //notificador.ContentColor = Color.Transparent;
            //notificador.ImagePadding = new Padding(10);
            notificador.Image = Properties.Resources.infoIcon_32;
            //notificador.IsRightToLeft = false;
            notificador.Popup();

            base.OnLoad(e);
            //Thread.Sleep(10000);

            //Application.Exit();
            //var taskA = Task.Run(() => {
            //    Console.WriteLine(DateTime.Today.DayOfWeek);
            //}).Wait(5000);



            //try
            //{
            //Validar o usuário
            //Conectar com HUB

            //Exibir mensagem

            //Dar intervalo
            //this.Invoke((MethodInvoker)delegate
            //{
            //    PopupNotifier pop = new PopupNotifier();
            //    pop.TitleText = "Test";
            //    pop.ContentText = "Hello World";
            //    pop.Popup();
            //});
            //Task.Run(() => {

            //    //SomeMethod(); //Some method that executes in background

            //    //Popup when SomeMethod is finished using Fruchtzwerg answer
            //    this.Invoke((MethodInvoker)delegate
            //    {
            //        PopupNotifier pop = new PopupNotifier();
            //        pop.TitleText = "Test";
            //        pop.ContentText = "Hello World";
            //        pop.Popup();
            //    });
            //}).Wait(1000);
            //var usuario = new SelecionaUsuarioLogado();
            //for (int i = 0; i < 5; i++)
            //{
            //    using (PopupNotifier notificador = new PopupNotifier())
            //    {
            //        //var popupNotifier = new PopupNotifier();
            //        notificador.AnimationInterval = 5;
            //        notificador.ImagePadding = new Padding(10);
            //        notificador.Image = Properties.Resources.infoIcon_32;
            //        notificador.TitleText = "Transferência de Recurso";
            //        notificador.ContentText = $"{usuario.ToString()} {i}";
            //        notificador.IsRightToLeft = false;
            //        notificador.Popup();
            //    }
            //    Thread.Sleep(10000);
            //}
            //var criador = new CriaNotificacoes();
            //criador.AdicionarMensagem("Title of popup");

            //criador.ExibirNotificacoes();

            //criador.AdicionarMensagem(usuario.ToString());

            //criador.ExibirNotificacoes();

            //criador.AdicionarMensagem("Content text");

            //criador.ExibirNotificacoes();
            //}
            //catch (Exception ex)
            //{
            //}
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
