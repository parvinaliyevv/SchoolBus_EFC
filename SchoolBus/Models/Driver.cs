namespace SchoolBus.Models;

public partial class Driver
{
    public Driver()
    {
        Cars = new HashSet<Car>();
        Rides = new HashSet<Ride>();
    }

    public Car Car => Cars.ToList()[0];
    public string Fullname => FirstName + " " + LastName;

    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string License { get; set; } = null!;
    public int? CarId { get; set; }

    public virtual ICollection<Car> Cars { get; set; }
    public virtual ICollection<Ride> Rides { get; set; }
}
