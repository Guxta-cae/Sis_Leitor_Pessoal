using System.Data.SqlClient;
using System.Speech.Synthesis;
using System.Text;

namespace Sis_Leitor_Pessoal
{
    public partial class Frm_Principal : Form
    {

        SpeechSynthesizer Sintetizador = new SpeechSynthesizer();

        public Frm_Principal()
        {
            InitializeComponent();
            //Popular os cmb
            //instacia do objeto BDEstilo
            BDDocumento obj_BDDocumento = new BDDocumento();

            //Instacia da lista que receberá a lista que chegará do Banco
            List<Documento> LstDocumento = new List<Documento>();
            List<Documento> LstDocumento2 = new List<Documento>();

            //Limpa Lista
            cmb_Arquivo.Items.Clear();

            LstDocumento = obj_BDDocumento.FindAllArquivo();
            LstDocumento2 = obj_BDDocumento.FindAllTexto();

            if (LstDocumento != null)
            {
                for (int i = 0; i < LstDocumento.Count; i++)
                {
                    cmb_Arquivo.Items.Add(LstDocumento[i].Ctd_Documento.ToString());
                }
            }
            if (LstDocumento2 != null)
            {
                for (int i = 0; i < LstDocumento2.Count; i++)
                {
                    cmb_Texto.Items.Add(LstDocumento2[i].Ctd_Documento.ToString());
                }
            }
        }

        private void btn_Falar_Click(object sender, EventArgs e)
        {
            //Faz falar
            if (cmb_Vozes.Text != "")
            {
                Sintetizador.SelectVoice(cmb_Vozes.Text);
            }
            Sintetizador.Rate = trb_Velocidade.Value;
            Sintetizador.Volume = trb_Volume.Value;
            Sintetizador.SpeakAsync(tbox_Texto.Text);

            if (cmb_Arquivo.Text == "" && cmb_Texto.Text == "")
            {
                //Salva o caminho do arquivo
                //Criar minha Conexão
                SqlConnection objCon = new SqlConnection(Connection.PathConnection());

                string sSQL = "INSERT INTO TB_DOCUMENTO " +
                              "( " +
                              "S_CTD_DOCUMENTO, " +
                              "B_PATH_DOCUMENTO" +
                              ") " +
                              "VALUES " +
                              "( " +
                              "@S_CTD_DOCUMENTO, " +
                              "@B_PATH_DOCUMENTO" +
                              ");";
                SqlCommand objCmd = new SqlCommand(sSQL, objCon);

                objCmd.Parameters.AddWithValue("@S_CTD_DOCUMENTO", tbox_Texto.Text);
                objCmd.Parameters.AddWithValue("@B_PATH_DOCUMENTO", 0);

                try
                {
                    objCon.Open();
                    int iCod = Convert.ToInt16(objCmd.ExecuteNonQuery());
                    objCon.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //E popula denovo

                //instacia do objeto BDEstilo
                BDDocumento obj_BDDocumento = new BDDocumento();

                //Instacia da lista que receberá a lista que chegará do Banco
                List<Documento> LstDocumento = new List<Documento>();

                //Limpa Lista
                cmb_Texto.Items.Clear();

                LstDocumento = obj_BDDocumento.FindAllTexto();

                if (LstDocumento != null)
                {
                    for (int i = 0; i < LstDocumento.Count; i++)
                    {
                        cmb_Texto.Items.Add(LstDocumento[i].Ctd_Documento.ToString());
                    }
                }
            }
        }

        private void btn_Arquivo_Click(object sender, EventArgs e)
        {
            //Salva o caminho do arquivo
            //Criar minha Conexão
            SqlConnection objCon = new SqlConnection(Connection.PathConnection());

            string sSQL = "INSERT INTO TB_DOCUMENTO " +
                          "( " +
                          "S_CTD_DOCUMENTO, " +
                          "B_PATH_DOCUMENTO" +
                          ") " +
                          "VALUES " +
                          "( " +
                          "@S_CTD_DOCUMENTO, " +
                          "@B_PATH_DOCUMENTO" +
                          ");";
            SqlCommand objCmd = new SqlCommand(sSQL, objCon);

            objCmd.Parameters.AddWithValue("@S_CTD_DOCUMENTO", tbox_Arquivo.Text);
            objCmd.Parameters.AddWithValue("@B_PATH_DOCUMENTO", 1);

            try
            {
                objCon.Open();
                int iCod = Convert.ToInt16(objCmd.ExecuteNonQuery());
                objCon.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //E popula denovo

            //instacia do objeto BDEstilo
            BDDocumento obj_BDDocumento = new BDDocumento();

            //Instacia da lista que receberá a lista que chegará do Banco
            List<Documento> LstDocumento = new List<Documento>();

            //Limpa Lista
            cmb_Arquivo.Items.Clear();

            LstDocumento = obj_BDDocumento.FindAllArquivo();

            if (LstDocumento != null)
            {
                for (int i = 0; i < LstDocumento.Count; i++)
                {
                    cmb_Arquivo.Items.Add(LstDocumento[i].Ctd_Documento.ToString());
                }
            }
        }
        private void cmb_Arquivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pega do banco e coloca no tbox

            try
            {
                StreamReader arquivo = new StreamReader(cmb_Arquivo.Text, Encoding.UTF8);
                tbox_Texto.Text = arquivo.ReadToEnd();
                cmb_Texto.Text = ""; //quando seleciona limpa o outro cmb
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmb_Texto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pega do banco e coloca no tbox
            tbox_Texto.Text = cmb_Texto.Text;
            cmb_Arquivo.Text = ""; //quando seleciona limpa o outro cmb
        }

        private void tbox_Texto_TextChanged(object sender, EventArgs e)
        {
            cmb_Arquivo.Text = "";
            cmb_Texto.Text = "";
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            CarregarVozes(cmb_Vozes);
        }

        private void CarregarVozes(ComboBox cmb)
        {
            foreach (InstalledVoice voz in Sintetizador.GetInstalledVoices())
            {
                VoiceInfo info = voz.VoiceInfo;
                string nomeVoz = info.Name;
                cmb.Items.Add(nomeVoz);
            }
        }

        private void btn_Velocidade_Click(object sender, EventArgs e)
        {
            trb_Velocidade.Value = 0;
        }

        private void btn_Volume_Click(object sender, EventArgs e)
        {
            trb_Volume.Value = 70;
        }

        private void btn_Parar_Click(object sender, EventArgs e)
        {
            Sintetizador.SpeakAsyncCancelAll();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tbox_Texto.Text = "";
        }
        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();



            OFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                // Mostra o path completo do arquivo selecionado
                tbox_Arquivo.Text = OFD.FileName;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Vozes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}