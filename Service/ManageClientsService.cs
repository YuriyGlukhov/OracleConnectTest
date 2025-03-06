using OracleConnectTest.Abstractions;
using OracleConnectTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OracleConnectTest.Service
{
    public class ManageClientsService : IManageClientsService
    {
        private readonly string _connectionString;
        List<ClientDTO> clients = new List<ClientDTO>();

        public ManageClientsService(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void AddClient(ClientDTO clientDTO)
        {
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                con.Open();

                string query = "INSERT INTO client (ID, ID_TYPE_CLIENT, INDFU, NAME, TELEPHONE) " +
                               "VALUES (:id,:idType, :indfu, :firstName, :phone)";
                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    try
                    {
                        cmd.BindByName  = true;
                        cmd.Parameters.Add(new OracleParameter(":id", OracleDbType.Int32)).Value = clientDTO.Id;
                        cmd.Parameters.Add(new OracleParameter(":idType", OracleDbType.Int32)).Value = clientDTO.IdType;
                        cmd.Parameters.Add(new OracleParameter(":indfu", OracleDbType.Varchar2)).Value = "F";
                        cmd.Parameters.Add(new OracleParameter(":firstName", OracleDbType.Varchar2)).Value = clientDTO.FirstName;      
                        cmd.Parameters.Add(new OracleParameter(":phone", OracleDbType.Varchar2)).Value = clientDTO.Phone;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Клиент успешно добавлен!");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при добавлении клиента.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
        }

        public List<ClientDTO> GetClients()
        {
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT * FROM client";
                OracleCommand cmd = new OracleCommand(query, con);

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        string firstName = reader["NAME"].ToString();
                        
                        string phone = reader["TELEPHONE"].ToString();


                        ClientDTO client = new ClientDTO
                        {
                            Id = id,
                            FirstName = firstName,
                            Phone = phone
                        };
                        clients.Add(client);

                    }
                    return clients;
                }
            }
        }

        public void RemoveClient(int id)
        {
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                con.Open();

                string query = "DELETE FROM client WHERE id = :id";

                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    cmd.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = id;

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Клиент успешно удален!");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении клиента.");
                    }
                }
               
            }
        }
    }
}
