using HospitalSystem.Models.PatientModel;
using HospitalSystem.Models;
using HospitalSystem.View_Models.PatientViewModel;
using HospitalSystem.View_Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.Controllers
{
    public class PatientController(IPatientRepository patientRepository) : Controller
    {

        private readonly IPatientRepository _patientRepository = patientRepository;

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult PatientList()
        {

            PatientListViewModel patientListViewModel = new PatientListViewModel(_patientRepository.AllPatient);
            return View(patientListViewModel);
        }

        public ActionResult AddPatient()
        {
            var viewModel = new AddPatientViewModel();
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPatient(AddPatientViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                Patient newPatient = new Patient
                {
                    Name = viewModel.Name,
                    Number = viewModel.Number,
                    Address = viewModel.Address,
                    Gender = viewModel.Gender,
                    Description = viewModel.Description,
                    Age = viewModel.Age,

                };
                _patientRepository.AddPatient(newPatient);
            }
            return RedirectToAction("PatientList");
        }
        [HttpGet]
        public ActionResult Patient(int id)
        {
            var patient = _patientRepository.GetPatientById(id);

            var editPatientViewModel = new UpdatePatientViewModel
            {
                PatientId = patient.PatientId,
                Name = patient.Name,
                Number = patient.Number,
                Address = patient.Address,
                Description = patient.Description,
                Gender = patient.Gender,
                Age = patient.Age,  

            };


            return View(editPatientViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdatePatient(UpdatePatientViewModel model)
        {
            var patient = _patientRepository.GetPatientById(model.PatientId);

            patient.Name = model.Name;
            patient.Number = model.Number;
            patient.Address = model.Address;
            patient.Gender = model.Gender;
            patient.Description = model.Description;
            patient.Age = model.Age;


            _patientRepository.UpdatePatient(patient);
            return RedirectToAction("PatientList");
        }
        public IActionResult DeletePatient(int id)
        {

            _patientRepository.DeletePatient(id);

            return RedirectToAction("PatientList");


        }
    }
}
