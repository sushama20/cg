using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Serialization
{
    class Class1
    {

        public static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                id = 111,
                name="aaaa",
                salary=555
            };
            string str = JsonConvert.SerializeObject(employee);
            Employee e = null;
            e = JsonConvert.DeserializeObject<Employee>(str);

        }
    }
}
