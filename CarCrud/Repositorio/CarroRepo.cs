using CarCrud.DB;
using CarCrud.Models;

namespace CarCrud.Repositorio
{
    public class CarroRepo : ICarroRepo
    {
        private readonly databaseContext _databaseContext;
        public CarroRepo(databaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public CarModel ListByID(int id)
        {
            return _databaseContext.Carro.FirstOrDefault(x => x.id == id);
        }

        public List<CarModel> GetAll()
        {
            return _databaseContext.Carro.ToList();
        }

        public CarModel Add(CarModel car)
        {
            // Inserção no banco de dados
            _databaseContext.Carro.Add(car);

            // Confirmar a inserção
            _databaseContext.SaveChanges();

            return car;
        }

        public CarModel Update(CarModel car)
        {
            CarModel carDB = ListByID(car.id);

            if (carDB == null) throw new System.Exception("Ocorreu um erro na atualização de regsitro");
            carDB.modelo = car.modelo;
            carDB.renavam = car.renavam;
            carDB.placa = car.placa;
            carDB.ano_fabricacao = car.ano_fabricacao;
            carDB.cor = car.cor;
            carDB.potencia = car.potencia;
            carDB.categoria = car.categoria;

            _databaseContext.Carro.Update(carDB);
            _databaseContext.SaveChanges();

            return carDB;
        }

        public bool Delete(int id)
        {
            CarModel carDB = ListByID(id);
            if (carDB == null) throw new System.Exception("Ocorreu um erro na exclusão de regsitro");
            _databaseContext.Carro.Remove(carDB);

            _databaseContext.SaveChanges();

            return true;
        }
    }
}
