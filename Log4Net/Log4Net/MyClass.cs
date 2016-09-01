
namespace Log4Net
{
    class MyClass
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(MyClass));

        public void foo(int value)
        {
            log.Debug("Funktion foo() wird ausgeführt.");
            log.Debug("Parameter value: " + value);
            log.Info("Helloooo Fooo......");
            log.Debug("Funktion foo() wird verlassen.");

            log.Error("Error 233");
        }
    }
}
