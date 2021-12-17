using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace SerializeDesirialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txbMensagem.Text != "")
            {
                FileStream fs = new FileStream(@"C:\Arquivo\Mensagem.txt", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, txbMensagem.Text);
                fs.Close();
                MessageBox.Show("Serializado com sucesso !");
            } else
            {
                MessageBox.Show("Favor informar o conteúdo para ser serializado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Arquivo\Mensagem.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string mensagem;
            mensagem = bf.Deserialize(fs).ToString();
            lblMsg.Text = mensagem;
            MessageBox.Show(mensagem);
        }

        private void btnSeriXML_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = "Joãozito";
            p.idade = 70;
            p.salario = 2000;

            FileStream fs = new FileStream(@"C:\Arquivo\pessoa.xml", FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            xml.Serialize(fs, p);
            fs.Close();
            MessageBox.Show("XML Serializado com sucesso!");


        }

        private void btnDeseXML_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            FileStream fs = new FileStream(@"C:\Arquivo\pessoa.xml", FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            p = (Pessoa) xml.Deserialize(fs);

            lblNome.Text = p.nome;
            lblIdade.Text = p.idade.ToString();
            lblSalario.Text = p.salario.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = "Moisés";
            p.idade = 25;
            p.salario = 2100;

            JsonSerializer json = new JsonSerializer();
            StreamWriter sw = new StreamWriter(@"C:\Arquivo\pessoa.json");
            JsonWriter writer = new JsonTextWriter(sw);
            json.Serialize(writer, p);

            sw.Close();
            writer.Close();

            MessageBox.Show("Json Serializado !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\Arquivo\pessoa.json");


            Pessoa p = JsonConvert.DeserializeObject<Pessoa>(json);

            lblNomeJson.Text = p.nome;
            lblIdadeJson.Text = p.idade.ToString();
            lblSalarioJson.Text = p.salario.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = "Lauro";
            p.idade = 25;
            p.salario = 5100;

            FileStream stream = new FileStream(@"C:\Arquivo\pessoa.data", FileMode.Create);
            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(stream, p);
            stream.Close();

            MessageBox.Show("Serializado SOAP");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"C:\Arquivo\pessoa.data", FileMode.Open);
            SoapFormatter soap = new SoapFormatter();
            Pessoa p = (Pessoa)soap.Deserialize(stream);

            lblNomeSOAP.Text = p.nome;
            lblIdadeSoap.Text = p.idade.ToString();
            lblSalarioSoap.Text = p.salario.ToString();
        }
    }
}
