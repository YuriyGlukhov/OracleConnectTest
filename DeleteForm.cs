using OracleConnectTest.Abstractions;
using OracleConnectTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleConnectTest
{
    public partial class DeleteForm : Form
    {
        private readonly IManageClientsService _service;
        private readonly ClientDTO _client;
        private readonly Form1 _form;
        public DeleteForm(IManageClientsService service, ClientDTO client,Form1 form)
        {
            InitializeComponent();
            _service = service;
            _client = client;
            _form = form;
            UpdateForm();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _service.RemoveClient(_client.Id);
            _form.UpdateListBox();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        public void UpdateForm()
        {
            label1.Text = $"Id: {_client.Id}";
            label2.Text = $"Имя: {_client.FirstName}";
            
        }
    }
}
