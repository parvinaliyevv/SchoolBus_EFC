namespace SchoolBus.Views;

public partial class ParentView : Page
{
    public ParentView()
    {
        InitializeComponent();

        DataContext = new ParentViewModel();
    }
}
