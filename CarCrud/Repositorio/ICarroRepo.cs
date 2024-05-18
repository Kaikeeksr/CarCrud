using CarCrud.Models;

namespace CarCrud.Repositorio
{
    public interface ICarroRepo
    {
        CarModel ListByID(int id);
        List<CarModel> GetAll();
        CarModel Add(CarModel car);
        CarModel Update(CarModel car);
        bool Delete(int id);
    }
}
