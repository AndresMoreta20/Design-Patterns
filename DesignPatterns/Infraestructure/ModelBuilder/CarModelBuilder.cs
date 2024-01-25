using DesignPatterns.Models;
using System;

namespace DesignPatterns.Infraestructure.ModelBuilder
{
    public class CarBuilder
    {
        public string _brand = "Ford";
        public string _model = "Mustang";
        public string _color = "Red";
        public int _year = DateTime.Now.Year;


        public CarBuilder SetColor(string color)
        {
            _color = color;
            return this;
        }

        public CarBuilder SetBrand(string brand)
        {
            _brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            _model = model;
            return this;
        }

        public CarBuilder SetYear(int year)
        {
            _year = year;
            return this;
        }

        public Car Build()
        {
            return new Car(_color, _brand, _model, _year);
        }
    }
}
