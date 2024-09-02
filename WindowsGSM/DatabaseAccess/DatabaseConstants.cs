using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace WindowsGSM.DatabaseAccess
{
    internal class DatabaseConstants
    {
        public const string insert = "INSERT INTO `wgsm`.`game_server` (`ID`,`PID`,`Game`,`Icon`,`Status`,`Name`,`IP`,`Port`,`QueryPort`,`Defaultmap`,`Maxplayers`,`Uptime`)VALUES(@ID,@PID,@Game,@Icon,@Status,@Name,@IP,@Port,@QueryPort,@Defaultmap,@Maxplayers,@Uptime)";
        public const string update = "UPDATE game_server SET `ID` = @ID,`PID` = @PID,`Game` = @Game,`Icon` = @Icon,`Status` = @Status,`Name` = @Name,`IP` = @IP,`Port` = @Port,`QueryPort` = @QueryPort,`Defaultmap` = @Defaultmap,`Maxplayers` = @Maxplayers,`Uptime` = @Uptime WHERE `ID` = @ID";
        public const string select = "SELECT * FROM wgsm.game_server WHERE `ID`= ";
    }
}
