namespace HospitalSystem.Models.PatientModel
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> AllPatient { get; }
        void AddPatient(Patient patient);
        Patient? GetPatientById(int patientid);
        void UpdatePatient(Patient patient);
        void DeletePatient(int patient);
    }
}
