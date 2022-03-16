using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PremierLeague.Entities;

namespace PremierLeague.Businness.Concrete
{
    public class TeamManager : IGenericDal<Team>
    {
        private IGenericDal<Team> _teamDal;

        public TeamManager(IGenericDal<Team> teamDal)
        {
            _teamDal = teamDal;
        }
        public void Add(Team entity)
        {
            _teamDal.Add(entity);
        }

        public void Update(Team entity)
        {
            _teamDal.Update(entity);
        }

        public void Delete(Team entity)
        {
            _teamDal.Delete(entity);
        }

        public List<Team> GetAll()
        {
            return _teamDal.GetAll();
        }

        public Team Get(int id)
        {
            return _teamDal.Get(id);
        }

        public List<Team> GetAll(Expression<Func<Team, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
