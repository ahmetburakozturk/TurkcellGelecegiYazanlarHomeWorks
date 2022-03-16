using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PremierLeague.Entities;

namespace PremierLeague.Businness.Concrete
{
    public class PlayerManager : IGenericDal<Player>
    {
        private IGenericDal<Player> _playerDal;
        private IGenericDal<Team> _teamDal = new GenericRepository<Team>();
        private IGenericDal<Country> _countryDal = new GenericRepository<Country>();

        public PlayerManager(IGenericDal<Player> playerDal)
        {
            _playerDal = playerDal;
        }
        public void Add(Player entity)
        {
            _playerDal.Add(entity);
        }

        public void Update(Player entity)
        {
            _playerDal.Update(entity);
        }

        public void Delete(Player entity)
        {
            _playerDal.Delete(entity);
        }

        public List<Player> GetAll()
        {
            return _playerDal.GetAll();
        }

        public Player Get(int id)
        {
            return _playerDal.Get(id);
        }

        public Team GetPlayerTeam(int teamId)
        {
            return _teamDal.Get(teamId);
        }

        public List<Player> GetPlayersForSale()
        {
            
            List<Player> playerList = _playerDal.GetAll(x => x.State == true);
            foreach (var player in playerList)
            {
                player.Team = GetPlayerTeam(player.TeamID);
                player.Country = GetPlayerCountry(player.CountryID);
            }

            return playerList;
        }

        public Country GetPlayerCountry(int countryId)
        {
            return _countryDal.Get(countryId);
        }

        public List<Player> GetPlayerWithTeam(int teamId)
        {
            return _playerDal.GetAll(x => x.TeamID == teamId).ToList();
        }

        public List<Player> GetAll(Expression<Func<Player, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
