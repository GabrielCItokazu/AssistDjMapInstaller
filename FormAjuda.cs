using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistDjMapInstaller
{
    public partial class FormAjuda : Form
    {     
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FormAjuda()
        {
            InitializeComponent();
        }

        private void FormAjuda_Load(object sender, EventArgs e)
        {
            uiLoad();
        }
    
        private void FormAjuda_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void uiLoad()
        {
            //Texts            
            lblTextoMidi.Text = "Para conectar o dispositivo como MIDI vá até as opções de conexão\r\n" +
                "USB e selecione a opção para usar o dispositivo como MIDI.";
            lblTextoDevo.Text = "Você precisa mapear o dispositivo no primeiro uso, quando trocar de celular\r\n" +
                "(dispositivo) ou computador/notebook e também quando uma atualização\r\n" + 
                "do aplicativo exigir.\r\n" +
                "OBS: Em caso de atualização que exige o remapeamento, baixe este programa\r\n" +
                "novamente.";
            lblTextoRecebi.Text = "A mensagem apresentada no erro indica o problema. Caso necessário, entre\r\n" +
                "em contato com o desenvolvedor para resolver o problema.";

            //Change Color
            this.BackColor = Color.FromArgb(25, 25, 25);

            //Position Views
            lblTextoMidi.Top = lblTituloMidi.Top + lblTituloMidi.Height + 7;
            lblTituloDevo.Top = lblTextoMidi.Top + lblTextoMidi.Height + 20;
            lblTextoDevo.Top = lblTituloDevo.Top + lblTituloDevo.Height + 7;
            lblTituloRecebi.Top = lblTextoDevo.Top + lblTextoDevo.Height + 20;
            lblTextoRecebi.Top = lblTituloRecebi.Top + lblTituloRecebi.Height + 7;
            pnInfos.Left = (this.ClientSize.Width - pnInfos.Width) / 2;            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
