namespace SchoolBus.ViewModels.Abstract;

public interface ISearchViewModel
{
    RelayCommand SearchCommand { get; set; }

    string SearchValue { get; set; }

    void SearchItems();
}
