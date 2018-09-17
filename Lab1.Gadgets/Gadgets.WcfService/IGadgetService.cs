using System.Collections.Generic;
using System.ServiceModel;
using Gadgets.WcfService.Contracts;

namespace Gadgets.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGadgetService" in both code and config file together.
    [ServiceContract]
    public interface IGadgetService
    {
        [OperationContract]
        Response<Gadget> GetGadget(int id);

        [OperationContract]
        Response<List<Gadget>> GetGadgets();

        [OperationContract]
        Response<bool> DeleteGadget(int id);

        [OperationContract]
        Response<long> UpdateGadget(Gadget gadget);
    }
}
