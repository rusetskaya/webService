using Gadgets.Interfaces.Models;
using Gadgets.Interfaces.DTO;

namespace Gadgets.Interfaces.Factories
{
    public interface IGadgetFactory
    {
        IResult<IGadget> CreateGadget();
        IResult<IGadget> CreateGadget(int id);
        IResult<IGadget> CreateGadget(IGadgetDTO dto);
        //Это, наверное, переделать. Передавать IGadget плоховато
        IResult<IGadget> CreateGadget(IGadget gadget);
    }
}