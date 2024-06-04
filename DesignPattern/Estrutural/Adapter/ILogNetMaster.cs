namespace DesignPattern.Estrutural.Adapter
{
    public interface ILogNetMaster
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}
