using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PremierLeague.Entities;

namespace PremierLeague.Businness.Concrete
{
    public class CountryManager : IGenericDal<Country>
    {
        private IGenericDal<Country> _countryDal;

        public CountryManager(IGenericDal<Country> countrydal)
        {
            _countryDal = countrydal;
        }
        public void Add(Country entity)
        {
            _countryDal.Add(entity);
        }

        public void Delete(Country entity)
        {
            _countryDal.Delete(entity);
        }

        public Country Get(int id)
        {
            return _countryDal.Get(id);
        }

        public List<Country> GetAll(Expression<Func<Country, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAll()
        {
            return _countryDal.GetAll();
        }

        public void Update(Country entity)
        {
            _countryDal.Update(entity);
        }
    }
}
