namespace Final_SPDVI_Project
{
    public class Model
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public string Cat { get; set; }
        public string SubCat { get; set; }
        public string ProNumber { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }
        public string Size { get; set; }
        public string ProLine { get; set; }
        public string Clase { get; set; }
        public string Style { get; set; }

        public string SellStartDate { get; set; }
        public string SellEndDate { get; set; }

        public override string ToString()
        {
            return $"{Name}||{Description}||{SellStartDate}||{SellEndDate}";
        }

        public double priceValue()
        {
            double price;
            price = double.Parse(this.Price);
            return price;
        }
    }
}