using Oracle.ManagedDataAccess.Client;
using OracleConnectTest.Abstractions;
using OracleConnectTest.Model;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace OracleConnectTest
{

    public partial class Form1 : Form
    {

        private readonly IManageClientsService _service;
        List<ClientDTO> clients = new List<ClientDTO>();

        public Form1(IManageClientsService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateListBox();

                MessageBox.Show("Данные загружены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedClient = clients[listBox1.SelectedIndex];

                var form = new DeleteForm(_service, selectedClient, this);
                form.ShowDialog();
       
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            ClientDTO clientDTO = new ClientDTO
            {
                Id = Convert.ToInt32(textBox1.Text),
                FirstName = textBox2.Text,
                Phone = textBox4.Text,
                IdType = 1010000001
            };

            _service.AddClient(clientDTO);
            UpdateListBox();
        }

        public void UpdateListBox()
        {
            clients.Clear();
            clients = _service.GetClients();
            listBox1.Items.Clear();
            foreach (var client in clients)
            {
                listBox1.Items.Add($"ID: {client.Id}, Name: {client.FirstName}, Phone: {client.Phone}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox3.Text);
            _service.RemoveClient(id);
            UpdateListBox();    
        }
    }
}
    

