using Gadgets.Contract;
using System.Runtime.Serialization;

namespace Gadgets.WcfService.Contracts
{
    [DataContract]
    public class Gadget
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Brand { get; set; }

        [DataMember]
        public bool IsFavorite { get; set; }

        public Gadget()
        {
            Id = 0;
            Name = "";
            Brand = "";
            IsFavorite = false;
        }

        public Gadget(IGadgetBO bo)
        {
            Id = bo.Id;
            Name = bo.Name;
            Brand = bo.Brand;
            IsFavorite = bo.IsFavorite;
        }
    }
}