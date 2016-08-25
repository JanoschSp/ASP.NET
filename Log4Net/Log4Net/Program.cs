
using System;

namespace Log4Net
{
    class Program
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            //log4net.Config.BasicConfigurator.Configure();

            log.Info("Applikation gestartet.");

            MyClass myClass = new MyClass();
            myClass.foo(77);

            log.Info("Applikation wird verlassen.");

            Console.ReadLine();
        }
    }
}
