namespace SchoolBus.ViewModels.Abstract;

public interface IAddViewModel<T>
{
    RelayCommand InsertCommand { get; set; }

    T InsertItem { get; set; }
}
