namespace Gadgets.Contract
{
    using System.Collections.Generic;

    public interface IBLLGadgetManager
    {
        IGadgetBO GetGadget(int id);

        IGadgetBO CreateGadget();

        bool DeleteGadget(int id);

        List<IGadgetBO> GetGadgets();
    }
}