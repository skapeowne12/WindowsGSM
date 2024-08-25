using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsGSM.DatabaseAccess.Settings
{
    internal class ReadDatabaseSettings
    {
        public string connectionString { get; set; }

        public  ReadDatabaseSettings()
        {
            
        }

        public async Task ReadSettings()
        {
            using (StreamReader sr = new StreamReader("serversetttings.json"))
            {
                string json = await sr.ReadToEndAsync();
                SettingsStructrure data = JsonConvert.DeserializeObject<SettingsStructrure>(json);
                this.connectionString = data.connectionString;

            }
        }
    }
    internal sealed class SettingsStructrure
    {
        public string connectionString { get; set; }
    }
}
