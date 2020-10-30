using Film_Information.Business.Abstract;
using NLog;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Information.Business.Log
{
    public class NLogError : INLog
    {
        public void Eror(string mesaj)
        {
            var log = LogManager.GetLogger("Logger");
            log.Log(LogLevel.Error, mesaj);
            


        }
    }
}
