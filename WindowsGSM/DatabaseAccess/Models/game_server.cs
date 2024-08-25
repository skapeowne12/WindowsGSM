using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsGSM.DatabaseAccess.Models
{
    internal class game_server
    {
        public string id {  get; set; }
        public string ServerName { get; set; }
        public string ServerStatus { get; set; }
        public string PID {get; set; }
        public string MOD { get; set; }
        public string Port { get; set; }
        public string PlayerCount { get; set; }
        public string Uptime { get; set; }
    }
}
