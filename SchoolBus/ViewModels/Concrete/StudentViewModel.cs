namespace SchoolBus.ViewModels.Concrete;

public class StudentViewModel : ListBaseViewModel<Student>
{
    public ObservableCollection<Parent> Parents { get; set; }
    public ObservableCollection<Group> Groups { get; set; }


    public StudentViewModel()
    {
        Items = new(_dbContext.Students.Include("Parent").Include("Group"));

        Parents = new(_dbContext.Parents);
        Groups = new(_dbContext.Groups);
    }


    public override void SearchItems()
    {
        if (string.IsNullOrWhiteSpace(SearchValue)) Items = new(_dbContext.Students);
        else
        {
            var newItems = new ObservableCollection<Student>();

            foreach (var item in Items)
                if (item.FirstName.Contains(SearchValue) || item.LastName.Contains(SearchValue)) newItems.Add(item);

            Items = newItems;
        }
    }

    public override bool CheckItem()
    {
        if (string.IsNullOrWhiteSpace(InsertItem.FirstName) || string.IsNullOrWhiteSpace(InsertItem.LastName) ||
            string.IsNullOrWhiteSpace(InsertItem.Home) || string.IsNullOrWhiteSpace(InsertItem.OtherAddress)) return false;
        else if (InsertItem.Parent is null || InsertItem.Group is null) return false;

        return true;
    }
}
