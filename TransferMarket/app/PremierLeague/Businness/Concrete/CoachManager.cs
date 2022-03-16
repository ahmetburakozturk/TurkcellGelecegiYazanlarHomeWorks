using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PremierLeague.Entities;

namespace PremierLeague.Businness.Concrete
{
    public class CoachManager :IGenericDal<Coach>
    {
        private IGenericDal<Coach> _coachDal;

        public CoachManager(IGenericDal<Coach> coachDal)
        {
            _coachDal = coachDal;
        }
        public void Add(Coach entity)
        {
            _coachDal.Add(entity);
        }

        public void Update(Coach entity)
        {
            _coachDal.Update(entity);
        }

        public void Delete(Coach entity)
        {
            _coachDal.Delete(entity);
        }

        public List<Coach> GetAll()
        {
            return _coachDal.GetAll();
        }

        public Coach Get(int id)
        {
            return _coachDal.Get(id);
        }

        public List<Coach> GetAll(Expression<Func<Coach, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
