namespace SchoolBus.ViewModels.Abstract;

public interface IDeleteViewModel
{
    RelayCommand DeleteCommand { get; set; }

    void DeleteItem(object sender);
}
