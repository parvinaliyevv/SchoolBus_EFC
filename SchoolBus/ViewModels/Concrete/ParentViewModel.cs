namespace SchoolBus.ViewModels.Concrete;

public class ParentViewModel : ListBaseViewModel<Parent>
{
    public ParentViewModel()
    {
        Items = new(_dbContext.Parents);
        InsertItem = new();
    }


    public override void InsertDatabase()
    {
        // Some logic code
    }

    public override bool CheckItem()
    {
        return true;
    }
}
