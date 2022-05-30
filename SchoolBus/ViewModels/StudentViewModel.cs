namespace SchoolBus.ViewModels;

public class StudentViewModel
{
    private readonly SchoolBusDbContext _dbContext;

    public ObservableCollection<Student> Students { get; set; }


    public StudentViewModel()
    {
        _dbContext = DI_Container.Container.Resolve<SchoolBusDbContext>();

        Students = new(_dbContext.Students);
    }
}
