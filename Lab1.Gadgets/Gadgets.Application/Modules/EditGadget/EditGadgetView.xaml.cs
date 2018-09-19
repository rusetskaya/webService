using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Gadgets.Application.EventArgs;
using GalaSoft.MvvmLight.Messaging;

namespace Gadgets.Application.Modules.EditGadget
{
    /// <summary>
    /// Interaction logic for EditGadget.xaml
    /// </summary>
    public partial class EditGadgetView : Window
    {
        public EditGadgetView()
        {
            InitializeComponent();
            Unloaded += EditGadgetWindow_Unloaded;
            Messenger.Default.Register<CloseWindowEventArgs>(this, CloseWindow);
        }

        private void CloseWindow(CloseWindowEventArgs obj)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void EditGadgetWindow_Unloaded(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Unregister<CloseWindowEventArgs>(this);
        }
    }
}
