using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.DependencyInjection.Services.Interface
{
    public interface IDependency
    {
        string log(string msg);
    }
}
