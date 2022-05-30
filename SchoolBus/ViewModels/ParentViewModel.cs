namespace SchoolBus.ViewModels;

public class ParentViewModel
{
    private readonly SchoolBusDbContext _dbContext;

    public ObservableCollection<Parent> Parents { get; set; }


    public ParentViewModel()
    {
        _dbContext = DI_Container.Container.Resolve<SchoolBusDbContext>();

        Parents = new(_dbContext.Parents);
    }
}
