using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LocalizadorDeCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cep = txbCEP.Text.Replace("-", "").Replace(" ", ""); // Salvar entrada do usuario
            string url = $"https://viacep.com.br/ws/{cep}/json/"; // Salvar o link do cep do usuario
            if (cep.Length < 8)
            {
                MessageBox.Show("CEP Invalido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (WebClient navegador = new WebClient())
                {
                    string conteudo = navegador.DownloadString(url);
                    // Converter para u8
                    conteudo = Encoding.UTF8.GetString(Encoding.Default.GetBytes(conteudo));
                    Endereco endereco = new Endereco();

                    endereco = JsonConvert.DeserializeObject<Endereco>(conteudo);
                    if (!string.IsNullOrEmpty(endereco.cep))
                    {
                        //configurar os campos
                        lblCEP.Text = $"CEP: {endereco.cep}";
                        lblBairro.Text = $"Bairro: {endereco.bairro}";
                        lblComplemento.Text = $"Complemento: {endereco.complemento}";
                        lblDDD.Text = $"DDD: {endereco.ddd}";
                        lblLocalidade.Text = $"Localidade: {endereco.localidade}";
                        lblLogradouro.Text = $"Logradoura: {endereco.logradouro}";
                        lblRegiao.Text = $"Região: {endereco.regiao}";
                        lblEstado.Text = $"Estado: {endereco.estado}";
                        lblUf.Text = $"UF: {endereco.uf}";
                        lblUnidade.Text = $"Unidade: {endereco.unidade}";
                    }
                    else
                    {
                        MessageBox.Show("CEP Invalido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
