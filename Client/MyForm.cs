using System;
using System.Windows.Forms;

namespace Client
{
    public partial class MyForm : Form
    {
        private MyClient client;
        private string Name { get; set; }

        public MyForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.CloseConnnection();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            Name = NameTxtBox.Text;
            ClientsListBox.Items.Add(Name);
            client = new MyClient(this, Name, ClientsListBox);
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string message = SendtxtBox.Text;
            string selectedItem = ClientsListBox.GetItemText(ClientsListBox.SelectedItem);

            if (message != null)
            {
                if (selectedItem != "")
                {
                    client.SendString("@ " + selectedItem + " " + message);
                    SendtxtBox.Text = String.Empty;
                }
                else
                {
                    client.SendString(message);
                }
            }
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
        }
    }
}