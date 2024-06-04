﻿
namespace DesignPattern.Estrutural.Adapter
{
    // adaptee class
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Log Customizado - " + message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine("Log Customizado - " + exception.Message);
        }
    }
}
