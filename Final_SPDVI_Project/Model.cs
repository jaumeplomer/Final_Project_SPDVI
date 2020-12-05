namespace Final_SPDVI_Project
{
    public class Model
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SellStartDate { get; set; }
        public string SellEndDate { get; set; }

        public override string ToString()
        {
            return $"{Name} , {Description}, {SellStartDate}, {SellEndDate}";
        }
    }
}