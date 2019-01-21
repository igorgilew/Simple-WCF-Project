using System;
using System.ServiceModel;
using System.Windows.Forms;
using ServiceReference1;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {

        MyServiceClient client = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Print(string text)
        {
            richTextBox1.Text += text + "\n\n";
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void Print(Exception ex)
        {
            if (ex == null) return;
            Print(ex.Message);
            Print(ex.Source);
            Print(ex.StackTrace);
        }

        private void Create_New_Client()
        {
            if (client == null)
                try { Try_To_Create_New_Client(); }
                catch (Exception ex)
                {
                    Print(ex);
                    Print(ex.InnerException);
                    client = null;
                }
            else
            {
                Print("Cannot create a new client. The current Client is active.");
            }
        }

        private void Try_To_Create_New_Client()
        {
            try
            {

                BasicHttpBinding binding = new BasicHttpBinding();
                

                string uri = "http://localhost:9001/MyService";

                EndpointAddress endpoint = new EndpointAddress(new Uri(uri));

                client = new MyServiceClient(binding, endpoint);

                //client.ClientCredentials.Windows.ClientCredential.Domain = "";
                //client.ClientCredentials.Windows.ClientCredential.UserName = "Vasya";
                //client.ClientCredentials.Windows.ClientCredential.Password = "12345";

                Print("Creating new client ....");
                Print(endpoint.Uri.ToString());
                Print(uri);

                string test = client.Method1("test");

                if (test.Length < 1)
                {
                    throw new Exception("Проверка соединения не удалась");
                }
                else
                {
                    Print("test is OK  ! " + test);
                }

            }
            catch (Exception ex)
            {
                Print(ex);
                Print(ex.InnerException);
                client = null;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Create_New_Client();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Print("sending message . . .");
            string s = textBox1.Text;
            string x = "";
            if (client != null)
            {
                x = client.Method1(s);
                Print(x);
                x = client.Method2(s);
                Print(x);
            }
            else
            {
                Print("Error! Client does not exist!");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                Print("Closing a client ...");
                client.Close();
                client = null;
            }
            else
            {
                Print("Error! Client does not exist!");
            }
            this.Close();
        }
    }
}