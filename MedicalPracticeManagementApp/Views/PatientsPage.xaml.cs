namespace MedicalPracticeManagementApp_.Views;

namespace SearchBoxExample;

public partial class PatientsPage : ContentPage
{
    public PatientsPage()
    {
        InitializeComponent();
        BindingContext = new PatientsViewModel();
    }
}
