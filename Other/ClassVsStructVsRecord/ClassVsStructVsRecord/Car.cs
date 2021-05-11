using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStructVsRecord
{
    public record Car(string Model, string Brand)
    {
        public string Model { get; set; } = Model;
    }





    static class Demo
    {
        static void View()
        {




            // https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/with-expression?f1url=%3FappId%3DDev16IDEF1%26l%3DRU-RU%26k%3Dk(with_CSharpKeyword);k(SolutionItemsProject);k(SolutionItemsProject);k(DevLang-csharp)%26rd%3Dtrue
            // Выражение with, доступное в C# 9.0 и более поздних версиях,
            // создает копию операнда record с измененными заданными свойствами и полями

            // В случае с членом ссылочного типа при копировании записи
            // копируется только ссылка на экземпляр.
            // Как скопированный, так и исходный экземпляр записи имеют
            // доступ к одному и тому же экземпляру ссылочного типа.
            // В следующем примере продемонстрировано такое поведение.



            Car car = new Car(Model: "RS5", Brand: "Audi");
            car = new Car(Brand: "Audi", Model: "RS5");
            car = new Car("RS5", "Audi");

            // Ошибка CS8852  Значение свойства, задаваемого только при инициализации,
            // или значение индексатора "Car.Brand" может быть присвоено только
            // в инициализаторе объекта, в свойствах "this" или "base" в
            // конструкторе экземпляра или в методе доступа "init".

            car.Model = "A5";
            //конструктор копии
            car = car with { Model = "A5" };


        }

    }
}