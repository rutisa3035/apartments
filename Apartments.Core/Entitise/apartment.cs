namespace Apartments.Entitise
{
    public class apartment
    {
        public string City { get; set; }
        public int ApartmentNum { get; set; }
        public int NumRooms { get; set; }
        public int Size { get; set; }
        public int Floor { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }

        internal static void Add(apartment value)
        {
            throw new NotImplementedException();
        }
    }
}
