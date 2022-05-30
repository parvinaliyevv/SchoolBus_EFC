namespace SchoolBus.Views;

public partial class StudentView : Page
{
    public StudentView()
    {
        InitializeComponent();

        DataContext = new StudentViewModel();
    }
}
