namespace WebApplication1.Services
{
    public interface IVersionService
    {
        string DefaultVersion { get; }
        string CurrentVersion { get; }
    }
}
