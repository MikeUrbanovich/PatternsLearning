using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.ServiceLocator.ServiceLocator
{
    public interface IServiceLocator
    {
        T GetService<T>();
        T2 GetService<T1, T2>();
    }
}
