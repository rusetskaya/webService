/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Gadgets.Application"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight.Ioc;
using System;

namespace Gadgets.Application.ViewModel
{
    using Gadgets.Application.Modules.EditGadget;

    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<EditGadgetViewModel>();
        }

        public EditGadgetViewModel EditViewModel => SimpleIoc.Default.GetInstance<EditGadgetViewModel>(Guid.NewGuid().ToString());
        public MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>(Guid.NewGuid().ToString());
    }
}
}