using Odev_4.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Odev_4.Models.Factory
{
    public class LogFactory
    {
        public ILog NesneOlustur(string className)
        {
            var newInstance = Assembly.GetAssembly(typeof(ILog)).CreateInstance("Odev_4.Models.Classes." + className);
            return (ILog) newInstance;
        }
    }
}
