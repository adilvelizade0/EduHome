using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Services;
using DAL.Models;

namespace Business.Implementations
{
    public class SliderRepository: ISlidersService
    {
        public Task<Slider> Get(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Slider>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Create(Slider entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Slider entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int? id)
        {
            throw new System.NotImplementedException();
        }
    }
}