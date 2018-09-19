namespace Gadgets.Interfaces
{
    public interface IResult<T>
    {
        T Result { get; set; }
        string Message { get; set; }
        string Method { get; set; }
        bool IsSuccessful { get; set; }
    }
}