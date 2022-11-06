namespace JustStoreIt.Shared;
    public class Bin
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Location { get; set; } = "";
        public IEnumerable<Item> Items { get; set; } = Array.Empty<Item>();
    }