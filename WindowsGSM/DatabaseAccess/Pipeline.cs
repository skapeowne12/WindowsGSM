using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsGSM.DatabaseAccess.Models;
using System.Windows;
using System.Collections;
using WindowsGSM.Functions;
using wgsm = WindowsGSM;

namespace WindowsGSM.DatabaseAccess
{
    internal class Pipeline
    {
        string connectionstring = wgsm.Properties.Settings.Default.ES_Server;
        public Pipeline() { }

        public async Task UpdatedGameServers()
        {
            MainWindow WindowsGSM = (MainWindow)Application.Current.MainWindow;
            var ServerList = WindowsGSM.ServerGrid.Items;
            var list = WindowsGSM.GetServerList();
            var connection = new MySqlConnection(connectionstring);
            using (connection)
            {
                var sql = "INSERT INTO `wgsm`.`game_server` (`ID`,`PID`,`Game`,`Icon`,`Status`,`Name`,`IP`,`Port`,`QueryPort`,`Defaultmap`,`Maxplayers`,`Uptime`)VALUES(@ID,@PID,@Game,@Icon,@Status,@Name,@IP,@Port,@QueryPort,@Defaultmap,@Maxplayers,@Uptime)";
                foreach (ServerTable server in ServerList )
                {
                    try
                    {
                        connection.Execute(sql, server); 
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                    
                }
            }
        }
        public async Task TestDatabaseConnection()
        {
            string state;
            try
            {
                var connection = new MySqlConnection(connectionstring);

                using (connection)
                {
                    state = connection.State.ToString();
                    Debug.WriteLine(state);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
