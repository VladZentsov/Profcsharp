using System;

namespace RecordPrototype
{
    public class ClassCar : IEquatable<ClassCar>
    {

        public ClassCar()
        {
            this.Model = "default Model";
            this.Brand = "default Brand";
        }

        public ClassCar(string model, string brand)
        {
            this.Model = model;
            this.Brand = brand;
        }

        public string Model { get; set; } = "init Model";
        public string Brand { get; set; }
        
        public override string ToString() => $"Model: {Model}  Brand: {Brand}";

        public bool Equals(ClassCar other)
        {
            return other.Model == this.Model
                   && other.Brand == this.Brand;
        }

        public static bool operator ==(ClassCar x, ClassCar y)
        {
            return x.Brand == y.Brand
                   && x.Model == y.Model;
        }

        public static bool operator !=(ClassCar x, ClassCar y)
        {
            return x.Brand != y.Model
                   || x.Model == y.Model;
        }


        public override bool Equals(object obj)
        {
            return (obj is StructCar) && this.Equals(obj);
        }

        public override int GetHashCode()
        {
            return string.Concat(Model, Brand).GetHashCode();
        }

    }
}