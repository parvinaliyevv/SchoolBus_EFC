namespace SchoolBus.Data;

public static class DI_Container
{
    public static IContainer Container { get; set; }


    static DI_Container()
    {
        var containerBuilder = new ContainerBuilder();

        containerBuilder.RegisterType<SchoolBusDbContext>().AsSelf();

        Container = containerBuilder.Build();
    }
}
