namespace Gadgets.Interfaces.Models
{
    public interface IGadget
    {
        IGadget Clone();
        int Id { get; set; }
        string Name { get; set; }
        string Brand { get; set; }
        bool IsFavorite{ get; set; }
        bool Save();
    }
}