using DesignPatterns.Infraestructure.Singletons;
using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Repositories
{
    public class MyVehiclesRepository : IVehicleRepository
    {
        private readonly MemoryCollection _memoryCollection = MemoryCollection.Instance;

        public MyVehiclesRepository()
        {
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _memoryCollection.Vehicle.Add(vehicle);
        }

        public Vehicle Find(string id)
        {
            return _memoryCollection.Vehicle.FirstOrDefault(v => v.ID.Equals(new Guid(id)));
        }

        public ICollection<Vehicle> GetVehicles()
        {
            return _memoryCollection.Vehicle;
        }


    }
}

