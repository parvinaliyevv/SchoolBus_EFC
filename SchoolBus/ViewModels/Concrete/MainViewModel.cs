﻿namespace SchoolBus.ViewModels.Concrete;

public class MainViewModel : DependencyObject
{
    public Page SelectedPage
    {
        get { return (Page)GetValue(MyPropertyProperty); }
        set { SetValue(MyPropertyProperty, value); }
    }
    public static readonly DependencyProperty MyPropertyProperty =
        DependencyProperty.Register("SelectedPage", typeof(Page), typeof(MainViewModel));


    public RelayCommand DisplayCreateRideCommand { get; set; }
    public RelayCommand DisplayRidesCommand { get; set; }
    public RelayCommand DisplayGroupViewCommand { get; set; }
    public RelayCommand DisplayStudentViewCommand { get; set; }
    public RelayCommand DisplayParentViewCommand { get; set; }
    public RelayCommand DisplayDriverViewCommand { get; set; }
    public RelayCommand DisplayCarViewCommand { get; set; }
    public RelayCommand DisplayHolidaysViewCommand { get; set; }


    public MainViewModel()
    {
        SelectedPage = new StudentView();

        DisplayCreateRideCommand = new RelayCommand(sender => SelectedPage = new CreateRide());
        DisplayRidesCommand = new RelayCommand(sender => SelectedPage = new Rides());
        DisplayGroupViewCommand = new RelayCommand(sender => SelectedPage = new GroupView());
        DisplayStudentViewCommand = new RelayCommand(sender => SelectedPage = new StudentView());
        DisplayParentViewCommand = new RelayCommand(sender => SelectedPage = new ParentView());
        DisplayDriverViewCommand = new RelayCommand(sender => SelectedPage = new DriverView());
        DisplayCarViewCommand = new RelayCommand(sender => SelectedPage = new CarView());
        DisplayHolidaysViewCommand = new RelayCommand(sender => SelectedPage = new HolidaysView());
    }
}
