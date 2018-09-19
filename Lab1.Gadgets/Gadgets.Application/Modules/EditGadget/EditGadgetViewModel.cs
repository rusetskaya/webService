using System;

using Gadgets.Application.EventArgs;
using Gadgets.Interfaces.ServicesProxy;
using GalaSoft.MvvmLight;
using Gadgets.Application.Modules.SelectedGadgetProfile;

using GalaSoft.MvvmLight.Command;
using Gadgets.Application.Services;

using GalaSoft.MvvmLight.Messaging;
using Gadgets.Interfaces.Factories;

namespace Gadgets.Application.Modules.EditGadget
{
    using Gadgets.Interfaces.Models;

    public class EditGadgetViewModel : ViewModelBase
    {
        private IGadgetFactory gadgetFactory = null;
        #region Constructors

        public EditGadgetViewModel(OpenEditWindowArgs args, IGadgetServiceProxy gadgetServiceProxy, IDialogService dialogService)
        {
            Args = args;
            GadgetServiceProxy = gadgetServiceProxy;
            DialogService = dialogService;

            switch (args.Type)
            {
                case ActionType.Add:
                    this.CurrentGadget = new SelectedGadget { Id = int.Parse(Guid.NewGuid().ToString()) };//, ReleaseDate = new DateTime(1960, 1, 1) };
                    break;

                case ActionType.Edit:
                    this.CurrentGadget = new SelectedGadget
                    {
                        Id = args.SelectedGadget.Id,
                        Name = args.SelectedGadget.Name,
                        //ReleaseDate = args.SelectedGadget.ReleaseDate,
                        //Type = args.SelectedGadget.Type,
                        Brand = args.SelectedGadget.Brand,
                        IsFavorite = args.SelectedGadget.IsFavorite
                    };
                    break;
            }

            SaveDataCommand = new RelayCommand(SaveData);
        }

        #endregion Constructors

        #region Properties

        public SelectedGadget CurrentGadget { get; set; }
        public IGadgetServiceProxy GadgetServiceProxy { get; }
        public IDialogService DialogService { get; set; }
        public RelayCommand SaveDataCommand { get; set; }
        protected OpenEditWindowArgs Args { get; }

        #endregion Properties

        #region Methods

        private void SaveData()
        {
            if (string.IsNullOrWhiteSpace(this.CurrentGadget.Name))
            {
                DialogService.Warning("Name is required");
                return;
            }

            bool result = false;
            switch (Args.Type)
            {
                case ActionType.Add:
                    result = gadgetFactory.CreateGadget(CurrentGadget).IsSuccessful;

                    break;

                case ActionType.Edit:
                    result = GadgetServiceProxy.UpdateGadget(CurrentGadget).IsSuccessful;
                    break;
            }

            if (result)
            {
                DialogService.ShowMessage($"{Args.Type} gadget successfully");

                Messenger.Default.Send(new CloseWindowEventArgs());
            }
            else
            {
                DialogService.Warning($"Error occured, save data failed");
            }
        }

        #endregion Methods
    }
}