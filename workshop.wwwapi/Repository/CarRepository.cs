using workshop.wwwapi.Data;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository
{



    public class CarRepository : IRepository
    {

        DataContext _dbContext; 

        public CarRepository(DataContext db)
        {
            this._dbContext = db;
        }

        public Car AddCar(Car entity)
        {
            // _dbContext.Cars.Add(entity);
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public List<Car> GetCars()
        {
           return _dbContext.Cars.ToList();
        }
    }
}
