using System;
using System.IO;
using System.Xml.Serialization;
using static RecordPrototype.Program;

namespace RecordPrototype
{
    class Program
    {
        static void ChangeStruct(StructCar car)
        {
            car.Model = "ChangeStructModel";
            car.Brand = "ChangeStructBrand";
        }

        static void ChangeCLass(ClassCar car)
        {
            car.Model = "ChangeCLassModel";
            car.Brand = "ChangeCLassBrand";
        }

        static void ChangeRecord(RecordCar car)
        {
            car.Model = "ChangeRecordModel";
            car.Brand = "ChangeRecordBrand";
        }

        static void Main(string[] args)
        {
            // https://youtu.be/4JBjBGztMso

            #region Intro

            ////>> StructCar ──────────────────────────────────────────────────
            ////original Struct car: Model: Веста Brand: Лада
            ////ChangeStruct original: Model: Веста Brand: Лада
            //Console.WriteLine($"\n>> StructCar {new String('─', 50)}");
            //StructCar originalStructCar = new StructCar("Веста", "Лада");
            //Console.WriteLine($"original Struct car: {originalStructCar} ");
            //ChangeStruct(originalStructCar);
            //Console.WriteLine($"ChangeStruct original: {originalStructCar} ");



            ////>> ClassCar ──────────────────────────────────────────────────
            ////original car: Model: Веста Brand: Лада
            ////ChangeCLass original: Model: ChangeCLassModel Brand: ChangeCLassBrand
            //Console.WriteLine($"\n>> ClassCar {new String('─', 50)}");
            //ClassCar originalClassCar = new ClassCar("Веста", "Лада");
            //Console.WriteLine($"original car: {originalClassCar} ");
            //ChangeCLass(originalClassCar);
            //Console.WriteLine($"ChangeCLass original: {originalClassCar} ");


            ////>> RecordCar ──────────────────────────────────────────────────
            ////original car: Model: Веста Brand: Лада
            ////ChangeRecord original: Model: ChangeRecordModel Brand: ChangeRecordBrand
            //Console.WriteLine($"\n>> RecordCar {new String('─', 50)}");
            //RecordCar originalRecordCar = new RecordCar("Веста", "Лада");
            //Console.WriteLine($"original car: {originalRecordCar} ");
            //ChangeRecord(originalRecordCar);

            //Console.WriteLine($"ChangeRecord original: {originalRecordCar} ");
            #endregion

            #region StructCar

            //StructCar originalStructCar = new StructCar("Vesta", "Lada");

            //string jsonVesta = originalStructCar.SerializeObject();
            //Console.WriteLine(jsonVesta);

            //StructCar deserializableVesta = jsonVesta.DeserializeObject<StructCar>();

            //Console.WriteLine($"deserializable car: {deserializableVesta}");

            //// Ошибка CS0019  Оператор "==" невозможно применить к операнду типа
            //// "StructCar" и "StructCar"

            //Console.WriteLine(originalStructCar == deserializableVesta); // True
            //Console.WriteLine(originalStructCar.Equals(deserializableVesta)); // True

            #endregion

            #region ClassCar

            //ClassCar originalClassCar = new ClassCar("Веста", "Лада");

            //string jsonVesta = originalClassCar.SerializeObject();
            //Console.WriteLine(jsonVesta);

            //ClassCar deserializableVesta = jsonVesta.DeserializeObject<ClassCar>();

            //Console.WriteLine($"original       car: {originalClassCar}");
            //Console.WriteLine($"deserializable car: {deserializableVesta}");

            //Console.WriteLine(originalClassCar == deserializableVesta); // True
            //Console.WriteLine(originalClassCar.Equals(deserializableVesta)); // True


            #endregion

            #region RecordCar

            RecordCar originalRecordCar = new RecordCar("Веста", "Лада");

            originalRecordCar.Brand = "Audi";
            
            string jsonVesta = originalRecordCar.SerializeObject();
            Console.WriteLine(jsonVesta);

            RecordCar deserializableVesta = jsonVesta.DeserializeObject<RecordCar>();

            Console.WriteLine($"original       car: {originalRecordCar}");
            Console.WriteLine($"deserializable car: {deserializableVesta}");

            Console.WriteLine(originalRecordCar == deserializableVesta); // True
            Console.WriteLine(originalRecordCar.Equals(deserializableVesta)); // True
            Console.WriteLine(originalRecordCar.GetHashCode());
            Console.WriteLine(deserializableVesta.GetHashCode());

            #endregion
        }
    }
}