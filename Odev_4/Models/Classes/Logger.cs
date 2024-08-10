using Microsoft.VisualBasic.Logging;
using Odev_4.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_4.Models.Classes
{
    public class Logger: ILog
    {
        public ILog _ilog;
        public Logger(ILog ilog)
        {
            _ilog = ilog;
        }

        public string LogKaydet(string mesaj)
        {
            return _ilog.LogKaydet(mesaj);
        }
    }
}
