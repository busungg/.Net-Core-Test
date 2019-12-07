using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.DependencyInjection.Services.Interface;

namespace Test.DependencyInjection.Services.Object
{
    public class Dependency3 : IDependency2
    {
        public string log(string msg)
        {
            return $"Dependency3 logs : {msg}, date: {DateTime.Now.ToString()}";
        }
    }
}
