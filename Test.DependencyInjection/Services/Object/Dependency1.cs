using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.DependencyInjection.Services.Interface;

namespace Test.DependencyInjection.Services.Object
{
    public class Dependency1 : IDependency
    {
        public string log(string msg)
        {
            return $"Dependency1 logs : {msg}, date: {DateTime.Now.ToString()}";
        }
    }
}
