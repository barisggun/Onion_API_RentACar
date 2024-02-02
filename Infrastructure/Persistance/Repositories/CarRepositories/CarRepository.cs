using Application.Interfaces.CarInterfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly RentCarContext _context;

        public CarRepository(RentCarContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;

        }
    }
}
