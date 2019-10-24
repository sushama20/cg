using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using Newtonsoft.Json;
namespace Serialization
{
    class Program
    {

        static void Main(string[] args)
        {
           // BinaryFormatter binaryFormatter = new BinaryFormatter();
            Employee obj = new Employee();
            Console.WriteLine("enter choice W to write andd R for reading the data");
            string ch = Console.ReadLine();
            //----binary formatter-----------------
            // Stream stream = File.Open("C:/Capgemini/fileHandling/data.dat",FileMode.OpenOrCreate,FileAccess.ReadWrite);//returns object of Stream
            //----------------soap formatter----------------
            //  Stream stream = File.Open("C:/Capgemini/fileHandling/data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);//returns object of Stream
          // SoapFormatter soapFormatter = new SoapFormatter();
            //----------------json formatter----------
            Stream stream = File.Open("C:/Capgemini/fileHandling/data1.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);//returns object of Stream
          

            switch (ch)
            {
                case "W":
                    Console.WriteLine("enter values for id,name,salary");
                    obj.id = Convert.ToInt32(Console.ReadLine());
                    obj.name = Console.ReadLine();
                    obj.salary = Convert.ToInt32(Console.ReadLine());

                    // soapFormatter.Serialize(stream, obj);
                    // binaryFormatter.Serialize(stream, obj);

                    string str = JsonConvert.SerializeObject(obj);
                    StreamWriter streamWriter = new StreamWriter(stream);
                    streamWriter.Write(str);
                    streamWriter.Close();


                    break;

                case "R":
                    // obj = binaryFormatter.Deserialize(stream) as Employee;
                    // obj = soapFormatter.Deserialize(stream) as Employee;

                    StreamReader streamReader = new StreamReader(stream);
                    string tempData = streamReader.ReadToEnd();
                    obj = JsonConvert.DeserializeObject<Employee>(tempData);
                    Console.WriteLine($"Id: {obj.id} Name: {obj.name} salary: {obj.salary}");
                    break;
            }
           stream.Close();
            Console.ReadLine();
        }
    }
}
