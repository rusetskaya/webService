using System;

using GalaSoft.MvvmLight;

namespace Gadgets.Application.Modules.SelectedGadgetProfile
{
    using Gadgets.Interfaces.DTO;
    using Gadgets.Interfaces.Models;
    public class SelectedGadget : ObservableObject, IGadget
    {
        private DateTime _releaseDate;
        private string _type;
        private string _brand;
        private int _id;
        private bool _isFavorite;
        private string _name;
        private string _imageSource;

        ///// <summary>
        ///// Get or set ReleaseDate value
        ///// </summary>
        //public DateTime ReleaseDate
        //{
        //    get { return this._releaseDate; }
        //    set { this.Set(ref this._releaseDate, value); }
        //}

        ///// <summary>
        ///// Get or set Type value
        ///// </summary>
        //public string Type
        //{
        //    get { return this._type; }
        //    set { this.Set(ref this._type, value); }
        //}

        /// <summary>
        /// Get or set Brand value
        /// </summary>
        public string Brand
        {
            get
            { return this._brand; }
            set
            { this.Set(ref this._brand, value); }
        }

        public IGadget Clone()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get or set Id value
        /// </summary>
        public int Id
        {
            get { return this._id; }
            set { this.Set(ref this._id, value); }
        }

        /// <summary>
        /// Get or set IsFavorite value
        /// </summary>
        public bool IsFavorite
        {
            get { return this._isFavorite; }
            set { this.Set(ref this._isFavorite, value); }
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get or set Name value
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this.Set(ref this._name, value); }
        }

        ///// <summary>
        ///// Get or set ImageSource value
        ///// </summary>
        //public string ImageSource
        //{
        //    get { return this._imageSource; }
        //    set { this.Set(ref this._imageSource, value); }
        //}
    }
}