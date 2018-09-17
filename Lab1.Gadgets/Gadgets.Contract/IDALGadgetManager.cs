namespace Gadgets.Contract
{
    using System.Collections.Generic;

    public interface IDALGadgetManager
    {
        int Add(IGadgetDAO dao);

        bool Delete(int id);

        IGadgetDAO Get(int id);

        List<IGadgetDAO> GetAll();

        bool Update(IGadgetDAO dao);

        bool IsExist(int id);
    }
}