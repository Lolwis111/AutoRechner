namespace AutoRechner
{
    public class Item
    {
        public Item()
        {
            ID = -1;
            Include = false;
            Position = string.Empty;
            Price = -1;
            Person = Properties.Resources.UserNone;
        }

        public Item(int id, bool include, string position, float preis, string person)
        {
            ID = id;
            Position = position;
            Price = preis;
            Person = person;
            Include = include;
        }

        public int ID { get; set; }
        public string Position { get; set; }
        public float Price { get; set; }
        public string Person { get; set; }

        public bool Include { get; set; }
    }
}
