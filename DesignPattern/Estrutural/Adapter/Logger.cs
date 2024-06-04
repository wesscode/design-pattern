﻿
namespace DesignPattern.Estrutural.Adapter
{
    // Target class
    /*
     * Classe que quero substituir para aplicar o padrão.
     */
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log padrão - " + message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Log padrão - " + exception.Message);
        }
    }
}