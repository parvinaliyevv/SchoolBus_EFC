namespace SchoolBus.ViewModels.Abstract;

public abstract class ListBaseViewModel<T> : ISearchViewModel, IAddViewModel<T>
{
    protected readonly SchoolBusDbContext _dbContext;

    public ObservableCollection<T> Items { get; set; }

    public RelayCommand InsertCommand { get; set; }
    public T InsertItem { get; set; }

    public string SearchValue { get; set; }


    public ListBaseViewModel()
    {
        _dbContext = DI_Container.Container.Resolve<SchoolBusDbContext>();

        InsertCommand = new(sender => InsertDatabase(), sender => CheckItem());

        SearchValue = string.Empty;
    }

    
    public abstract bool CheckItem();

    public virtual void InsertDatabase()
    {
        try
        {
            _dbContext.Add(InsertItem);
            _dbContext.SaveChanges();
        }
        catch
        {

        }
    }
}
