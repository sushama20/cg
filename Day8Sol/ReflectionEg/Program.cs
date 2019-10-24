using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ReflectionEg
{
    class Program
    {
        static void Main(string[] args)
        {
            //assembl path
            string asmPath = @"C:\Capgemini\Day8\Day8Sol\MyLogic\bin\Debug\MyLogic.dll";
            Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] allTypes = asm.GetTypes();
            Console.WriteLine("total types:{0}",allTypes.Length);
            foreach (var item in allTypes)
            {
                Console.WriteLine("name: {0},full name: {1} namespace: {2}",item.Name,item.FullName,item.Namespace);

            }

            Type tempType = allTypes[2];//class
            ConstructorInfo[] allCtor = tempType.GetConstructors();
            MemberInfo[] allMembers = tempType.GetMembers();
            MethodInfo[] methodInfos = tempType.GetMethods();
            Console.WriteLine("total Constructor:{0}", allCtor.Length);
            Console.WriteLine("total Members:{0}", allMembers.Length);
            Console.WriteLine("total Method:{0}", methodInfos.Length);
            object obj = Activator.CreateInstance(tempType);
            MethodInfo func = methodInfos[1];//functions
          


            foreach (var item in methodInfos)
            {
                Console.WriteLine("name: {0},IsPublic: {1} no of parameters: {2}", item.Name, item.IsPublic, item.GetParameters().Length);

            }

            Console.WriteLine("*************************************************");

            ParameterInfo[] prms=func.GetParameters();
            if (prms.Length == 0)
            {
                func.Invoke(obj, null);
            }
            else
            {
                object[] values = new object[prms.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine("enter value for function with type {0}",prms[i].ParameterType);
                    if (prms[i].ParameterType == typeof(System.Int32))
                    {
                        values[i] = Convert.ToInt32(Console.ReadLine());

                    }
                    else
                    {
                        values[i]=Console.ReadLine();
                    }

                }

                func.Invoke(obj, values);
               // methodInfos[0].Invoke(obj,null);
            }
            Console.ReadLine();

        }
    }
}
