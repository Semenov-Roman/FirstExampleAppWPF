using System.Collections.Generic;

namespace FirstExampleAppWPF.MyModels;

public class DataBase
{
    public static IEnumerable<Person> GetPerson()
    {
        return new Person[]
        {
            new Person
            {
                Name = "Dima",
                Age = 19,
                Address = new AddressInfo
                {
                    Apartament = 10,
                    Number = 35,
                    Street = "Пушкина"
                }
            },
            new Person
            {
                Name = "Dima2",
                Age = 26,
                Address = new AddressInfo
                {
                    Apartament = 15,
                    Number = 25,
                    Street = "Колотушкина"
                }
            },
            new Person
            {
                Name = "Sonya",
                Age = 18,
                Address = new AddressInfo
                {
                    Apartament = 39,
                    Number = 4,
                    Street = "Харьковская"
                }
            }
        };
    }
}