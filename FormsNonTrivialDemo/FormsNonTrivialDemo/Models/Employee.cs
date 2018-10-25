using System.Collections.Generic;
using Xamarin.Forms;

namespace FormsNonTrivialDemo.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsVIP { get; set; }

        public static readonly IEnumerable<Employee> SampleData = new Employee[]
        {
            new Employee(){ Id = "ID1", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID2", FirstName = "Name12",LastName = "LastName2"},
            new Employee(){ Id = "ID3", FirstName = "Name13",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID4", FirstName = "Name11",LastName = "LastName2"},
            new Employee(){ Id = "ID5", FirstName = "Name12",LastName = "LastName2"},
            new Employee(){ Id = "ID6", FirstName = "Name41",LastName = "LastName2"},
            new Employee(){ Id = "ID7", FirstName = "Name51",LastName = "LastName2"},
            new Employee(){ Id = "ID8", FirstName = "Name61",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID9", FirstName = "Name12",LastName = "LastName2"},
            new Employee(){ Id = "ID10", FirstName = "Name12",LastName = "LastName2"},
            new Employee(){ Id = "ID11", FirstName = "Name21",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID12", FirstName = "Name21",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID13", FirstName = "Name12",LastName = "LastName2"},
            new Employee(){ Id = "ID14", FirstName = "Name16",LastName = "LastName2"},
            new Employee(){ Id = "ID15", FirstName = "Name17",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID16", FirstName = "Name81",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID17", FirstName = "Name91",LastName = "LastName2"},
            new Employee(){ Id = "ID18", FirstName = "Name01",LastName = "LastName2"},
            new Employee(){ Id = "ID19", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID20", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID21", FirstName = "Name1",LastName = "LastName2"},
            new Employee(){ Id = "ID22", FirstName = "Name1",LastName = "LastName2"},
            new Employee(){ Id = "ID23", FirstName = "Name1",LastName = "LastName2"},
            new Employee(){ Id = "ID24", FirstName = "Name1",LastName = "LastName2"},
            new Employee(){ Id = "ID25", FirstName = "Name1",LastName = "LastName2"},
            new Employee(){ Id = "ID26", FirstName = "Name1",LastName = "LastName2"},
            new Employee(){ Id = "ID27", FirstName = "Name1",LastName = "LastName2"},
            new Employee(){ Id = "ID28", FirstName = "Name1",LastName = "LastName2"},
            new Employee(){ Id = "ID29", FirstName = "Name1",LastName = "LastName2"},
            new Employee(){ Id = "ID30", FirstName = "Name1",LastName = "LastName2"},
            new Employee(){ Id = "ID31", FirstName = "Name1",LastName = "LastName2"},
            new Employee(){ Id = "ID32", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID33", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID34", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID35", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID36", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID37", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID38", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID39", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID40", FirstName = "Name1",LastName = "LastName2", IsVIP = true },
            new Employee(){ Id = "ID41", FirstName = "Name1",LastName = "LastName2", IsVIP = true }
        };
    }
}
