using Gadgets.Contract;
using System;
using System.Collections.Generic;
using Gadgets.WcfService.Contracts;

namespace Gadgets.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GadgetService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GadgetService.svc or GadgetService.svc.cs at the Solution Explorer and start debugging.
    public class GadgetService : IGadgetService
    {
        private IBLLGadgetManager _gadgetManager = null;

        public GadgetService(IBLLGadgetManager gadgetManager)
        {
            this._gadgetManager = gadgetManager;
        }
        public Response<Gadget> GetGadget(int id)
        {
            Response<Gadget> res = new Response<Gadget>("GetGadget");

            try
            {
                IGadgetBO bo = this._gadgetManager.GetGadget(id);

                if (bo != null)
                {
                    Gadget gadget = new Gadget(bo);
                    res.IsSuccessful = true;
                    res.Result = gadget;
                }
                else
                {
                    res.IsSuccessful = false;
                    res.Message = "Gadget not found";
                    res.Result = null;
                }
            }
            catch (Exception ex)
            {
                res.IsSuccessful = false;
                res.Message = ex.Message;
                res.Result = null;
            }

            return res;
        }

        public Response<List<Gadget>> GetGadgets()
        {
            Response<List<Gadget>> res = new Response<List<Gadget>>("GetGadgets");

            List<Gadget> gadgets = new List<Gadget>();

            try
            {
                List<IGadgetBO> bo = this._gadgetManager.GetGadgets();
                foreach (IGadgetBO i in bo)
                {
                    Gadget gadget = new Gadget(i);
                    gadgets.Add(gadget);
                }

                res.IsSuccessful = true;
                res.Result = gadgets;
            }
            catch (Exception ex)
            {
                res.IsSuccessful = false;
                res.Message = ex.Message;
                res.Result = null;
            }

            return res;
        }

        public Response<bool> DeleteGadget(int id)
        {
            Response<bool> res = new Response<bool>("DeleteGadget");

            try
            {
                bool del = this._gadgetManager.DeleteGadget(id);
                res.IsSuccessful = del;
                res.Result = del;
            }
            catch (Exception ex)
            {
                res.IsSuccessful = false;
                res.Message = ex.Message;
                res.Result = false;
            }

            return res;
        }

        public Response<long> UpdateGadget(Gadget gadget)
        {
            Response<long> res = new Response<long>("UpdateGadgets");

            try
            {
                IGadgetBO bo = _gadgetManager.GetGadget(gadget.Id);
                if (bo == null)
                    bo = this._gadgetManager.CreateGadget();

                bo.Name = gadget.Name;
                bo.Brand = gadget.Brand;
                bo.IsFavorite = gadget.IsFavorite;
                bool save = bo.Save();

                res.IsSuccessful = save;
                res.Result = bo.Id;
            }
            catch (Exception ex)
            {
                res.IsSuccessful = false;
                res.Message = ex.Message;
                res.Result = 0;
            }

            return res;
        }
    }
}
