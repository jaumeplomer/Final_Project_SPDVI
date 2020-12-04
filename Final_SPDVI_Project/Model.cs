namespace Final_SPDVI_Project
{
    public class Model
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Description}";
        }

        public string getName()
        {
            return Name;
        }
    }
}