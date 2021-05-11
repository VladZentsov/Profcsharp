namespace RecordPrototype
{

    public record RecordCar
    {
        public RecordCar()
        {
            this.Model = "default Model";
            this.Brand = "default Brand";
        }
        public RecordCar(string model, string brand)
        {
            this.Model = model;
            this.Brand = brand;
        }

        public string Model { get; set; } = "init";
        public string Brand { get; set; }

        public override string ToString() => $"Model: {Model}  Brand: {Brand}";
    }
}