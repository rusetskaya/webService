namespace Gadgets.Contract
{
    public interface IGadgetDAO
    {
        int Id { get; set; }
        string Name { get; set; }
        string Brand { get; set; }
        bool IsFavorite { get; set; }
    }
}