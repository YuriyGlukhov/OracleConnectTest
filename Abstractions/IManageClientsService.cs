using OracleConnectTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleConnectTest.Abstractions
{
    public interface IManageClientsService
    {
        public List<ClientDTO> GetClients();
        public void AddClient(ClientDTO client);
        public void RemoveClient(int id);
    }
}
