﻿namespace SchoolBus.ViewModels.Concrete;

public class StudentViewModel : ListBaseViewModel<Student>
{
    public StudentViewModel()
    {
        Items = new(_dbContext.Students.Include("Parent").Include("Group"));
        InsertItem = new();
    }


    public override bool CheckItem()
    {
        return true;
    }
}
