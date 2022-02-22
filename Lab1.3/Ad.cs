namespace Lab1._3
{
    public class Ad
    {
        public Ad(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }

        public string Name { get; set; }
        public string Image { get; set; }
        public int Priority { get; set; }
        public int Frequency { get; set; }
    }
}