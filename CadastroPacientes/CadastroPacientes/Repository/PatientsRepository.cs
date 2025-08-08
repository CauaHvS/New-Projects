using Microsoft.EntityFrameworkCore;
using PatientRegistration.Data;
using PatientRegistration.Models;

namespace PatientRegistration.Repository
{
    public class PatientsRepository : IPatientsRepository
    {
        private readonly AppDbContext _patients;
        public PatientsRepository(AppDbContext patients)
        {
            _patients = patients;
        }
        public async Task<IEnumerable<Patients>> GetAllPatientsAsync()
        {
            return await _patients.Patients.ToListAsync();
        }
        public async Task<Patients> GetPatientByIdAsync(int id)
        {
            var patient = await _patients.Patients.FindAsync(id);
            if (patient == null)
                throw new InvalidOperationException($"Paciente com ID {id} não encontrado.");
            return patient;
        }
        public async Task AddPatientAsync(Patients patient)
        {
            _patients.Patients.Add(patient);
            await _patients.SaveChangesAsync();
        }
        public async Task UpdatePatientAsync(Patients patient)
        {
            _patients.Patients.Update(patient);
            await _patients.SaveChangesAsync();
        }
        public async Task DeletePatientAsync(int id)
        {
            var patient = await _patients.Patients.FindAsync(id);
            if (patient != null)
            {
                _patients.Patients.Remove(patient);
                await _patients.SaveChangesAsync();
            }

        }
        public async Task<IEnumerable<Patients>> GetPatientsByNameAsync(string name)
        {
            return await _patients.Patients
                .Where(p => p.Nome.Contains(name))
                .ToListAsync();
        }
        public async Task<IEnumerable<Patients>> GetPatientsByDateOfBirthAsync(DateTime dateOfBirth)
        {
            return await _patients.Patients
                .Where(p => p.DateOfBirth == dateOfBirth)
                .ToListAsync();
        }
        public async Task<IEnumerable<Patients>> GetPatientsByCPFAsync(string cpf)
        {
            return await _patients.Patients
                .Where(p => p.CPF == cpf)
                .ToListAsync();
        }

    }
}