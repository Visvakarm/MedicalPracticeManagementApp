using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using static MedicalPracticeManagementApp_.Models.PatientRecord;

public class PatientsViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Patient> Patients { get; set; } = new();
    public Patient SelectedPatient { get; set; }
    public ICommand AddPatientCommand { get; }
    public ICommand EditPatientCommand { get; }
    public ICommand DeletePatientCommand { get; }

    public PatientsViewModel()
    {
        // Commands
        AddPatientCommand = new Command(AddPatient);
        EditPatientCommand = new Command<Patient>(EditPatient);
        DeletePatientCommand = new Command<Patient>(DeletePatient);

        // Mock Data
        Patients.Add(new Patient { Id = 1, Name = "John Doe", Address = "123 Main St", Birthdate = DateTime.Now.AddYears(-30), Gender = "Male", Race = "Asian", Diagnoses = "Hypertension", Prescriptions = "Lisinopril" });
        Patients.Add(new Patient { Id = 2, Name = "Jane Smith", Address = "456 Elm St", Birthdate = DateTime.Now.AddYears(-40), Gender = "Female", Race = "Caucasian", Diagnoses = "Diabetes", Prescriptions = "Metformin" });
    }

    private void AddPatient()
    {
        Patients.Add(new Patient
        {
            Id = Patients.Count + 1,
            Name = "New Patient",
            Address = "Unknown Address",
            Birthdate = DateTime.Today,
            Gender = "Unknown",
            Race = "Unknown",
            Diagnoses = "Unknown",
            Prescriptions = "None"
        });
    }

    private void EditPatient(Patient patient)
    {
        if (patient != null)
        {
            // Logic to open an edit form (could use a modal or navigate to another page)
            patient.Name = "Edited Name"; // Example change
        }
    }

    private void DeletePatient(Patient patient)
    {
        if (patient != null)
        {
            Patients.Remove(patient);
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
