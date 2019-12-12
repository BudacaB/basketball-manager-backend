using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BballApi.Models
{
    public class GameMapper
    {
        public static GameViewModel MapToViewGame (GameDataModel dataGame)
        {
            if(dataGame == null)
            {
                throw new ArgumentNullException(nameof(dataGame));
            }
            return new GameViewModel { Name = dataGame.Name, Team = dataGame.Team };
        }

        public static GameDataModel MapToDataGame(GameViewModel viewGame)
        {
            if(viewGame == null)
            {
                throw new ArgumentNullException(nameof(viewGame));
            }
            return new GameDataModel { Name = viewGame.Name, Team = viewGame.Team, Creation = DateTime.Now };
        }
    }
}
