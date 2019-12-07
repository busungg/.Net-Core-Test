using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.DependencyInjection.Services.Interface;

namespace Test.DependencyInjection.Services.Object
{
    public class Dependency2 : IDependency
    {
        public string log(string msg)
        {
            return $"Dependency2 logs : {msg}, date: {DateTime.Now.ToString()}";
        }
    }
}
