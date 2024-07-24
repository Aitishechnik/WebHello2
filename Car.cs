namespace WebHello2
{
    public class Car
    {
        public static IList<Car> Cars { get; set; }

        static Car()
        {
            Cars = [new Car { Id = 1, Brand = "Toyota", Model = "Rav4" },
            new Car { Id = 2, Brand = "Subaru", Model = "WRX" },
            new Car { Id = 3, Brand = "Audi", Model = "A5" }
            ];
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
