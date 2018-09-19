using Gadgets.Interfaces;
using Gadgets.Interfaces.DTO;
using Gadgets.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace Gadgets.Interfaces.ServicesProxy
{
    public interface IGadgetServiceProxy
    {
        IResult<IGadgetDTO> GetGadget(long id);
        IResult<List<IGadgetDTO>> GetGadgets();
        IResult<bool> DeleteGadget(long id);
        IResult<int> UpdateGadget(IGadget gadget);
    }
}