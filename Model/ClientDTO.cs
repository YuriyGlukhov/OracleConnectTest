using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleConnectTest.Model
{
    public class ClientDTO
    {
        public int Id {  get; set; }
        public string? FullName{ get; set; }
        public string? Phone {  get; set; }
        public int IdType { get; set; }
    }
}
