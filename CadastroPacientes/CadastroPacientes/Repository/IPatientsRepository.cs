using PatientRegistration.Models;

namespace PatientRegistration.Repository
{
    public interface IPatientsRepository
    {
        Task<IEnumerable<Patients>> GetAllPatientsAsync();
        Task<Patients> GetPatientByIdAsync(int id);
        Task AddPatientAsync(Patients patient);
        Task UpdatePatientAsync(Patients patient);
        Task DeletePatientAsync(int id);
    }
}
