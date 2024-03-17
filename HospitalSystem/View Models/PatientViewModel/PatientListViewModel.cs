using HospitalSystem.Models;

namespace HospitalSystem.View_Models.PatientViewModel
{
    public class PatientListViewModel
    {
        public IEnumerable<Patient> Patients { get; }

        public PatientListViewModel(IEnumerable<Patient> patients)
        {
            Patients = patients;
        }
    }
}

