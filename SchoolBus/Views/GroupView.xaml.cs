namespace SchoolBus.Views;

public partial class GroupView : Page
{
    public GroupView()
    {
        InitializeComponent();

        DataContext = new GroupViewModel();
    }
}
