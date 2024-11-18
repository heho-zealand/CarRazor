namespace CarRazor.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string RegNo { get; set; }
        public int HorsePower { get; set; }
        public int Doors { get; set; }

        public Car()
        {
        }   
        public Car(string brand, string model, string regNo, int horsePower, int doors)
        {
            Brand = brand;
            Model = model;
            RegNo = regNo;
            HorsePower = horsePower;
            Doors = doors;
        }
    }
}
