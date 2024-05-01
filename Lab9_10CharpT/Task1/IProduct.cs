namespace Lab9_10CharpT {
    public interface IProduct : IComparable
    {
        string Name { get; }
        void DisplayInfo();
        bool IsType(string type);
    }
}