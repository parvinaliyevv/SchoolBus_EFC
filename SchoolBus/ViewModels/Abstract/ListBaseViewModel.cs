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

        InsertCommand = new(sender => InsertDatabase());

        SearchValue = string.Empty;
    }


    public abstract void InsertDatabase();

    public abstract bool CheckItem();
}
