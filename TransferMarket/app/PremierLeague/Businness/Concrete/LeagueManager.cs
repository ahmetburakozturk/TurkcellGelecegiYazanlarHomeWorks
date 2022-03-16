using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PremierLeague.Entities;

namespace PremierLeague.Businness.Concrete
{
    public class LeagueManager :IGenericDal<League>
    {
        private IGenericDal<League> _leagueDal;

        public LeagueManager(IGenericDal<League> leagueDal)
        {
            _leagueDal = leagueDal;
        }
        public void Add(League entity)
        {
            _leagueDal.Add(entity);
        }

        public void Update(League entity)
        {
            _leagueDal.Update(entity);
        }

        public void Delete(League entity)
        {
            _leagueDal.Delete(entity);
        }

        public List<League> GetAll()
        {
            return _leagueDal.GetAll();
        }

        public League Get(int id)
        {
            return _leagueDal.Get(id);
        }

        public List<League> GetAll(Expression<Func<League, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
