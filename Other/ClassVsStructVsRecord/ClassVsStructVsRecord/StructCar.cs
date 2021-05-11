using System;

namespace RecordPrototype
{
    public struct StructCar : IEquatable<StructCar>
    {
        // Ошибка CS0568
        // Структуры не могут содержать явных конструкторов без параметров

        //public StructCar()
        //{
        //    this.Model = "default Model";
        //    this.Brand = "default Brand";
        //}

        // Ошибка CS0843 Автоматически реализованное свойство
        // "StructCar.Brand" должно быть полностью определено
        // до возврата управления в вызывающий метод
        public StructCar(string model, string brand)
        {
            this.Model = model;
            //
            this.Brand = brand;
        }

        // Ошибка CS0573 "StructCar": в структуре не могут
        // содержаться инициализаторы свойств или полей экземпляров.

        public string Model { get; set; } // = "init Model";
        public string Brand { get; set; }
        
        public override string ToString() => $"Model: {Model}  Brand: {Brand}";

        public static bool operator == (StructCar x, StructCar y)
        {
            return x.Brand == y.Brand
                   && x.Model == y.Model;
        }

        public static bool operator !=(StructCar x, StructCar y)
        {
            return x.Brand != y.Model
                   || x.Model == y.Model;
        }

        //Предупреждение CS0661	"StructCar" определяет оператор "==" или оператор "!=",
        //но не переопределяет Object.GetHashCode().	
            
        //Предупреждение  CS0660	"StructCar" определяет оператор "==" или оператор "!=",
        //но не переопределяет Object.Equals(object o).
            

        public override bool Equals(object obj)
        {
           return (obj is StructCar) && this.Equals(obj);
        }

        public override int GetHashCode()
        {
            return string.Concat(Model,Brand).GetHashCode();
        }
 
        public bool Equals(StructCar other)
        {
            return other.Brand == this.Model
                  || other.Model == this.Model;
        }
    }
}