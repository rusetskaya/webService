namespace Gadgets.Interfaces.DTO
{
    public interface IGadgetDTO
    {
        int Id { get; set; }
        string Name { get; set; }
        string Brand { get; set; }
        bool IsFavorite { get; set; }
    }
}