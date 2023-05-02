using SensingTheEnvironment.Models;

namespace SensingTheEnvironment.Repositories
{
    public class SensorDataRepository
    {
        private readonly List<SensorData> _repository;

        public SensorDataRepository()
        {
            _repository = new List<SensorData>()
            {
                new SensorData() {Temperature = 24.6f, Pressure = 945.78f, Humidity = 31.43f}
            };
        }

        public List<SensorData> GetAll()
        {
            return _repository;
        }

        public SensorData Add(SensorData newReading)
        {
            _repository.Add(newReading);
            return newReading;
        }
    }
}
