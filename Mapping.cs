using System;
using System.IO;
using System.Windows.Forms;

namespace AssistDjMapInstaller
{
    class Mapping
    {    
        String dir;

        public Mapping(String dir)
        {
            this.dir = dir;
        }

        private String createMapping(String name)
        {
            System.Net.WebClient webClient = new System.Net.WebClient();
            byte[] data = webClient.DownloadData("https://gabrielraffa.works/projetos/assist_dj/mapeamento_android.txt");         

            return System.Text.Encoding.UTF8.GetString(data);
        }

        public void createFile(String name)
        {
            String completeDir = dir + name + ".midi.csv";

            if (File.Exists(completeDir)) {
                try {
                    File.SetAttributes(completeDir, FileAttributes.Normal);
                    File.Delete(completeDir);
                }
                catch (Exception erro) {
                    MessageBox.Show("Erro ao deletar mapeamento anterior.\nTente executar o programa como Administrador.", "Erro");
                }
            }            
                
            File.WriteAllText(completeDir, createMapping(name));
            File.SetAttributes(completeDir, FileAttributes.ReadOnly);           
        }
    }
}
