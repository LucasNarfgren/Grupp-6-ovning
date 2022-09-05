namespace Grupp6_ovning.Models
{
    public interface IApplicationRepository
    {
        IEnumerable<Application> GetAllApplications();

        Application GetApplicationById(int id);

        Application CreateApplication();

        Application UpdateApplication(Application application);
    }
}
