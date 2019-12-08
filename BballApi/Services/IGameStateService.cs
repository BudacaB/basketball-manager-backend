using BballApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BballApi.Services
{
    public interface IGameStateService
    {
        void PostGame(GameViewModel game);
        Task<List<GameViewModel>> GetAllGames();
    }
}
