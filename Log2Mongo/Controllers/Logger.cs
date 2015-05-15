using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ConsoleApplication1
{
    public class Logger:ILogger
    {
        private readonly ILog _log;

        public Logger(string type)
        {
            this._log = LogManager.GetLogger(type);
        }

        public void Debug(object message)
        {
            this._log.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            this._log.Debug(message, exception);
        }

        public void Error(object message)
        {
            this._log.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            this._log.Error(message, exception);
        }

        public void Fatal(object message)
        {
            this._log.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            this._log.Fatal(message, exception);
        }

        public void Info(object message)
        {
            this._log.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            this._log.Info(message, exception);
        }

        public void Warn(object message)
        {
            this._log.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            this._log.Warn(message, exception);
        }
    }
}
