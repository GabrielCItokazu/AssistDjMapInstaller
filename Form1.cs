using System;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace AssistDjMapInstaller
{
    public partial class AssistDj : Form
    {
        Mapping mapping, mappingS;

        const int BUFFER_MAX = 100;
        String[] deviceName = new String[BUFFER_MAX];
        String dir = "", dirS = "";
        Boolean dE = false, dES = false;
        int selected = -1;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public AssistDj()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uiLoad();
            findDevices();
            if(checkDir())
                mapping = new Mapping(dir);
            if(checkDirS())
                mappingS = new Mapping(dirS);
            if(!dE && !dES)
                MessageBox.Show("Erro: Rekordbox não encontrado.", "Erro");
        }

        private void AssistDj_MouseDown(object sender, MouseEventArgs e)
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
            lblSelecione.Text = "Selecione o dispositivo Android que deseja mapear: ";
            lblInfo.Text = "OBS: Conecte o dispositivo como MIDI para ser exibido na lista.";


            //Change Color
            btnAjuda.ForeColor = Color.FromArgb(154, 153, 42);
            btnFechar.ForeColor = Color.FromArgb(242, 65, 66);
            btnConfirmar.ForeColor = Color.FromArgb(45, 105, 42);            
            lblSelecione.ForeColor = Color.FromArgb(186, 186, 186);
            this.BackColor = Color.FromArgb(25, 25, 25);

            //Center Views
            lblSelecione.Left = (this.ClientSize.Width - lblSelecione.Width) / 2;
            lblInfo.Left = (this.ClientSize.Width - lblInfo.Width) / 2;
            pbLogo.Left = (this.ClientSize.Width - pbLogo.Width) / 2;
            clbDevices.Left = (this.ClientSize.Width - clbDevices.Width) / 2;
            pnButtons.Left = (this.ClientSize.Width - pnButtons.Width) / 2;
        }  

        private void findDevices()
        {
            int i = 0;
            clbDevices.Items.Clear();
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("select * from Win32_PnPEntity where service = 'usbaudio'");           
            foreach (ManagementObject soundDevice in managementObjectSearcher.Get())
            {
                if (i == 99) //BUFFER_MAX
                    break;
                deviceName[i] = soundDevice.GetPropertyValue("Name").ToString();
                clbDevices.Items.Add(deviceName[i++]);
            }

        }

        private Boolean checkDir()
        {            
            //C:\Users\%USERPROFILE%\AppData\Roaming\Pioneer\rekordbox        
            dir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Pioneer/rekordbox/");           
            if (Directory.Exists(dir))
            {
                dE = true;
                return true;
            }           
            return false;
        }

        private Boolean checkDirS()
        {
            //C:\Users\%USERPROFILE%\AppData\Roaming\Pioneer\rekordbox6\MidiMappings
            dirS = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Pioneer/rekordbox6/MidiMappings/");
            if (Directory.Exists(dir))
            {
                dES = true;
                return true;
            }
            return false;
        }

        private void clbDevices_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int x = 0; x < clbDevices.Items.Count; ++x)
                if (x != e.Index) clbDevices.SetItemChecked(x, false);
            selected = e.Index;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            findDevices();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            FormAjuda formAjuda = new FormAjuda();
            this.Hide();            
            formAjuda.ShowDialog();
            this.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!dE && !dES)
            {
                MessageBox.Show("Erro: Rekordbox não encontrado.", "Erro");
                return;
            }
            if(clbDevices.CheckedItems.Count == 0)
            {
                MessageBox.Show("Erro: Nenhum item selecionado.", "Erro");
                return;
            }
            if (dE)
            {
                try { 
                mapping.createFile(deviceName[selected]);
                    MessageBox.Show("Mapeado com sucesso no Rekordbox5 =)", "Sucesso");
                }
                catch (Exception erro) {
                    MessageBox.Show("Erro ao mapear no Rekordbox5." +
                        "\nTalvez já tenha algum mapeamento instalado nessa versão.", "Erro");
                }
                    
            }
            if (dES)
            {
                try {
                    mappingS.createFile(deviceName[selected]);
                    MessageBox.Show("Mapeado com sucesso no Rekordbox6 =)", "Sucesso");
                }
                catch (Exception erro) {
                    MessageBox.Show("Erro ao mapear no Rekordbox6." +
                        "\nTalvez já tenha algum mapeamento instalado nessa versão.", "Erro");
                }               
            }
        }       
    }
}
