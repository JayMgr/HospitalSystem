namespace HospitalSystem.Models.Service_Model
{
    public interface IServiceRepository
    {
        IEnumerable<Service> AllService { get; }
        void AddService(Service service);
        Service? GetServiceById(int ServiceId);
        void UpdateService(Service service);
        void DeleteService(int service);
    }
}
