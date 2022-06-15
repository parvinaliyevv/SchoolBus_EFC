namespace SchoolBus.Models;

public partial class Ride
{
    public Ride()
    {
        RideStudents = new ObservableCollection<RideStudent>();

        Driver = new() { FirstName = "www", LastName = ".amazon.com" };
    }

    public int Attends => RideStudents.Count;

    public int Id { get; set; }
    public string Type { get; set; } = null!;
    public int DriverId { get; set; }

    public virtual Driver Driver { get; set; } = null!;
    public virtual ObservableCollection<RideStudent> RideStudents { get; set; }
}
