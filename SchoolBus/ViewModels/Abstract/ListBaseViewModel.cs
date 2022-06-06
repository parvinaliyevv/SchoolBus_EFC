namespace SchoolBus.ViewModels.Abstract;

public abstract class ListBaseViewModel<T>: DependencyObject, ISearchViewModel, IAddViewModel<T>  where T : new() 
{
    protected readonly SchoolBusDbContext _dbContext;

    public ObservableCollection<T> Items
    {
        get { return (ObservableCollection<T>)GetValue(ItemsProperty); }
        set { SetValue(ItemsProperty, value); }
    }
    public static readonly DependencyProperty ItemsProperty =
        DependencyProperty.Register("Items", typeof(ObservableCollection<T>), typeof(ListBaseViewModel<T>));

    public RelayCommand InsertCommand { get; set; }
    public T InsertItem
    {
        get { return (T)GetValue(InsertItemProperty); }
        set { SetValue(InsertItemProperty, value); }
    }
    public static readonly DependencyProperty InsertItemProperty =
        DependencyProperty.Register("InsertItem", typeof(T), typeof(ListBaseViewModel<T>));

    public RelayCommand SearchCommand { get; set; }
    public string SearchValue { get; set; }


    public ListBaseViewModel()
    {
        _dbContext = DI_Container.Container.Resolve<SchoolBusDbContext>();

        InsertCommand = new(sender => InsertDatabase(), sender => CheckItem());
        InsertItem = new();

        SearchCommand = new(sender => SearchItems());
        SearchValue = string.Empty;
    }


    public abstract void SearchItems();

    public abstract bool CheckItem();

    public virtual void InsertDatabase()
    {
        try
        {
            _dbContext.Add(InsertItem);
            _dbContext.SaveChanges();

            Items.Add(InsertItem);
        }
        catch
        {

        }

        InsertItem = new();
        MaterialDesignThemes.Wpf.DialogHost.CloseDialogCommand.Execute(null, null);
    }
}
