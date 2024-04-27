namespace Lab9_10CharpT {
    public class InvalidProductException : Exception
    {
        public InvalidProductException(string message) : base(message) { }
    }

    public class InvalidProductTypeException : Exception
    {
        public InvalidProductTypeException(string message) : base(message) { }
    }
    
    public interface IProduct : IComparable
    {
        string Name { get; }
        void DisplayInfo();
        bool IsType(string type);
    }
}