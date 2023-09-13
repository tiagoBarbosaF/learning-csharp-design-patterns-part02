namespace DesignPatternsPart02.Classes.Singleton;

public class ServiceSingleton
{
    private static Service _instance = new Service();

    public Service Instance => _instance;
}