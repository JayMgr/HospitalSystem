using HospitalSystem.Models;

namespace HospitalSystem.View_Models.DoctorViewModel
{
    public class DoctorListViewModel
    {
        public IEnumerable<Doctor> Doctors { get; }

        public DoctorListViewModel(IEnumerable<Doctor> Doctor)
        {

            Doctors = Doctor;
        }
    }
}
