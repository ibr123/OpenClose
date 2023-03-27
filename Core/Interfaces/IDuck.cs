namespace Core.Interfaces
{
    public interface IDuck
    {
        public string Name{ get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public IDuckImplementation DuckImplementation { get; set; }
    }
}
