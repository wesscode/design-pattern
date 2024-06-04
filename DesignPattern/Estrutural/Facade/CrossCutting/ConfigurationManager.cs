namespace DesignPattern.Estrutural.Facade.CrossCutting
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string node)
        {
            return new string(Enumerable.Repeat("AAAEEDFGDSFGSHGJYTERTHSBBBBBB", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
