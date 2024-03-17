using HospitalSystem.Models;

namespace HospitalSystem.View_Models.ServiceViewModel
{
    public class ServiceListViewModel
    {
        public IEnumerable<Service> Services { get; }

        public ServiceListViewModel(IEnumerable<Service> Service)
        {

            Services = Service;
        }
    }
}
