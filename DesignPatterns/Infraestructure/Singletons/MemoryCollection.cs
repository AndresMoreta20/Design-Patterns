using DesignPatterns.Models;
using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.Singletons
{
    public class MemoryCollection
    {
        private static MemoryCollection _instance;
        public ICollection<Vehicle> Vehicle { get; set; }

        public static MemoryCollection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MemoryCollection();
                }
                return _instance;
            }
        }

        private MemoryCollection()
        {
            Vehicle = new List<Vehicle>();
        }
    }
}
