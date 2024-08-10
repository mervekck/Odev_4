using Odev_4.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_4.Models.Classes
{
    public class XmlLog : ILog
    {
        public string LogKaydet(string mesaj)
        {
            return mesaj + " XML e kaydedildi";
        }
    }
}
